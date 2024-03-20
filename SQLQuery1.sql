use trainingdb

select * from empdummy
select * from empdummy1

select * from tblemployee where deptid not in(1,4,2)

select empname,salary from tblemployee
where not exists(select deptid from tblemployee where deptid=3)

select empno,ename,deptno from emp eouter
where not exists(select 'x' from emp where mgr_id=eouter.empno)

select empno,ename,deptno from emp eouter
where exists(select 'x' from emp where mgr_id=eouter.empno)

--the above with in operator
select empno,ename,deptno from emp 
where empno in(select mgr_id from emp where mgr_id is not null)

--find all departments that do not have any employees

select deptid,deptname from tblDepartment d
where not exists(select 'x' from tblEmployee where DeptId=d.DeptId)

--views
create view vWEmpbyDept
as
select Empname,Salary,Gender,Deptname from
tblEmployee join tblDepartment on
tblEmployee.DeptId=tblDepartment.DeptId

sp_helptext vwempbydept

select * from vWEmpbyDept  -- selection using the virtual table 
drop view vwempbydept

--create a view to find all employee name,salary, gender and deptnames of IT dept.
create view vWITEmp
as select empname,salary,gender,deptname from tblemployee join tblDepartment
on tblEmployee.deptid=tblDepartment.DeptId where tblDepartment.DeptName='IT'

drop view vWITEmp
--let us change the view definition to include the pk of both tables
create view vWITEmp
as select empid,empname,gender,salary,e1.deptid,e1.deptname from tblemployee e join tblDepartment e1
on e.deptid=e1.DeptId where e1.DeptName='IT'

--dml thru views
select * from tblDepartment
select * from tblEmployee

select * from vWITEmp
insert into vWITEmp values(200,'Banurekha','Female',7500,7,'Quality')

delete from vWITEmp where empid=106 -- not successful
update vWITEmp set salary=7000 where empid=106  -- successful

update vWITEmp set deptname='IT' where empid=107 -- unexpected updation

--eg 2 view from a single table
drop view vw1
create view vw1 as select empid,empname,salary,deptid from tblEmployee

select * from vw1

--
insert into vw1 values(200,'Banurekha',7600,1) -- insertion fails since the other columns 
                                    --   of the table are boubd by constraints

delete from vw1 where empid=111  -- succeeds

update vw1 set Salary=7000 where empid=107  -- also succeeds

--indexes
drop table testtable
create table testtable(tid int, tname varchar(20),tcity varchar(20))

insert into testtable values(5,'F','Vizag'),(1,'B','Pune'),(1,'C','Delhi'),
(2,'D','Bangalore'),(3,'E','Hyderabad')

update testtable set tid=6 where tname='E'

select * from testtable

create clustered index idxtid on testtable(tid)
sp_help tblemployee

--now let us check with unique clustered index on a table without pk
create unique clustered index idxtid on testtable(tid)

insert into testtable values(5,'F','Vizag'),(4,'B','Pune'),(1,'C','Delhi'),
(2,'D','Bangalore'),(3,'E','Hyderabad')

--drop index 
drop index testtable.idxtid

--non clustered

insert into tblemployee values('111','Arjun','Male',6900,1,879878,'Ahmedabad')

select * from tblEmployee

create nonclustered index idxename on tblemployee(empname)
create nonclustered index idxsal on tblemployee(salary)

--filtered index 
drop index tblemployee.idxfil
create index idxfil on tblemployee(city) where city is not null

select * from tblemployee where city is not null and empname like 'A%'

--various datatypes
drop table sample
create table Sample
(sampleid varchar(10),
samplename text,
samplenotes ntext,
sampledoj date,
sampleamount money)

insert sample values('s200','xdfchgvjhbkjiuyuihghhjkjff','76tyguhbcen9njhlkjhjlgkhfk','11/11/2023',55000)

select * from Sample

--computed or calculated columns in a table
--columns that receive value based on other columns 
create table testEmp(eid int, ename varchar(20),salary float, AnnualSalary as (Salary*12))

insert into testEmp values(1,'AA',5000)

select * from testEmp

--startdate , projected end date (90 days from start date), Actual enddate(Projected +7)

select datename(DAYOFYEAR,getdate())
select DATEDIFF(mm,'01/01/2002',getdate())

select dateadd(dd,27,getdate())
select getdate()

select convert(varchar(24),getdate())

select cast(day(getdate()) as varchar(2)) + ' '+ datename(mm,getdate()) + ' '
+ cast(Year(getdate())as varchar(4))as [Date Month Year]
