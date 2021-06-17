create database gamoet1;
use gamoet1;
-- _____________________________

create table  administration(
userName varchar(30),
passwordz varchar(30) not null,
fullName nvarchar(40) not null,
gmail varchar(40) ,
pathImage nvarchar(100) default "unknow",
timeLine  nvarchar(30) not null,
constraint key1 primary key(userName)
);
--


create table userz(
id int ,
userAdmin varchar(30),
userName varchar(30) ,
passwordz varchar(30) ,
timeLine nvarchar(30),
repaiTime nvarchar(30),
constraint key2 primary key(userName), -- Khóa chính
constraint key_n1 foreign key (id,userAdmin) references administration (id,userName) -- tạo khóa phụ
);


create table saltyfood(
id int primary key auto_increment ,
namez nvarchar(30) ,
price int not null,
pathImage varchar(100),
information nvarchar(2000) ,
sale int default 0,
timeLine nvarchar(30),
repaiTime nvarchar(30)
);

create table desserts(
id int primary key auto_increment ,
namez nvarchar(30),
price int not null,
pathImage varchar(100),
information nvarchar(2000) ,
sale int default 0,
timeLine nvarchar(30),
repaiTime nvarchar(30)
);

create table drinks(
id int  auto_increment ,
namez nvarchar(30) ,
price int not null,
pathImage varchar(100),
information nvarchar(2000),
sale int default 0,
timeLine nvarchar(30),
repaiTime nvarchar(30),
constraint k3 primary key (id,namez)
);
drop table drinks;
drop table desserts;
drop table saltyfood;

