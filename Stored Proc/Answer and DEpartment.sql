----------number1
create proc getDepartmentStudent @st_id
as 
select d.DeptName from[dbo].[Department] as d ,[dbo].[Student]as s where s.Deptid=d.DeptID and StID= @st_id
----------number2
create proc getDepartmentByStudentName @username varchar(50)
as
select  DeptName from [dbo].[User] as u,[dbo].[Student] as s,[dbo].[Department]as d where UID=StID and  s.Deptid=d.DeptID and userName=@username

 getDepartmentByStudentName ahmedd
 --------number 3
Alter proc getDepartmentByStudentFullName @FName varchar(50),@LName varchar(50)
as 
if exists(select FName=@FName,LName=@LName from [dbo].[User])
select DeptName from [dbo].[User] as u,[dbo].[Student] as s,[dbo].[Department]as d where u.UID=s.StID and  s.Deptid=d.DeptID and FName= @FName and LName=@LName
else 
select'NOT Found'
GO
getDepartmentByStudentFullName 
-------------number 3
Alter proc getDepartment @D_id int 
as 
if Exists (select DeptID=@D_id from Department)
select FName+''+LName as FullName from [dbo].[User] as u,[dbo].[Department] as d ,[dbo].[Student]as s where s.Deptid=d.DeptID and s.DeptID=@D_id
else
select'NOT Found'
GO
getDepartment 1
---------number 4------------(student Answer)

create proc StudentAnswer @StID INT, @ExID INT, @QuesID INT, @QuesAns VARCHAR(1)
as 
insert into [dbo].[StudentExamQuestion]
values( @StID , @ExID,@QuesID,@QuesAns )
----------------number 5-----------------
CREATE TYPE AnswersTableType AS TABLE
(
	QuesID INT,
	Answer VARCHAR(1)
)

Go

create proc getAllAnswers @StID INT, @ExID INT, @AnswersTable AnswersTableType READONLY
AS
if not exists(select StID from Student where StID= @StID)
  select'ERROR:enter correct stid'
 else
 begin 
 DECLARE ExamAnswerCursor CURSOR
	FOR
		SELECT QuesID, Answer
		FROM @AnswersTable
		DECLARE @QuesID INT, @Answer VARCHAR(1)
	    OPEN ExamAnswerCursor
		FETCH ExamAnswerCursor INTO @QuesID, @Answer
		WHILE(@@FETCH_STATUS = 0)
		insert into [dbo].[StudentExamQuestion] values(@StID, @ExID, @QuesID,@Answer)	
		CLOSE ExamAnswerCursor
    	DEALLOCATE ExamAnswerCursor
		
End