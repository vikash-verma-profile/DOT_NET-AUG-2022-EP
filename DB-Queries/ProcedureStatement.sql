USE [DemoDB]
GO
/****** Object:  StoredProcedure [dbo].[GenerateStudentID]    Script Date: 9/5/2022 2:42:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[GenerateStudentID](@studentfirstName varchar(200),@studentlastName varchar(200),
@Gender varchar(200),@CourseName nvarchar(20),@age int) as
Begin 

DECLARE @CourseID int ,@LastInsertID int;
--here we are checking whether we have that course in DB or not
IF((select count(*) from course where CourseName=@CourseName)>0)
BEGIN
--fetching the course id so that we can pass the same course id into student table
set @CourseID=(select ID from Course where CourseName=@CourseName)
--insert all details in student table
Insert into student values(@studentfirstName,@studentlastName,@Gender,@CourseID,@age,'')
--fetch last insert id of that table so that we can update it with unique student ID
set @LastInsertID=(select IDENT_CURRENT('student'))
--updating the student id into student table with the last inserted ID that we get from last line
Update student set StudentId=CONCAT('IIIT',@CourseName,@LastInsertID) where Id=@LastInsertID;

--returning back the latest student id so that we can provide the same to the student
select StudentId from student where id=@LastInsertID;
END
END;