select * from sample
select Name from sample

select  distinct id from sample
select   id from sample

insert into sample values(1,'Vikash 4',5000)

create table dummy(id int,Text varchar(200));

select * from dummy

insert into dummy values(1,'Vikash')
insert into dummy values(2,null)
truncate table dummy

alter table dummy alter column Text varchar(200) NOT NULL
insert into dummy values(1,'asdasd')
alter table dummy alter column id int NOT NULL
alter table dummy alter column id int ;

create table dummy1 (id int not null unique)

create table sample2(id int ,Primary KEY(id))

create table tbldummy(id int,Text varchar(200) DEFAULT 'vikash')

select * from tbldummy
insert into tbldummy values(1,'vikash 1267')
insert into tbldummy(id) values(2)

alter table tbldummy drop column id;
alter table tbldummy drop column Text;

create table tblStudent(id int ,Name varchar(20),Primary KEY(id),UNIQUE(Name))

insert into tblStudent Values(1,'Vikash')
insert into tblStudent Values(2,null)

Create table Customer(id int identity(1,1),Name varchar(200),Age int,Primary Key(id));
Create table tblOrder(id int identity(1,1),OrderNumber varchar(200),CutomerID int,Primary Key(id),Foreign Key(CutomerID) REFERENCES Customer(ID));

select CONCAT(FirstName,'  ',LastName) as FULLNAME from Customer
select * from tblOrder
Delete from Customer where id=1

Create table student(id int identity(1,1),firstname varchar(200),
lastname varchar(200),
gender varchar(200),
CourseId int,
age int,Primary KEY(id),Foreign Key(CourseId) REFERENCES Course(id))

Create table Course(id int identity(1,1) ,CourseName varchar(200),Primary KEY(id))

select * from student
select * from course
insert into Course values('CSE'),('ME'),('IT'),('Civil')
insert into student values('Vikash','Verma','Male',1,43),('Suresh','Kumar','Male',2,43),
('Anjali','Kumari','Female',3,25)

select CONCAT('XYZ00',s.id) as StudentId,dbo.GetName(s.id) as StudentName,C.CourseName from student s join Course C on S.CourseId=C.id


Create function GetName(@id int)
returns varchar(200) As
Begin
return (select CONCAT(firstname,' ',lastname) as StudentName from student where id=@id);
END

select dbo.GetName(id) as FullName from student

select dbo.GetName(2)

select * from student
select CASE WHEN age%2=0 THEN 'EVEN' ELSE 'ODD' END as ODDEVEN from student

Create function CheckOddEven(@id int)
returns varchar(200) As
Begin
return (select CASE WHEN age%2=0 THEN 'EVEN' ELSE 'ODD' END as ODDEVEN from student where id=@id);
END


select dbo.CheckOddEven(id) from student

select REVERSE('Vikash')

select dbo.CheckPalindrome('DAD')
select dbo.CheckPalindrome(dbo.GetName(id)) from student

Create function CheckPalindrome(@Name varchar(200) )
returns varchar(200) As
Begin
DECLARE @Text varchar(200);
IF REVERSE(@Name)=@Name 
BEGIN
set @Text='Palindrome';
END
ELSE
BEGIN
set @Text='Not a Palindrome';
END

return @Text;
END

Declare @s int;
set @s=1;
Select * from student where id=@s;

--Store procedures

Create table CourseSubject (ID int identity(1,1),SubjectName varchar(200),CourseID int,
primary Key(iD),Foreign Key(CourseID) REFERENCES Course(ID))

select  * from student
select * from course
Insert into student values('Raj','Kumar','Male',1,27)
alter table student add  StudentId varchar(10)

create procedure GenerateStudentID(@studentfirstName varchar(200),@studentlastName varchar(200),
@Gender varchar(200),@CourseName nvarchar(20),@age int) as
Begin 

DECLARE @CourseID int;
IF((select count(*) from course where CourseName=@CourseName)>0)
BEGIN
set @CourseID=(select ID from Course where CourseName=@CourseName)
Insert into student values(@studentfirstName,@studentlastName,@Gender,@CourseID,@age,'')

END
END;

