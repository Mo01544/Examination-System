-------generateExam-----------

Alter proc generateExam @Cid int , @MCQ int, @TorF int, @EId int
as
	declare @ExamDate date
	set @ExamDate = GETDATE()
	set @EId = IDENT_CURRENT('Exam')+IDENT_INCR('Exam')
	exec insertExam @EId , 50 , @ExamDate

	declare @Qid int

	declare c1 cursor 
	for select top(@MCQ) Qid 
	from Question
	where Cid = @Cid and QType = 'mcq'
	order by newid()

	open c1
	fetch c1 into @Qid

	while @@FETCH_STATUS = 0 
		begin
			insert into ExamQuestion values (@EId,@Qid)
			fetch c1 into @Qid
		end
	close c1
	deallocate c1

	declare c2 cursor 
	for select top(@TorF) Qid
	from Question 
	where Cid = @Cid and QType = 'T/F'
	order by NEWID()

	open c2
	fetch c2 into @Qid

	while @@FETCH_STATUS = 0
		begin
			insert into ExamQuestion values (@EId , @Qid)
			fetch c2 into @Qid
		end

	close c2
	deallocate c2



go

exec generateExam 205 , 5, 5 , 5

--------------------------------------

------#(Courses)and#(Student)

alter Proc [dbo].[NCourse_NumStud] @InstID int
as
begin
	Select  c.Cname as[Course name] ,count(s.SID) as[Number of students]
	from Course c ,GradeStudentCourse s, InstructorCourse I
	where  I.InsID=@InstID and
	c.CID=I.CID and
	c.CID=s.CID
	group by c.Cname
end

GO

exec NCourse_NumStud 5

----------------------------

----------getSutdentgrades
alter proc [dbo].[getSutdentgrades]  @stuId int
as
begin

		select Course.Cname,(Grade) as [Grade] 
		from GradeStudentCourse ,Course
		where GradeStudentCourse.CID=Course.CID and
		GradeStudentCourse.SID=@stuId
end
GO

exec getSutdentgrades 3

-------------------------------

---exam correction
alter proc ExamCorrection @SID int,@ExamID int,@Cid int
as
declare @SAandMA_Table table(QID int,StudentAns varchar(1),ModelAns varchar(1))
insert into @SAandMA_Table
select Q.QId ,SEQ.StudentAnswer ,Q.Model_Answer from StudentExamQuestion SEQ,Question Q 
where  Q.QId=SEQ.QId and SEQ.SId=@SID and SEQ.ExamId=@ExamID
declare @Counter int=0
declare @Grade int=0

--select *from @SAandMA_Table
	    select @Grade=Grade from GradeStudentCourse GSC,StudentExamCourse SEC where GSC.SId=@SID and GSC.CId=SEC.Cid and SEC.ExamId=@ExamID
		set @Grade=0
declare CorrectionCursor cursor
for 
select QID,StudentAns,ModelAns from @SAandMA_Table
DECLARE @QuesID INT, @StudentAnswer VARCHAR(1), @ModelAnswer VARCHAR(1)
		OPEN CorrectionCursor
		fetch CorrectionCursor into @QuesID,@StudentAnswer,@ModelAnswer
		while (@@FETCH_STATUS=0)
		begin
		     if(@StudentAnswer=@ModelAnswer)
			 begin
			     set @Grade+=1
			 end
			 fetch CorrectionCursor into @QuesID,@StudentAnswer,@ModelAnswer
		end
		close CorrectionCursor
		select @Grade
update GradeStudentCourse  set Grade=@Grade where SId=@SID and CId=@Cid 




exec ExamCorrection 1,1,206

---------------------------------

---------Exam Details

alter proc ExamDetails @Examid int
as
select E.ExamId,
       E.ExamDuration,
	   E.ExamDate,
	   Q.QId,
	   Q.QType,
	   Q.QDescription,
	   Q.Model_Answer  
from Exam E,ExamQuestion EQ,Question Q ,StudentExamQuestion SEQ
where E.ExamId=@Examid and E.ExamId=Eq.ExamId and Eq.QId=Q.QId and SEQ.QId=Q.QId


ExamDetails 2

----------------------------------

---------getDepratmentStudents
create proc [dbo].[getDepratmentStudents] @id int
as
begin

	select _User.* from Department ,_User,Student
	where Department.DeptID=Student.Deptid 
	and _User.UID=Student.StID
	and Department.DeptID=@id;

end
GO

exec getDepratmentStudents 101

------------------------------------------

------------studentAnswers
create proc [dbo].[studentAnswers] @examID int , @studentID int
as 
begin
select QDescription as[Description],StudentAnswer as [Answer] from StudentExamQuestion
inner join Question
on Question.QID = StudentExamQuestion.QID
where SID = @studentID and  ExamId = @examID 
end
GO

exec studentAnswers 1 , 1

-------------------------------

-----------getExamQuestions
alter proc [dbo].[getExamQuestions]  @Eid int
	as
	begin
		select  Question.QDescription,answers from Question inner join
		(
		select Choices.QID, STRING_AGG(Choices.Description,'  ,  ') as answers
		from Choices
		GROUP BY Choices.QID) as tab
		on tab.QID = Question.QID
		inner join ExamQuestion
		on ExamQuestion.QID = Question.QID

		where ExamQuestion.ExamId = @Eid
		union
		select Question.QDescription,'True Or False' from Question
		inner join ExamQuestion
		on Question.QID = ExamQuestion.QID
		where
		QType = 'T/F' and ExamId = @Eid

		end
GO
exec getExamQuestions 4

--------------Exam_Answers

alter proc Exam_Answers @eID int, @stuId int,
					     @Ans1 char,@Ans2 char,@Ans3 char,@Ans4 char,@Ans5 char,
						@Ans6 char,@Ans7 char,@Ans8 char,@Ans9 char,@Ans10 char
as
begin
		declare c1 cursor
		for select  QID
			from ExamQuestion
			where ExamId=@eID 
		for read only   
		declare @QuestionID int
		declare @count int
		set @count =0
		open c1
		fetch c1 into @QuestionID
		while @@FETCH_STATUS=0	
			begin
			if @count =0
				insert into StudentExamQuestion values (@stuId,@QuestionID,@eId,@Ans1)
			else if @count=1
				insert into StudentExamQuestion values (@stuId,@QuestionID,@eId,@Ans2)
			else if @count=2
				insert into StudentExamQuestion values (@stuId,@QuestionID,@eId,@Ans3)
			else if @count=3
				insert into StudentExamQuestion values (@stuId,@QuestionID,@eId,@Ans4)
			else if @count=4
				insert into StudentExamQuestion values (@stuId,@QuestionID,@eId,@Ans5)
			else if @count=5
				insert into StudentExamQuestion values (@stuId,@QuestionID,@eId,@Ans6)
			else if @count=6
				insert into StudentExamQuestion values (@stuId,@QuestionID,@eId,@Ans7)
			else if @count=7
				insert into StudentExamQuestion values (@stuId,@QuestionID,@eId,@Ans8)
			else if @count=8
				insert into StudentExamQuestion values (@stuId,@QuestionID,@eId,@Ans9)
			else
				insert into StudentExamQuestion values (@stuId,@QuestionID,@eId,@Ans10)
			set @count =@count+1
		    fetch c1 into  @QuestionID
			end
		close c1
		deallocate c1



end

exec Exam_Answers 1 , 2 , 'B','A','B','A','A','B','B','B','A','B'