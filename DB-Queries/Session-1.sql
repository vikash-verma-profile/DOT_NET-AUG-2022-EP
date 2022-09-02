Create Database DemoDB
Use DemoDB
Create Table Sample(Id int,Name Varchar(200))
select * from Sample;
Insert into Sample(Id,Name) Values(2,'Vikash')
Update Sample SET Name='RAM'
Update Sample SET Name='Vikash' where id=2

select * from sample where ID=2
select * from Sample where Name='Vikash'

Create table Product (ID int,FinalAmount decimal(5,2),MRP decimal(5,2),Discount decimal(5,2),
productname varchar(200),ProductDescription varchar(2000))

select * from Product

insert into Product Values(1,90,100,10,'Lenovo 23.8 inch Full HD VA Panel 3-Side Near Edgeless with TUV','The Lenovo 60.45 cm (23.8) Full HD VA Panel (D24-20) monitor is equipped with AMD FreeSync technology which eliminates gaming roadblocks, such as motion blur and input lags, to facilitate an amazing gaming experience')
insert into Product Values(2,90,100,10,'Tri-Activ Polyester Adults Washable Mosquito Net Double Bed','Tri-Activ Polyester Adults Washable Mosquito Net Double Bed, King-Size Premium Machardani Piramal, Strong & Durable Mosquito Net  (Blue, Bed Box)')

select * from Product where productname LIKE '%Lenovo'
select * from Product where productname LIKE 'Lenovo%'
select * from Product where productname LIKE '%Lenovo%'

insert into Product Values(3,90,100,10,'Tri-Activ Polyester Adults Washable Mosquito Net Double Bed Lenovo','Tri-Activ Polyester Adults Washable Mosquito Net Double Bed, King-Size Premium Machardani Piramal, Strong & Durable Mosquito Net  (Blue, Bed Box)')

--adsaLenovo