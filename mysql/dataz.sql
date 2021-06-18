create	database gamo;
use gamo;

-- drop table administration;
-- drop table userz;
create table  administration(
userName nvarchar(30) primary key,
passwordz varchar(30) ,
fullName nvarchar(40) ,
gmail varchar(40) ,
pathImage nvarchar(100) default "unknow",
timeLine  nvarchar(100) ,
repaiTime nvarchar(100)
);

create table userz(
userAdmin nvarchar(30),
id int  auto_increment,
userName nvarchar(30) ,
passwordz nvarchar(30) ,
timeLine nvarchar(30),
constraint primaryKeyUserz primary key(id,userName), -- Khóa chính
constraint foreignkeyUserz foreign key (userAdmin) references administration (userName) -- tạo khóa ngoại
);

create table saltyfood(
userAdmin nvarchar(30), -- khóa ngoại
id int  auto_increment , 
namez nvarchar(30) ,
price int ,
pathImage nvarchar(100),
information nvarchar(2000) ,
sale int ,
timeLine nvarchar(30),
repaiTime nvarchar(30),
constraint  primaryKeySaltyfood primary key (id,namez),
constraint foreignkeySaltyfood foreign key (userAdmin) references administration (userName) -- tạo khóa ngoại
);

create table desserts(
userAdmin nvarchar(30), -- khóa ngoại
id int  auto_increment , 
namez nvarchar(30) ,
price int ,
pathImage nvarchar(100),
information nvarchar(2000) ,
sale int ,
timeLine nvarchar(30),
repaiTime nvarchar(30),
constraint  primaryKeyDesserts primary key (id,namez),
constraint foreignkeyDesserts foreign key (userAdmin) references administration (userName) -- tạo khóa ngoại
);

create table drink(
userAdmin nvarchar(30), -- khóa ngoại
id int  auto_increment , 
namez nvarchar(30) ,
price int ,
pathImage nvarchar(100),
information nvarchar(2000) ,
sale int ,
timeLine nvarchar(30),
repaiTime nvarchar(30),
constraint  primaryKeyDrink primary key (id,namez),
constraint foreignkeyDrink foreign key (userAdmin) references administration (userName) -- tạo khóa ngoại
);

drop table historyOfData;
create table historyOfData(
userAdmin nvarchar(30), -- khóa ngoại,
diu nvarchar(30),
tableName  nvarchar(30),
id int primary key auto_increment,
namez nvarchar(30),
timeLine nvarchar(30),
pathImage nvarchar(150),
constraint foreignkeyHistoryOfData  foreign key (userAdmin) references administration (userName)
)


