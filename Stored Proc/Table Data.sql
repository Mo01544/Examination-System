 ---insert user
 
 exec  InsertUser  'ahmed','1234','ahmed','morsi','cairo','1998-10-19','s'
 exec  InsertUser  'mahmoud','1234','mahmoud','salem','mnofia','2002-5-19','s'
 exec  InsertUser  'mariam','1234','ahmed','ibrahim','cairo','2000-10-19','s'
 exec  InsertUser  'aya','1234','aya','mohamed','benha','2005-10-19','s'
 exec  InsertUser  'nada','1234','nade','ahmed','cairo','1995-10-19','i'
 exec  InsertUser  'ali','1234','ali','ahmed','cairo','1990-10-19','i'
 exec  InsertUser  'khaled','123456789','khaled','mostafa','ain shams','2006-10-19','i'
 exec  InsertUser  'manar','123456789','manar','ahmed','cairo','1980-10-19','i'
 exec  InsertUser  'mona','123456789','mona','samir','alex','1998-10-19','i'
 exec  InsertUser  'amr','123456789','amr','nouh','alex','1998-10-19','s'
 exec  InsertUser  'salah','123456789','mohamed','saleh','alex','1998-10-19','s'


exec Insert_Department'SD', 5
exec Insert_Department 'OS', 6
exec Insert_Department 'CS', 7
exec Insert_Department 'Ui', 8


exec Update_Instructor 5, NULL, NULL, 100
exec Update_Instructor 6, NULL, NULL, 101
exec Update_Instructor 7, NULL, NULL, 102
exec Update_Instructor 8, NULL, NULL, 103
exec Update_Instructor 9, NULL, NULL, 100

exec Select_Department_All


exec InsertONCourse'OOP', 30
exec InsertONCourse 'DB', 30
exec InsertONCourse 'Intro to Programming', 30

exec SelectAllCourses


/* TOPICS */
exec Insert_Topic 204, 'Inheritance'
exec Insert_Topic 204, 'Polymorphism'
exec Insert_Topic 204, 'Abstraction'
exec Insert_Topic 204, 'Encapsulation'

exec Insert_Topic 205, 'Stored Procedures'
exec Insert_Topic 205, 'Triggers'
exec Insert_Topic 205, 'Cursors'
exec Insert_Topic 205, 'Joins'

exec Insert_Topic 206, 'Pointers'
exec Insert_Topic 206, 'Variables'
exec Insert_Topic 206, 'Arrays'
exec Insert_Topic 206, 'Functions'

exec Select_Topic_All


exec Insert_Student_Course 1, 204, NULL
exec Insert_Student_Course 1, 205, NULL
exec Insert_Student_Course 1, 206, NULL


BEGIN
	declare @C_ID int
	declare @Q_ID int
	/* OOP */
	select @C_ID = CID  from Course where Course.Cname = 'OOP'
	exec  insertQuestion 300, 'Which is not a feature of OOP in general definitions ?', 'mcq', 'D', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', 'Efficient Code'
		exec  InsertChoices   @Q_ID, 'B', 'Code reusability'
		exec  InsertChoices   @Q_ID, 'C', 'Modularity'
		exec  InsertChoices   @Q_ID, 'D', 'Duplicate-Redundant data'
	exec  insertQuestion  301, 'Who invented OOP ?', 'mcq', 'C', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', 'Andrea Ferro'
		exec  InsertChoices   @Q_ID, 'B', 'Adele Goldberg'
		exec  InsertChoices   @Q_ID, 'C', 'Alan Kay'
		exec  InsertChoices   @Q_ID, 'D', 'Dennis Ritchie'
	exec  insertQuestion  302,'Which was the first purely object oriented programming language developed?', '1', 'B', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', 'Kotlin'
		exec  InsertChoices   @Q_ID, 'B', 'SmartTalk'
		exec  InsertChoices   @Q_ID, 'C', 'Java'
		exec  InsertChoices   @Q_ID, 'D', 'C++'
	exec  insertQuestion 303, 'When OOP concept did first came into picture ?', '1', 'C', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', '1980’s'
		exec  InsertChoices   @Q_ID, 'B', '1995'
		exec  InsertChoices   @Q_ID, 'C', '1970’s'
		exec  InsertChoices   @Q_ID, 'D', '1993'
	exec  insertQuestion 304, 'Which feature of OOP indicates code reusability ?', '1', 'D', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', 'Abstraction'
		exec  InsertChoices   @Q_ID, 'B', 'Polymorphism'
		exec  InsertChoices   @Q_ID, 'C', 'Encapsulation'
		exec  InsertChoices   @Q_ID, 'D', 'Inheritance'
	exec  insertQuestion 305, 'Which header file is required in C++ to use OOP ?', '1', 'A', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', 'OOP can be used without using any header file'
		exec  InsertChoices   @Q_ID, 'B', 'stdlib.h'
		exec  InsertChoices   @Q_ID, 'C', 'iostream.h'
		exec  InsertChoices   @Q_ID, 'D', 'stdio.h'
	exec  insertQuestion  306, 'Why Java is Partially OOP language ?', '1', 'B', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', 'It allows code to be written outside classes'
		exec  InsertChoices   @Q_ID, 'B', 'It supports usual declaration of primitive data types'
		exec  InsertChoices   @Q_ID, 'C', 'It does not support pointers'
		exec  InsertChoices   @Q_ID, 'D', 'It doesn’t support all types of inheritance'
	exec  insertQuestion 307,  'Which among the following doesn’t come under OOP concept ?', '1', 'C', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', 'Data hiding'
		exec  InsertChoices   @Q_ID, 'B', 'Message passing'
		exec  InsertChoices   @Q_ID, 'C', 'Platform independent'
		exec  InsertChoices   @Q_ID, 'D', 'Data binding'
	exec  insertQuestion  308,'Trees are hierarchical data structures ?', '2', 'A', @C_ID
	exec  insertQuestion  309,'A tree node can have multiple parents ?', '2', 'B', @C_ID
	exec  insertQuestion  310,'A leaf node can have up to 2 children ?', '2', 'B', @C_ID
	exec  insertQuestion  311,'A binary tree node can have up to 2 children ?', '2', 'A', @C_ID
	exec  insertQuestion  312,'A binary tree is balanced if most interior nodes have 2 children ?', '2', 'A', @C_ID
	exec  insertQuestion  313,'A tree traversal visits every node in the tree ?', '2', 'A', @C_ID
	exec  insertQuestion  314,'The value of  a node is always greater than the values of its children ?', '2', 'B', @C_ID


	/* DB */
	select @C_ID = CID  from Course where Course.Cname = 'DB'
	exec  insertQuestion 315, 'Which of the following is generally used for performing tasks like creating the structure of the relations, deleting relation ?', '1', 'D', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', 'DML(Data Manipulation Language)'
		exec  InsertChoices   @Q_ID, 'B', 'Query'
		exec  InsertChoices   @Q_ID, 'C', 'Relational Schema'
		exec  InsertChoices   @Q_ID, 'D', 'DDL(Data Definition Language)'
	exec  InsertQuestion 316, 'Which of the following provides the ability to query information from the database and insert tuples into, delete tuples from, and modify tuples in the database ?', '1', 'A', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', 'DML(Data Manipulation Language)'
		exec  InsertChoices   @Q_ID, 'B', 'DDL(Data Definition Language)'
		exec  InsertChoices   @Q_ID, 'C', 'Query'
		exec  InsertChoices   @Q_ID, 'D', 'Relational Schema'
	exec  InsertQuestion 317, 'Which one of the following given statements possibly contains the error ?', '1', 'D', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', 'select * from emp where empid = 10003;'
		exec  InsertChoices   @Q_ID, 'B', 'select empid from emp where empid = 10006;'
		exec  InsertChoices   @Q_ID, 'C', 'select empid from emp;'
		exec  InsertChoices   @Q_ID, 'D', 'select empid where empid = 1009 and Lastname = GELLER;'
	exec  InsertQuestion 318, 'What do you mean by one to many relationships ?', '1', 'B', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', 'One class may have many teachers'
		exec  InsertChoices   @Q_ID, 'B', 'One teacher can have many classes'
		exec  InsertChoices   @Q_ID, 'C', 'Many classes may have many teachers'
		exec  InsertChoices   @Q_ID, 'D', 'Many teachers may have many classes'
	exec  InsertQuestion  319, 'A Database Management System is a type of _________software.', '1', 'A', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', 'It is a type of system software'
		exec  InsertChoices   @Q_ID, 'B', 'It is a kind of application software'
		exec  InsertChoices   @Q_ID, 'C', 'It is a kind of general software'
		exec  InsertChoices   @Q_ID, 'D', 'Both A and C'
	exec  InsertQuestion  320, 'The term "FAT" is stands for_____', '1', 'B', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', 'File Allocation Tree'
		exec  InsertChoices   @Q_ID, 'B', 'File Allocation Table'
		exec  InsertChoices   @Q_ID, 'C', 'File Allocation Graph'
		exec  InsertChoices   @Q_ID, 'D', 'All of the above'
	exec  InsertQuestion 321, 'The term "NTFS" refers to which one of the following ?', '1', 'A', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', 'New Technology File System'
		exec  InsertChoices   @Q_ID, 'B', 'New Tree File System'
		exec  InsertChoices   @Q_ID, 'C', 'New Table type File System'
		exec  InsertChoices   @Q_ID, 'D', 'Both A and C'
	exec  InsertQuestion  322, 'Which of the following can be considered as the maximum size that is supported by FAT ?', '1', 'B', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  InsertChoices   @Q_ID, 'A', '8GB'
		exec  InsertChoices   @Q_ID, 'B', '4GB'
		exec  InsertChoices   @Q_ID, 'C', '4TB'
		exec  InsertChoices   @Q_ID, 'D', 'None of the above'
	exec  InsertQuestion  323, 'The relational database model was created by E.F. Codd.', '2', 'A', @C_ID
	exec  InsertQuestion  324, 'A database is called "self-describing" because it contains a description of itself.', '2', 'A', @C_ID
	exec  InsertQuestion  325, 'In a database, data is stored in spreadsheets which have rows and columns.', '2', 'B', @C_ID
	exec  InsertQuestion  326, 'A database has data and relationships.', '2', 'A', @C_ID
	exec  InsertQuestion  327, 'One of the reasons why OODBMSs have not been widely used for business information systems is that OOP is obsolete.', '2', 'B', @C_ID
	exec  InsertQuestion  328, 'Applications are programs that interact directly with the database.', '2', 'B', @C_ID
	exec  InsertQuestion  329, 'The purpose of a database is to help people stop using spreadsheets.', '2', 'B', @C_ID

END