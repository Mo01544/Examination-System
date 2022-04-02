-------- User PROCEDURES ---------

alter proc InsertUser 
(	@UserName varchar(50),
	@Password nchar(10),
	@FName nchar(10),
	@LName nchar(10),
	@Address nchar(50)=NULL,
	@Birth_Date date=NULL
	,@UserType nchar(1)
)
as
	
	insert into _User
		values(@UserName,@Password,@FName,@LName,@Address,@Birth_Date,@userType)
		declare @uId int
		declare @date date
		set @uId = IDENT_CURRENT('_User')
		set @date = GETDATE()
	 if (@UserType='s')
		exec insertStudent @uId
	else if (@UserType='i')
		exec Insert_Instructor @uId , 0 , @date

go
InsertUser 'nada','4567','morsi','ahmed','Benha','1-11-1996','i'


--deleteUser
create proc deleteUser @Id int
as
	if	not exists(select StID from Student where @Id=StID) or
		not exists(select InsID from Instructor where @Id=InsID) 
		delete from _User where @Id=UID                    
	else
		select 'the User Has Relation'

deleteUser 2
-----------------

--selectUser By Id 
create proc SelectUser @Id int
as
	if not exists(select UID from _User where @Id=UID)
		  select 'the User not Found'                    
	else
		 select*from _User where @Id=UID


SelectUser 1

------------------
--select User All 

create proc SelectAllUsers 
as
	select * from _User
go
	
------------------
--update user
alter proc updateUser @Id int,@UserName varchar(50),@Password nchar(10),@FName nchar(10),
                       @LName nchar(10),@Address nchar(50)=NULL,@Birth_Date date=NULL
					   ,@UserType nchar(1)
as
		if not exists(select UID from _User where @Id=UID)
			select 'the User not Found'                    
		else
			update _User set userName=@UserName
	                  ,Password=@Password
					  ,FName=@FName
					  ,LName=@LName
					  ,Address=@Address
					  ,Birth_Date=@Birth_Date
					  ,UserType=@UserType
					  where [UID]=@id 

updateUser 1,'ahmed','23456','ahmed','morsi','Tokh','2-2-2000','s'

-------- End User PROCEDURES ---------

-------- Student PROCEDURES ---------
-- Insert Student --
create proc insertStudent @ID int,@DepID int=Null
as
	if not exists (Select * from Student where StId=@ID)
	insert into Student
	values (@ID,@DepID)
	else
	select'Student is already existed'
go


-- Update Student --

Create proc updateStudent @ID int ,@DepID int
as
	if exists (Select * from Student where StId=@ID)
	update Student set Deptid=@DepID  where StID=@ID
	else
	select 'Student is not existed'

exec updateStudent 1,1
-- Delete Student --
Create proc deleteStudent @ID int
as
	if not exists (select * from Student where StID=@ID)
	select'Student is not found'
	else
	delete from Student where StID=@ID

exec deleteStudent 1

-- Select All Students --
create proc selectStudent
as
	select * from Student
go
exec selectStudent

-- Select Student --
create proc selectStudentById @ID int
as
	if exists (Select * from Student where StId=@ID)
	select * from Student where StID =@ID
	else
	select 'Student is not found'
go

-------- End Student PROCEDURES ---------

/* START INSTRUCTOR PROCEDURES*/
CREATE PROC [dbo].[Select_Instructor] @I_ID int
AS
BEGIN
	SELECT * FROM Instructor WHERE InsID = @I_ID
END

GO


CREATE PROC [dbo].[Select_Instructor_All] 
AS
BEGIN
	SELECT * FROM Instructor
END

GO

alter PROC [dbo].[Insert_Instructor] @Ins_ID int, @Salary int, @Hire_Date date, @DID int = NULL
AS
BEGIN
	IF not EXISTS (SELECT Instructor.InsID FROM Instructor WHERE InsID = @Ins_ID)
		INSERT INTO Instructor values(@Ins_ID,@Salary,@Hire_Date , @DID)
	ELSE
		SELECT CONCAT('Instructor # ', @Ins_ID, ' Already Exists')
END

GO

CREATE PROC [dbo].[Update_Instructor] @Ins_ID int, @Salary int, @Hire_Date date, @DID int
AS
BEGIN
	IF EXISTS(SELECT Instructor.InsID FROM Instructor WHERE InsID = @Ins_ID)
		UPDATE Instructor
			SET InsID = ISNULL(@Ins_ID, InsID),
				Salary = ISNULL(@Salary, Salary),
				HireDate = ISNULL(@Hire_Date, HireDate),
				DeptId = ISNULL(@DID, DeptId)
			WHERE InsID = @Ins_ID
	ELSE
		SELECT CONCAT(' Instructor # ', CAST(@Ins_ID AS varchar(20)) ,' Does not Exist')
END

GO


alter PROC [dbo].[Delete_Instructor] @Ins_ID int
AS
BEGIN
	
	IF EXISTS(SELECT Instructor.InsID FROM Instructor WHERE InsID = @Ins_ID)
	BEGIN
		IF	EXISTS (SELECT* FROM InstructorCourse WHERE InsID = @Ins_ID)
			SELECT CONCAT('Instructor # ', CAST(@Ins_ID AS varchar(20)), 'Cannot be Deleted')
		ELSE
			DELETE FROM Instructor WHERE InsID = @Ins_ID
	END
END

GO
exec Delete_Instructor 2
/* END INSTRUCTOR PROCEDURES*/

/* START DEPARTMENT PROCEDURES*/

CREATE PROC [dbo].[Select_Department] @D_ID int
AS
BEGIN
	SELECT * FROM Department WHERE DeptID = @D_ID
END

GO


CREATE PROC [dbo].[Select_Department_All] 
AS
BEGIN
	SELECT * FROM Department
END

GO

alter PROC [dbo].[Insert_Department] @Dname varchar(20),@Dmanager int = NULL
AS
BEGIN
	IF not EXISTS (SELECT * FROM Department WHERE DeptName = @Dname)
		INSERT INTO Department values(@Dname, @Dmanager)
	ELSE
		SELECT CONCAT('Department -> ', @Dname, ' Already Exists')
END

GO

CREATE PROC [dbo].[Update_Department] @D_ID int, @Dname varchar(20),@Dmanager int
AS
BEGIN
	IF EXISTS(SELECT * FROM Department WHERE DeptID = @D_ID)
		UPDATE Department 
			SET DeptName = ISNULL(@Dname, DeptName),
				ManagerID = ISNULL(@Dmanager, ManagerID)
			WHERE DeptID = @D_ID
	ELSE
		SELECT CONCAT(' Department # ', CAST(@D_ID AS varchar(20)) ,' Does not Exist')
END

GO


CREATE PROC [dbo].[Delete_Department] @D_ID int
AS
BEGIN
	
	IF EXISTS(SELECT * FROM Department WHERE DeptID = @D_ID)
	BEGIN
		IF	EXISTS (SELECT * FROM Student WHERE Deptid = @D_ID)
			SELECT CONCAT('Department # ', CAST(@D_ID AS varchar(20)), 'Cannot be Deleted')
		ELSE
			DELETE FROM Department WHERE DeptID = @D_ID
	END

END

GO

/* END DEPARTMENT PROCEDURES*/

-------- Course PROCEDURES ---------

--insert Course 
create proc InsertONCourse @CName nchar(10),@Duration int =200
as
		insert into Course (CName,CDuration) values(@CName,@Duration)

InsertONCourse 'C#'

-------------------------------------------------------------------

--delete Course Procedure
create proc DeleteONCourse @ID int
as
	if     (
			not exists (select CId from Topic where @ID=CId) and
			not exists (select Cid from Question where @ID=Cid) and
			not exists (select CId from GradeStudentCourse where @ID=CId) and
			not exists (select CId from InstructorCourse where @ID=CId)and
			not exists (select Cid from StudentExamCourse where @ID=Cid)
			)
		Delete from Course where @ID=CId
	else
		select 'course Table Has A Relations' as Result

DeleteONCourse 202

-------------------------------------------------------------------

--select Course Proc

create proc SelectONCourse @ID int
as
	if not exists (select *from Course where @ID=CId)
	     select 'this course Not Found To be Displayed' as Result
	else
		 Select * from Course where @ID=CId


SelectONCourse 200

------------------------------------------------------
--Select Choices All

create proc SelectAllCourses 
as
	select * from Course
go

------------------------------------------------------

--Update Course Procedure
create proc UpdateONCourse @ID int ,@Name nchar(10),@Duration int =200
as
	if not exists (select *from Course where @ID=CId)
		 select 'this course Not Found To be Updated' as Result
	else
		 Update Course set  CDuration=@Duration ,CName=@Name where @ID=CId


UpdateONCourse 200,'SQL',100
-------------------------------------------------------------------

-------- End Course PROCEDURES ---------

/* START TOPIC PROCEDURES*/

CREATE PROC [dbo].[Select_Topic] @TP_ID int, @TP_Name varchar(20)
AS
BEGIN
	SELECT * FROM Topic WHERE TopicName = @TP_Name
END

GO


CREATE PROC [dbo].[Select_Topic_All]
AS
BEGIN
	SELECT * FROM Topic
END

GO

CREATE PROC [dbo].[Insert_Topic] @TP_ID int, @TP_Name varchar(20)
AS
BEGIN
	IF not EXISTS (SELECT * FROM Topic WHERE TopicName = @TP_Name)
		INSERT INTO Topic
			VALUES (@TP_ID, @TP_Name)
	ELSE
		SELECT CONCAT('TOPIC -> ', @TP_Name, ' Already Exists')
END

GO


CREATE PROC [dbo].[Update_Topic] @TP_ID int, @Old_TP_Name varchar(20), @TP_Name varchar(20)
AS
BEGIN
	IF EXISTS(SELECT Topic.CID FROM Topic WHERE TopicName = @Old_TP_Name)
		UPDATE Topic 
			SET TopicName = @TP_Name
			WHERE TopicName = @Old_TP_Name
	ELSE
		SELECT CONCAT('TOPIC ', @Old_TP_Name, ' Does not Exist')
END

GO


CREATE PROC [dbo].[Delete_Topic] @TP_ID int, @TP_Name varchar(20)
AS
BEGIN
	IF EXISTS(SELECT TopicName FROM Topic WHERE Topic.CID = @TP_ID and TopicName = @TP_Name)
		DELETE FROM Topic 
			WHERE	Topic.CID = @TP_ID 
					and 
					TopicName = @TP_Name
END

GO

/* END TOPIC PROCEDURES*/

-------- Choice PROCEDURES ---------


create proc InsertChoices @QID int,@Choice varchar(1),@Description nchar(300)
as
	if not exists(select QId from Question where @QID=QId)
		    select 'the Question you try to enter its Choices Not Found ...' as Result
	else if not exists(select QId ,Choice from Choices where QId=@QID and @Choice=Choice)
			insert into Choices values(@QID,@Choice,@Description)

	else 
			select 'this Choice you try to  insert is already.....'


InsertChoices 1,'A','Simple tables'
InsertChoices 1,'B','Virtual tables'
InsertChoices 1,'C','Complex tables'
InsertChoices 1,'D','Actual Tables'


InsertChoices 2,'A','Only 1'
InsertChoices 2,'B','Only 2'
InsertChoices 2,'C','Depends on no of Columns'
InsertChoices 2,'D','Depends on DBA'


-----------------------------
--Delete Choices
create proc DeleteChoices @Qid int,@Choice varchar(1)
as
	if not exists (select QId ,Choice from Choices where QId=@QID and @Choice=Choice)
		        select 'this choice Not Found to be deleted'
	else  
				delete from Choices where QId=@QID and @Choice=Choice


DeleteChoices 1,'A'


-----------------------------
--Update Choices
create proc UpdateChoices @Qid int,@Choice varchar(1),@Description nchar(300)
as
	if not exists (select QId ,Choice from Choices where QId=@QID and @Choice=Choice)
		        select 'this choice Not Found to be Updated'
	else  
				Update  Choices set Description=@Description where QId=@QID and @Choice=Choice

UpdateChoices 1,'B','REMOVE'
------------------------------------------
--Select Choices By Id
alter proc SelectChoices @Qid int
as	
	if not exists (select QId ,Choice from Choices where QId=@QID )
				select 'this choice Not Found to be Displayed'
	else  
				select * from Choices where QId=@QID 


SelectChoices 1

------------------------------------------
--Select Choices All
create proc SelectAllChoice 
as
	select * from Choices

go

-------- End Choice PROCEDURES ---------

------------------ Exam PROCEDURES ------------------
-- Insert Exam --
Create proc insertExam @ID int, @Duration int=Null, @Date date=Null
as
	if not exists (Select * from Exam where ExamId=@ID)
	insert into Exam(ExamDuration,ExamDate)
	values (@Duration,@Date)
	else
	select 'Exam is alreary existed'
go


-- Update Exam --
Create proc updateExam @ID int, @Duration int=Null, @Date date=Null
as
	if  exists (Select * from Exam where ExamId=@ID)
	update Exam set ExamDuration=@Duration,ExamDate=@Date
	where ExamId=@ID
	else
	select 'Exam is not existed'

exec updateExam 1 , 50 , null
-- Delete Exam --
Create proc deleteExam @ID int
as
	if not exists (select * from Exam where ExamId=@ID)
	select'Exam is not found'
	else
	delete from Exam where ExamId=@ID

-- Select All Exams --

create proc selectExams
as
	select * from Exam
go
exec selectExams

-- Select Exam --
create proc selectExamById @ID int
as
	if  exists (Select * from Exam where ExamId=@ID)
	select * from Exam where ExamId=@ID
	else
	select 'Exam s not found'
go

------------------ End Exam PROCEDURES ------------------

------------------ Question PROCEDURES ------------------

-- Insert Question --
alter proc insertQuestion @ID int, @Description varchar(MAX), @Type nchar(5), @ModelAns nchar(1), @CID int=Null
as
	if not exists (Select * from Question where QId=@ID)
	insert into Question(QDescription,QType,Model_Answer,Cid)
	values (@Description ,@Type,@ModelAns,@CID)
	else
	select 'Question is already existed'
go

-- Update Question --
Create proc updateQuestion @ID int, @Type nchar(5)=Null, @Description int=Null, @ModelAns nchar(1)=Null, @CID int=Null
as
	if exists (Select * from Question where QId=@ID)
	update Question set QType=@Type ,QDescription=@Description,Model_Answer=@ModelAns,Cid=@CID
	where QId=@ID
	else select 'Question is not existed'

-- Delete Question --
Create proc deleteQuestion @ID int
as
	if not exists (select * from Question where QId=@ID)
	select'Question is not found'
	else
	delete from Question where QId=@ID

-- Select ALL Questions --
create proc selectQuestions
as
	select * from Question
go
exec selectQuestions

-- Select Question --
create proc selectQuestionById @ID int
as
	if exists (select * from Question where QId=@ID)
	select * from Question where QId=@id
	else
	select 'Question is not found'
go

-------------------- End Question PROCEDURES --------------------

-------crud of table [dbo].[ExamQuestion]
-----select All
create proc DisplayExamIdAndQuesId
as
	select * from [dbo].[ExamQuestion]
go


----select based on Id---------
create proc DisplayExamId_QuesId @Exam_ID int
as
	select * from [dbo].[ExamQuestion]
	where ExamID =@Exam_ID
go


------------------------
----insert Operation
CREATE PROC [dbo].[Insert_Exam_Question] @E_ID int, @Q_ID int
AS
	BEGIN
	IF not EXISTS (SELECT * FROM ExamQuestion WHERE Examid = @E_ID and QID = @Q_ID)
		INSERT INTO ExamQuestion
			VALUES (@E_ID, @Q_ID)
	ELSE
		SELECT CONCAT(' Question # ', CAST(@Q_ID AS varchar(20)), 'For Exam #', CAST(@E_ID AS varchar(20)),' Already Exists')
	END
GO


--------update
create PROC [dbo].[Update_Exam_Question] @E_ID int, @Q_ID int , @x int , @y int
AS
	BEGIN
		IF EXISTS(SELECT * FROM ExamQuestion WHERE ExamID = @E_ID and QID = @Q_ID)
			UPDATE ExamQuestion
			SET ExamId = ISNULL(@x,@E_ID),
			QID = ISNULL(@y,@Q_ID)
				WHERE ExamID = @E_ID and QID = @Q_ID
		ELSE
			SELECT CONCAT(' Question # ', CAST(@Q_ID AS varchar(20)), 'For Exam #', CAST(@E_ID AS varchar(20)),' Does not Exist')
END

GO



exec Update_Exam_Question 2,2,2,3

----------DElete-----------
create PROC sp_DeleteExam_Question @Exam_id int, @Qid int
as
	BEGIN
	delete from [dbo].[ExamQuestion]
		where ExamId=@Exam_id and QId=@Qid
End

sp_DeleteExam_Question 1,2


-----------[dbo].[InstructorCourse]--------------------
---select All------
create proc DisplayInstructorCourse
as 
	select*from[dbo].[InstructorCourse]
go
-----select based on Id-----
create proc DisplayInstructor_Course @ins_ID int
as 
	select * from[dbo].[InstructorCourse]
		where InsId=@ins_ID
go
---------------------------------------------------
-------insert[dbo].[InstructorCourse]-------------
create proc insertInstructorCourse @id1 int ,@id2 int 
as
begin
	if not exists(select InsID,CId from[dbo].[InstructorCourse]where InsID=@id1 and CId=@id2)
		insert into[dbo].[InstructorCourse]
			values(@id1,@id2)
	else
		select'Duplicate'
end 


-----------------------------
---------update---------
create proc sp_updateInstructorCourse @old_CID int, @old_InsID int,@new_InId INT , @new_CID int
as
begin
	IF EXISTS(select*from InstructorCourse where InsId= @old_InsID and CId= @old_CID) 
		update InstructorCourse
		set InsId=isnull(@new_InId,@old_InsID),CId=isnull(@new_CID, @old_CID)
		where InsId= @old_InsID and CId= @old_CID 
	else
		select'Duplicat'
End 


------------DElEte-------------
create proc sp_DeleteInstructorCourse @In_id int ,@Cid int
as
	begin
	if EXISTS(select InsId from InstructorCourse where InsId=1 and CId=@Cid)
		Delete from [dbo].[InstructorCourse]
			where  InsId= @In_id and CId= @Cid
	else 
		select'Not Found'
end 


----------[dbo].[GradeStudentCourse] Table-----------
---------select based on ID-----------
create proc sp_selectGrade @StID int ,@CID int 
as 
	Begin 
		select Grade from[dbo].[GradeStudentCourse] where SId= @StID and CId=@CID
	end


 --------selectAll--------
 create proc sp_SelectAll 
 as 
	select*from [dbo].[GradeStudentCourse]
 Go

 -------insert--------
create proc sp_insert_GradeStudentCourse  @StID int,@CID int,@Grade int
 as 
	if not Exists(select SId , CId from [dbo].[GradeStudentCourse] where SId=@StID and CId=@CID) 
		insert into [dbo].[GradeStudentCourse]
		values(@StID,@CID,@Grade)
	else
		select'Duplicate'
 GO


 ----------update---------
 create proc sp_updateGrade @StID int,@CID int,@Grade int
 as 
	begin
		update [dbo].[GradeStudentCourse]
		set  Grade=@Grade
		where  SId= @StID and CId=@CID
 end 
 

 ---------Delete All-----------
 create proc sp_DelteGradeStudentCourse @StID int,@CID int,@Grade int
 as 
	begin 
		 delete from [dbo].[GradeStudentCourse] where SId= @StID and CId=@CID and  Grade=@Grade
	end 
 GO


 -----------Delete---------
create proc sp_DelteGrade @StID int,@CID int
 as
	if Exists (select * from [dbo].[GradeStudentCourse] where SId= @StID and CId=@CID)
		delete from [dbo].[GradeStudentCourse] where SId= @StID and CId=@CID 
	else
		select 'Not Found'

-------------------- End GradeSTUDENT_COURSE PROCEDURES -------
---------------------------------------------------
-------------------- START STUDENT_EXAM_COURSE PROCEDURES -------

-- Select By id
CREATE PROC [dbo].[Select_Student_EXAM_Course] @S_ID int, @E_ID int, @C_ID int
AS
BEGIN
	SELECT * FROM StudentExamCourse WHERE SID = @S_ID and ExamId = @E_ID and CID = @C_ID
END

GO

--select All 
CREATE PROC [dbo].[Select_Student_EXAM_Course_All]
AS
BEGIN
	SELECT * FROM StudentExamCourse
END

GO

-- insert in StudentExamCourse
CREATE PROC [dbo].[Insert_Student_EXAM_Course] @S_ID int, @E_ID int, @C_ID int
AS
BEGIN
	IF not EXISTS (SELECT * FROM StudentExamCourse WHERE SID = @S_ID and ExamId = @E_ID and CID = @C_ID)
		INSERT INTO StudentExamCourse
			VALUES (@S_ID, @E_ID, @C_ID)
	ELSE
		SELECT CONCAT(' Student # ', CAST(@S_ID AS varchar(20)), 'For Course #', CAST(@C_ID AS varchar(20)), 'For Exam #', CAST(@E_ID AS varchar(20)),' Already Exists')
END

GO

--update in StudentExamCourse

Create PROC [dbo].[Update_Student_EXAM_Course] @S_ID int, @E_ID int, @C_ID int,@newSid int , @newEid int , @newCid int
AS
BEGIN
	IF EXISTS(SELECT * FROM StudentExamCourse WHERE SID = @S_ID and ExamId = @E_ID and CID = @C_ID)
		UPDATE StudentExamCourse 
			SET SID = ISNULL(@newSid, @S_ID),
				ExamId = ISNULL(@newEid, @E_ID),
				CID = ISNULL(@newCid, @C_ID)
			WHERE SID = @S_ID and ExamId = @E_ID and CID = @C_ID
	ELSE
		SELECT CONCAT(' Student # ', CAST(@S_ID AS varchar(20)), 'For Course #', CAST(@C_ID AS varchar(20)), 'For Exam #', CAST(@E_ID AS varchar(20)),' Does not Exist')
END

GO


exec Update_Student_EXAM_Course 1,2,1,1,1,1



--Delete StudentExamCourse
CREATE PROC [dbo].[Delete_Student_EXAM_Course] @S_ID int, @E_ID int, @C_ID int
AS
BEGIN
	IF EXISTS(SELECT * FROM StudentExamCourse WHERE SID = @S_ID and ExamId = @E_ID and CID = @C_ID)
		DELETE FROM StudentExamCourse WHERE SID = @S_ID and ExamId = @E_ID and CID = @C_ID
END

GO
--------------- END STUDENT_EXAM_COURSE PROCEDURES ---------


--------------- START Student-EXAM-QUESTION PROCEDURES -------------

-- select by id
CREATE PROC [dbo].[Select_Student_Exam_Question] @S_ID int, @E_ID int, @Q_ID int
AS
BEGIN
	SELECT * FROM StudentExamQuestion WHERE SID = @S_ID and ExamId = @E_ID and QID = @Q_ID
END

GO

--select all data
CREATE PROC [dbo].[Select_Student_Exam_Question_All]
AS
BEGIN
	SELECT * FROM StudentExamQuestion
END

GO


CREATE PROC [dbo].[Insert_Student_Exam_Question] @S_ID int, @E_ID int, @Q_ID int, @S_Answer char
AS
BEGIN
	IF not EXISTS (SELECT * FROM StudentExamQuestion WHERE SID = @S_ID and ExamId = @E_ID and QID = @Q_ID)
		INSERT INTO StudentExamQuestion
			VALUES (@S_ID, @E_ID, @Q_ID, @S_Answer)
	ELSE
		SELECT CONCAT(' Student # ', CAST(@S_ID AS varchar(20)), 'For Exam #', CAST(@E_ID AS varchar(20)), 'For Question #', CAST(@Q_ID AS varchar(20)),' Already Exists')
END

GO

-- Update in StudentExamQuestion
CREATE PROC [dbo].[Update_Student_Exam_Question] @S_ID int,  @Q_ID int ,@E_ID int,@newSid int , @newQid int, @newEid int 
AS
BEGIN
	IF EXISTS (SELECT * FROM StudentExamQuestion WHERE SID = @S_ID and ExamId = @E_ID and QID = @Q_ID)
		UPDATE StudentExamQuestion 
			SET SID = ISNULL(@newSid, @S_ID),
				QID = ISNULL(@newQid, @Q_ID),
				ExamId = ISNULL(@newEid, @E_ID)
				
			WHERE SID = @S_ID and ExamId = @E_ID and QID = @Q_ID
	ELSE
		SELECT CONCAT(' Student # ', CAST(@S_ID AS varchar(20)), 'For Exam #', CAST(@E_ID AS varchar(20)), 'For Question #', CAST(@Q_ID AS varchar(20)),' Does not Exists')
END

GO

exec Update_Student_Exam_Question 1,2,1,1,1,1

--Delete in StudentExamQuestion

CREATE PROC [dbo].[Delete_Student_Exam_Question] @S_ID int, @E_ID int, @Q_ID int
AS
BEGIN
	IF EXISTS(SELECT * FROM StudentExamQuestion WHERE SID = @S_ID and ExamId = @E_ID and QID = @Q_ID)
		DELETE FROM StudentExamQuestion WHERE SID = @S_ID and ExamId = @E_ID and QID = @Q_ID
END

GO

exec Delete_Student_Exam_Question 1,2,2


----------------- END Student-EXAM-QUESTION PROCEDURES ---------------

