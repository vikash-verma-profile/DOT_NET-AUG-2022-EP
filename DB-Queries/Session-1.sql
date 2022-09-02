Create Database DemoDB
Use DemoDB
Create Table Sample(Id int,Name Varchar(200))
select * from Sample;
Insert into Sample(Id,Name) Values(2,'Vikash')
Insert into Sample(Id,Name) Values(1,'Vikash 1')
Insert into Sample(Id,Name) Values(4,'Vikash 3')
Update Sample SET Name='RAM'
Update Sample SET Name='Vikash' where id=2

select * from sample where ID=2
select * from Sample where Name='Vikash'

Create table Product (ID int,FinalAmount decimal(5,3),MRP decimal(5,2),Discount decimal(5,2),
productname varchar(200),ProductDescription varchar(2000))

select * from Product

insert into Product Values(1,90,100,10,'Lenovo 23.8 inch Full HD VA Panel 3-Side Near Edgeless with TUV','The Lenovo 60.45 cm (23.8) Full HD VA Panel (D24-20) monitor is equipped with AMD FreeSync technology which eliminates gaming roadblocks, such as motion blur and input lags, to facilitate an amazing gaming experience')
insert into Product Values(2,90,100,10,'Tri-Activ Polyester Adults Washable Mosquito Net Double Bed','Tri-Activ Polyester Adults Washable Mosquito Net Double Bed, King-Size Premium Machardani Piramal, Strong & Durable Mosquito Net  (Blue, Bed Box)')

select * from Product where productname LIKE '%Lenovo'
select * from Product where productname LIKE 'Lenovo%'
select * from Product where productname LIKE '%Lenovo%'

insert into Product Values(3,90,100,10,'Tri-Activ Polyester Adults Washable Mosquito Net Double Bed Lenovo','Tri-Activ Polyester Adults Washable Mosquito Net Double Bed, King-Size Premium Machardani Piramal, Strong & Durable Mosquito Net  (Blue, Bed Box)')
insert into Product Values(4,900.00,100,10,'Tri-Activ Polyester Adults Washable Mosquito Net Double Bed Lenovo','Tri-Activ Polyester Adults Washable Mosquito Net Double Bed, King-Size Premium Machardani Piramal, Strong & Durable Mosquito Net  (Blue, Bed Box)')
insert into Product Values(5,9000,100,10,'Tri-Activ Polyester Adults Washable Mosquito Net Double Bed Lenovo','Tri-Activ Polyester Adults Washable Mosquito Net Double Bed, King-Size Premium Machardani Piramal, Strong & Durable Mosquito Net  (Blue, Bed Box)')

Create table DemoP (ID int identity(2,2),SumValue Decimal(5,3))
insert into DemoP Values(19.001)

alter Table DemoP ADD STATUS int
select * from DemoP

alter table DemoP DROP Column STATUS

alter table Demop ALTER Column SumValue Decimal(6,3)
--adsaLenovo

Drop Table DemoP

select * from Sample

truncate Table  DemoP 
delete from DemoP where id=1

select * from sample order by id desc

alter Table sample ADD Salary int
update  sample set Salary=4000 where id=4

select count(*) as RecordCount from Sample
select Name as FULLNAME,SALARY AS EMPLOYEESALARY from sample

select MAx(SALARY) from Sample
select Name from Sample --where Salary=Max(Salary)
--sub queries

select Name from Sample where Salary =(select MAx(SALARY) from Sample )

select  Name from Sample group by Name having count(Name)>1

select  SALARY from Sample group by SALARY having SALARY=MAX(SALARY)\

select * from Sample where ID not in (1,2,3)


create table Employee(ID int identity(1,1),Name varchar(200),Salary int,DepId int)

create table Department(ID int identity(1,1),DepartmentName varchar(200))

select * from Employee
select * from Department

insert	into Employee values('Rohit',10000,1)
insert	into Employee values('Rohit 2',10000,2)
insert	into Employee values('Rohit 3',10000,1)
insert	into Employee values('Rohit 5',10000,5)

insert into Department values('Sales')
insert into Department values('IT')
insert into Department values('Admin')

select emp.Name,D.DepartmentName from 
EMployee emp inner join Department D on emp.DepId=D.ID

select emp.Name,D.DepartmentName from 
EMployee emp RIGHT OUTER join Department D on emp.DepId=D.ID

select emp.Name,D.DepartmentName from 
EMployee emp LEFT OUTER join Department D on emp.DepId=D.ID

select emp.Name,D.DepartmentName from 
EMployee emp FULL OUTER join Department D on emp.DepId=D.ID

select * from Employee
select * from Department
