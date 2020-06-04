/*
drop database cinemaTicket
*/

create database cinemaTicket
go

use cinemaTicket
go

create table category(
	id int not null identity primary key,
	catName nvarchar(250) not null unique
)
go

create table showtime(
	id int not null identity primary key,
	timeName nvarchar(250) not null unique,
	timeBegin int not null unique,
	timeEnd int not null unique
)
go

create table showroom(
	id int not null identity primary key,
	roomName nvarchar(250) not null unique,
	status bit not null default 1
)
go

create table seat(
	id int not null identity primary key,
	seatName char(5) not null unique,
	price float not null default 0,
	type bit not null default 0
)
go

create table film(
	id int not null identity primary key,
	filmName nvarchar(250) not null unique,
	image varchar(250) not null unique,
	time int not null default 100,
	director nvarchar(250) not null,
	casts nvarchar(250) not null,
	ariDate date not null default getDate(),
	numDateShow int not null default 50,
	content nvarchar(4000) not null,
	catId int not null references category(id)
)
go

create table account(
	id int not null identity primary key,
	name nvarchar(250) not null,
	dob date not null default getdate(),
	phone varchar(10) not null unique,
	email varchar(250) not null unique,
	address nvarchar(250) not null,
	userName varchar(250) not null unique,
	password varchar(250) not null,
	role bit default 0
)
go

create table calendershow(
	id int not null identity primary key,
	film int not null references film(id),
	showRoom int not null references showroom(id),
	showTime int not null references showtime(id),
	showDate date not null default getdate(),
	extraPrice float not null default 5,
	unique(showRoom,showTime,showDate)
)
go

create table ticket(
	id int not null identity primary key,
	createdBy int not null references account(id),
	buyer nvarchar(250) not null default N'Customer',
	createdDate date not null default getdate(),
	sale float not null default 0,
	seat int not null references seat(id),
	calenderShow int not null references calendershow(id),
	totalPrice float not null
)
go

/* Procedure set totalPrice cho ticket */
create proc insertTicket @createdBy int, @buyer nvarchar(250), @createdDate date, @sale float, @seat int, @calender int
as
begin
	SET NOCOUNT ON
	insert into ticket(createdBy,buyer,createdDate,sale,seat,calenderShow,totalPrice) values (@createdBy, @buyer, @createdDate, @sale, @seat, @calender, (((select extraPrice from calendershow where id = @calender) + (select price from seat where id = @seat)) * (1 - (@sale/100))))
	return SCOPE_IDENTITY()
end
go

/* View Xem lịch chiếu phim */
create view showCalender as 
select cs.id, f.filmName as film, st.timeName as timeName, st.timeBegin as timeBegin, sr.roomName as room, cs.showDate as showDate, cs.extraPrice from calendershow cs 
	join film f on f.id = cs.film 
	join showtime st on st.id = cs.showTime
	join showroom sr on sr.id = cs.showRoom
go

/* View Thông Tin Vé */
create view showTicket as
select t.id, t.buyer, t.createdDate, t.totalPrice, sc.showDate, sc.timeName, sc.timeBegin, sc.film, sc.room, s.seatName, a.name as createdName, t.createdBy  
from ticket t join showCalender sc on t.calenderShow = sc.id join seat s on t.seat = s.id join account a on a.id = t.createdBy
go
