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

