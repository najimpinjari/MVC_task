create database Employeedb

create table emp(
id int ,
gender varchar(59),
age int ,
designation varchar(50)
)

insert into emp values (1,'male',24,'manager'),
(2,'male',23,'director'),(3,'female',22,'Rm'),(4,'male',27,'Srmanager');

select * from emp