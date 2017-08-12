--We should point out one thing regarding lookup data: the scripts in the project will run every time they are
--applied to a target database. In other words, you need to be very aware of existing data and avoid INSERT statements
--that will cause primary-key violations. For this reason, any time you add or update lookup data, the SQL statements
--need to first check that the data doesn’t exist already. The ReferenceData.sql file demonstrates this:

IF not exists(select * from dbo.Status where Name = 'Not Started')
insert into dbo.Status(Name, Ordinal) values('Not Started', 0);
if not exists(select * from dbo.Status where Name = 'In Progress')
insert into dbo.Status(Name, Ordinal) values('In Progress', 1);
if not exists(select * from dbo.Status where Name = 'Completed')
insert into dbo.Status(Name, Ordinal) values('Completed', 2);