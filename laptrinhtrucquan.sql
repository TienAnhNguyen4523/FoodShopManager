create  database laptrinhtrucquan
go 
use laptrinhtrucquan
go
create table TableFood
(
	id int identity primary key,
	name nvarchar(50) not null default N'chua dat ten',
	status nvarchar(50) not null default N'trong', --trong--co nguoi
)
go
create table Accoumt
(
	UserName nvarchar(50) primary key ,
	DisplayName nvarchar(50) not null default N'Duong',
	PassWord nvarchar(50) not null default 0,
	Type int not null default 0 ,--1:admin--0:staff
)
go
create table FoodCategory
(
	id int identity primary key,
	name nvarchar(50) not null default N'chua dat ten'
)
go
create table Food
(
	id int identity primary key,
	name nvarchar(50) not null default N'chua dat ten',
	idCategory int not null,
	price float not null,
	foreign key (idCategory) references dbo.FoodCategory(id)
)
 go
create table Bill
(
	id int identity primary key,
	DateCheckIn date not null default getdate(),
	DateCheckOut date ,
	idTable int not null,
	status int not null default 0 --1:da thanh toan--0: chua thanh toan,
	foreign key (idTable) references dbo.TableFood(id)

)
go
create table BillInfo
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0,
	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)


)
select * from TableFood
select * from Bill
select * from BillInfo
select * from FoodCategory
select * from Food
select Food.name, count , price, SUM(Food.price*BillInfo.count) as thanhtien from Food inner join BillInfo on Food.id = BillInfo.idFood
			inner join Bill on BillInfo.idBill=Bill.id
			inner join TableFood on Bill.idTable =TableFood.id
where TableFood.id =3
group by Food.name
select * from FoodCategory
select * from Food where idCategory =3

insert Bill(DateCheckIn,DateCheckOut,idTable,status) values (GETDATE(),null,3,0)
insert BillInfo(idBill,idFood,count) values(1,1,1) 

select Food.name,sum(BillInfo.count)as Soluong,Food.price, Food.price*BillInfo.count as thanhtien from Food,Bill,BillInfo where BillInfo.idBill=Bill.id and BillInfo.idFood=Food.id and Bill.idTable = 1 group by Food.name,Food.price,BillInfo.count

select max(id) from bill

CREATE PROC InsertBill
@TableID INT
AS
	INSERT Bill (DateCheckIn, DateCheckOut, idTable, status) VALUES (GETDATE(),null,@TableID,0)
exec InsertBill @TableID = 1
create proc InsertBillInfo
@idbill int, @idfood int, @count int
as
	insert BillInfo(idBill,idFood,count) values(@idbill,@idfood,@count)
exec InsertBillInfo @idbill = (select MAX(id) from Bill) ,@idfood =3, @count = 2

insert BillInfo(idBill,idFood,count) values((select MAX(id) from Bill),@idfood,@count)
alter table Bill
add TongTien int default 0

select Bill.id, DateCheckIn,DateCheckOut,TongTien,discount
from Bill , BillInfo
where DateCheckIn='2021-11-12'and DateCheckOut='2023-11-12' and Bill.status=1 and Bill.id =BillInfo.idBill
