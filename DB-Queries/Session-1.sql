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

select  SALARY from Sample group by SALARY having SALARY=MAX(SALARY)



