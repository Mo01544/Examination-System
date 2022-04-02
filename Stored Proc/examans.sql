create proc Exam_Answers @eID int, @stuId int,
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
				insert into StudentExamQuestion values (@stuId,@eId,@QuestionID,@Ans1)
			else if @count=1
				insert into StudentExamQuestion values (@stuId,@eId,@QuestionID,@Ans2)
			else if @count=2
				insert into StudentExamQuestion values (@stuId,@eId,@QuestionID,@Ans3)
			else if @count=3
				insert into StudentExamQuestion values (@stuId,@eId,@QuestionID,@Ans4)
			else if @count=4
				insert into StudentExamQuestion values (@stuId,@eId,@QuestionID,@Ans5)
			else if @count=5
				insert into StudentExamQuestion values (@stuId,@eId,@QuestionID,@Ans6)
			else if @count=6
				insert into StudentExamQuestion values (@stuId,@eId,@QuestionID,@Ans7)
			else if @count=7
				insert into StudentExamQuestion values (@stuId,@eId,@QuestionID,@Ans8)
			else if @count=8
				insert into StudentExamQuestion values (@stuId,@eId,@QuestionID,@Ans9)
			else
				insert into StudentExamQuestion values (@stuId,@eId,@QuestionID,@Ans10)
			set @count =@count+1
		    fetch c1 into  @QuestionID
			end
		close c1
		deallocate c1



end
