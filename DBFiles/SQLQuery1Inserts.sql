
select * from Employee

truncate table Employee

--drop table Employee
insert into Employee values ('Ray','Diaz','rvdiaz',1,'5/1/2019',1,'777 S. Main Street','','Sacramento','CA','98053','111-111-1111','111-222-1111','rd@yahoo.com','80000',1)

insert into Employee values ('Marchi','Diaz','mcdiaz',1,'5/1/2019',2,'777 S. Main Street','','Sacramento','CA','98053','111-111-1111','111-222-1111','md@yahoo.com','40000',2)

insert into Employee values ('Lourdesmarnette','Diaz','lcdiaz',1,'5/1/2019',3,'777 S. Main Street','','Sacramento','CA','98053','111-111-1111','111-222-1111','ld@yahoo.com','20000',3)

insert into Employee values ('Happy','Ryan','hrblip',1,'5/1/2019',4,'777 S. Main Street','','Sacramento','CA','98053','111-111-1111','111-222-1111','hr@blippi.com','20000',4)

insert into Employee values ('Happy','Martin','hmblip',1,'5/1/2019',5,'777 S. Main Street','','Sacramento','CA','98053','111-111-1111','111-222-1111','hm@blippi.com','20000',5)

insert into Employee values ('Happy','Garden','hgblip',1,'5/1/2019',6,'777 S. Main Street','','Sacramento','CA','98053','111-111-1111','111-222-1111','hg@blippi.com','20000',6)

insert into Employee values ('Happy','Optimus','hoblip',1,'5/1/2019',7,'777 S. Main Street','','Sacramento','CA','98053','111-111-1111','111-222-1111','ho@blippi.com','20000',7)

insert into Employee values ('Happy','Prime','hpblip',1,'5/1/2019',8,'777 S. Main Street','','Sacramento','CA','98053','111-111-1111','111-222-1111','hp@blippi.com','20000',8)


insert into Department values ('Dev')
insert into Department values ('HR')
insert into Department values ('Gaming')
insert into Department values ('Finance')
insert into Department values ('Executive')
insert into Department values ('Ministry')
insert into Department values ('Music')
insert into Department values ('Graphics')
insert into Department values ('Housekeeping')


insert into Music values ('Faith Like A Child','Greatest Hits', 'Jars of Clay')
insert into Music values ('Come Now is the Time to Worship','Come Now is the Time', 'Hillsong')
insert into Music values ('The Power of Your Love','The Power of Your Love', 'Hillsong')
insert into Music values ('Holy Holy Holy','Our Hymns', 'Michael W. Smith')
insert into Music values ('Listen to Our Hearts','A Friend Like U', 'Casting Crowns')
insert into Music values ('Christ In Me','I Will Follow', 'Jeremy Camp')
insert into Music values ('Amazing Grace','Hymns', 'Vineyard')
insert into Music values ('The Flood','Greatest Hits', 'Jars of Clay')
insert into Music values ('I Want to Fall In Love With You','Greatest Hits', 'Jars of Clay')


select * from Employee
select * from Department

select concat(a.firstName, a.lastName) As Name, b.departmentName As Department from Employee a inner join Department b on a.employeeID = b.departmentID

select concat(a.firstName, a.lastName) As Name, b.songTitle As Song, b.songArtist As Artist, b.songAlbum As Album from Employee a inner join Music b on a.employeeID = b.songID