--create database EmployeeDB
drop table Employee
create table Employee(
EmployeeID int identity(1,1) primary key,
FullName nvarchar(max),
EMPCode nvarchar(max),
Mobile nvarchar(max),
Position nvarchar(max)
)

insert into Employee (FullName,EMPCode,Mobile,Position) values ('ishan dudeja','emp 1','9899988995','Manager')