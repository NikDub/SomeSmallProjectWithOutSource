IF EXISTS (SELECT * FROM sys.databases WHERE NAME = 'subdcursa4')
DROP DATABASE subdcursa4

CREATE DATABASE subdcursa4

USE subdcursa4
GO

CREATE TABLE roles
(
	[ID] INT IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(20),
)

CREATE TABLE country
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(20),
)

CREATE TABLE users
(
	ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Login NVARCHAR(20),
	Password NVARCHAR(Max),
	Surname NVARCHAR(20),
	[Name] NVARCHAR(20),
	Patronymic NVARCHAR(20),
	ID_Role Int,

	FOREIGN KEY (ID_Role) REFERENCES roles (Id) ON DELETE CASCADE
)

CREATE TABLE groups
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	ID_User INT,
	[Name] NVARCHAR(20),
	[Year] int,
	ID_Country INT,
	Place INT,

	FOREIGN KEY (ID_Country) REFERENCES country (Id) ON DELETE CASCADE,
	FOREIGN KEY (ID_User) REFERENCES users (Id) ON DELETE CASCADE
)

CREATE TABLE songs
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(20),
	[Year] int
)


CREATE TABLE executor
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Surname NVARCHAR(20),
	[Name] NVARCHAR(20),
	Patronymic NVARCHAR(20),
	Birth_date DATE,
)

CREATE TABLE authors
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	ID_Song INT,
	ID_Executor INT,
	role_stat NVARCHAR(20),

	FOREIGN KEY (ID_Song) REFERENCES songs (Id) ON DELETE CASCADE,
	FOREIGN KEY (ID_Executor) REFERENCES executor (Id) ON DELETE CASCADE
)

CREATE TABLE group_executor
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	ID_Executor INT,
	ID_Group INT,
	Date_arr DATE,
	Date_depart DATE,
	Role_stat NVARCHAR(20),
	
	FOREIGN KEY (ID_Executor) REFERENCES executor (Id) ON DELETE CASCADE,
	FOREIGN KEY (ID_Group) REFERENCES groups (Id) ON DELETE CASCADE
)

CREATE TABLE repertoires
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	ID_Song INT,
	ID_Group INT,
	date_beg DATE,

	FOREIGN KEY (ID_Song) REFERENCES songs (Id) ON DELETE CASCADE,
	FOREIGN KEY (ID_Group) REFERENCES groups (Id) ON DELETE CASCADE
)

CREATE TABLE tours
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	ID_Group INT,
	Date_beg DATE,

	FOREIGN KEY (ID_Group) REFERENCES groups (Id) ON DELETE CASCADE
)

CREATE TABLE places
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Name_loc NVARCHAR(20),
	Name_place NVARCHAR(20),
	Price_tick INT,
	Capacity INT,
	ID_Country INT,

	FOREIGN KEY (ID_Country) REFERENCES country (Id) ON DELETE CASCADE
)

CREATE TABLE buy_tick
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	ID_Tour INT,
	ID_Place INT,
	Date_beg DATE,
	Date_ov DATE,
	SummPR_tick INT,
	Price_tick INT,
	Count_tick INT,

	FOREIGN KEY (ID_Tour) REFERENCES tours (Id) ON DELETE CASCADE,
	FOREIGN KEY (ID_Place) REFERENCES places (Id)
)

CREATE TABLE tour_songs
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	ID_Tour INT,
	ID_Song INT,

	
	FOREIGN KEY (ID_Tour) REFERENCES tours (Id) ON DELETE CASCADE,
	FOREIGN KEY (ID_Song) REFERENCES songs (Id) ON DELETE CASCADE,
)


INSERT INTO roles
VALUES 
('user1'),
('user2'),
('user3'),
('admin');

INSERT INTO country
VALUES 
('Kanada'),
('USA'),
('Germany');

INSERT INTO executor 
VALUES 
('Surname', 'name', 'patronym', '15.11.1974'),
('Surname1', 'name1', 'patronym1', '11.02.1977'),
('Surname2', 'name2', 'patronym2', '31.08.1948');

INSERT INTO users
VALUES 
('user1', 'user1', 'user1', 'user1', 'user1', 1),
('user2', 'user2','user2', 'user2', 'user2', 2),
('user3', 'user3','user3', 'user3', 'user3', 3),
('admin', 'admin','admin', 'admin', 'admin', 3);

INSERT INTO groups
VALUES 
(1, 'Nickelback', 1995, 1, 1),
(2, 'Linkin Park', 1996, 2, 2),
(3, 'Scorpions', 1965, 3, 3);

INSERT INTO group_executor
VALUES 
(1, 1, '1995', '2021', 'Role_stat1'),
(2, 2, '1996', '2002', 'Role_stat2'),
(3, 3, '1965', '2022', 'Role_stat3');

INSERT INTO songs 
VALUES
('Rockstar', 1999),
('Numb', 2004),
('Still loving you', 2012);

INSERT INTO authors VALUES
(1,1, 'authors1'),
(2,2, 'authors1'),
(3,3, 'authors1');

INSERT INTO repertoires
VALUES
(1, 1, '15.02.1995'),
(2, 2, '17.08.1996'),
(3, 3, '13.03.1965');

INSERT INTO tours
VALUES
(1, '08.09.2000'),
(2, '05.07.2001'),
(3, '09.12.1980');

INSERT INTO places     
VALUES 
('Name_loc1', 'Jerry Presleys God', '2000', '150', 1),
('Name_loc2', 'Purgatory Stage', '1500', '100', 2),
('Name_loc3', 'SAP Arena', '1000', '200', 3);

INSERT INTO buy_tick
VALUES 
(1, 1, '15.08.2020', '15.10.2020', '300000', '150', '2000'),
(2, 2, '17.01.2019', '17.03.2019', '15000', '100', '1500'),
(3, 3, '28.12.1999', '28.03.2000', '200000', '200', '1000');


--- 1

select c.Name, c.Patronymic, c.Surname, a.Year 
from songs as a, authors as b, executor as c 
where a.ID = b.ID_Song and b.ID_Executor = c.ID and a.name = 'Rockstar'

--- 1.1

select c.Name 
from songs as a, repertoires as b, groups as c 
where a.ID=b.ID_Song and b.ID_Group=c.ID and a.name = 'Rockstar'

--- 2

select c.Name
from groups as a, repertoires as b, songs as c 
where a.ID=(select top 1 id from groups order by groups.Place) and a.ID=b.ID_Group and b.ID_Song = c.ID

--- 3

select c.Price_tick 
from groups as a, tours as b, buy_tick as c 
where a.ID = b.ID_Group and c.ID_Tour = b.ID and a.Name = 'Nickelback'

--- 4

select c.Name, c.Patronymic, c.Surname, c.Birth_date 
from groups as a, group_executor as b, executor as c 
where a.ID = b.ID_Group and b.ID_Executor = c.ID and a.Name = 'Nickelback'

--- 5 

select d.Name_loc, d.Name_place, c.Date_beg, c.Date_ov 
from groups as a, tours as b, buy_tick as c, places as d 
where a.ID=b.ID_Group and b.ID = c.ID_Tour and c.ID_Place = d.ID and a.Name = 'Nickelback'

--- 6

select Name from groups as a where (YEAR(getdate()) - a.Year)%10 = 0

--- 7 

select a.Name, a.Surname, a.Patronymic, c.Name 
from executor as a, group_executor as b, groups as c 
where a.ID=b.ID_Executor and b.ID_Group = c.ID 
order by a.Birth_date desc

--- 8

select c.Name
from executor as a, group_executor as b, groups as c 
where a.ID=b.ID_Executor and b.ID_Group = c.ID
group by c.Name 
having AVG(DATEDIFF(MONTH, a.Birth_date, GETDATE())/12) < 20



-----------------------------------------------------------------------------
-----------------------------Procedure---------------------------------------
-----------------------------------------------------------------------------

--- 1

go
create procedure GetAuthor
@name NVARCHAR(20)
as
	select c.Name, c.Patronymic, c.Surname, a.Year 
	from songs as a, authors as b, executor as c 
	where a.ID = b.ID_Song and b.ID_Executor = c.ID  and a.name = @name
---
exec GetAuthor 'Rockstar'

drop procedure GetAuthor

--- 2

go
create procedure GetRepertuar
as
select c.Name, c.Name 
from groups as a, repertoires as b, songs as c 
where a.ID=(select top 1 id from groups order by groups.Place) and a.ID=b.ID_Group and b.ID_Song = c.ID
---
exec GetRepertuar

drop procedure GetRepertuar


--- 3

go
create procedure CostTicketAtLastTour
@name NVARCHAR(20)
as
select c.Price_tick 
from groups as a, tours as b, buy_tick as c 
where a.ID = b.ID_Group and c.ID_Tour = b.ID and a.Name  = @name
---
exec CostTicketAtLastTour 'Nickelback'

drop procedure CostTicketAtLastTour

--- 4

go
create procedure ListExecutorsByGroup
@name NVARCHAR(20)
as
select c.Name, c.Patronymic, c.Surname, c.Birth_date 
from groups as a, group_executor as b, executor as c 
where a.ID = b.ID_Group and b.ID_Executor = c.ID and a.Name = @name
---
exec ListExecutorsByGroup 'Nickelback'

drop procedure ListExecutorsByGroup

--- 5 

go
create procedure PlaceAndDateLastTour
@name NVARCHAR(20)
as
select d.Name_loc, d.Name_place, c.Date_beg, c.Date_ov 
from groups as a, tours as b, buy_tick as c, places as d 
where a.ID=b.ID_Group and b.ID = c.ID_Tour and c.ID_Place = d.ID and a.Name = @name
---
exec PlaceAndDateLastTour 'Nickelback'

drop procedure PlaceAndDateLastTour

--- 6

go
create procedure UbileiGroupsAtThisYear
as
	select Name from groups as a where (YEAR(getdate()) - a.Year)%10 = 0
---
exec UbileiGroupsAtThisYear

drop procedure UbileiGroupsAtThisYear

--- 7 

go
create procedure YangerSonger
as
select top 1 a.Name, a.Surname, a.Patronymic, c.Name
from executor as a, group_executor as b, groups as c 
where a.ID=b.ID_Executor and b.ID_Group = c.ID 
order by a.Birth_date desc
---
exec YangerSonger 

drop procedure YangerSonger

--- 8

go
create procedure AverageNotOldersThen20
as
select c.Name, AVG(DATEDIFF(MONTH, a.Birth_date, GETDATE())/12) AS "Age"
from executor as a, group_executor as b, groups as c 
where a.ID=b.ID_Executor and b.ID_Group = c.ID
group by c.Name 
having AVG(DATEDIFF(MONTH, a.Birth_date, GETDATE())/12) < 20
---
exec AverageNotOldersThen20 

drop procedure AverageNotOldersThen20

-----------------------------------------------------------------------------
-------------------------------Trigger---------------------------------------
-----------------------------------------------------------------------------

--- 1 to insert in repertoires song which exists in another ore this group

GO 
Create trigger ShowInsrt 
ON repertoires 
instead of insert 
AS 
 Begin 
  declare @isit bit 
  select @isit = CAST(CASE WHEN COUNT(*) > 0 THEN 1 ELSE 0 END AS BIT) from repertoires where repertoires.ID_Song = (select inserted.ID_Song from inserted) 
 
  if @isit = 1 
  begin 
   rollback transaction 
  end 
  else 
  begin 
   insert into repertoires values ((select ID_Song from inserted), (select ID_Song from inserted), (select date_beg from inserted)) 
  end 
 end 
    
--- 2 to update in repertoires song which exists in another ore this group

GO 
Create trigger ShowUpdate 
ON repertoires 
instead of update 
AS 
 Begin 
  declare @isit bit 
  select @isit = CAST(CASE WHEN COUNT(*) > 0 THEN 1 ELSE 0 END AS BIT) from repertoires where repertoires.ID_Song = (select inserted.ID_Song from inserted) and repertoires.ID = (select inserted.ID from inserted)
 
  if @isit = 1 
  begin 
   rollback transaction 
  end 
  else 
  begin 
   update repertoires set ID_Song =(select ID_Song from inserted), ID_Group = (select ID_Group from inserted), date_beg = (select date_beg from inserted) where ID = (select ID from inserted) 
  end 
 end
