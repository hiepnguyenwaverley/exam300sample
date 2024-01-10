CREATE DATABASE	TheCoffeeShop

CREATE TABLE Employee 
(
Id int identity not null,
Name nvarchar(50) not null,
Position nvarchar(100) not null,
Birthday date not null,
Address nvarchar(50) not null,
Phone varchar(10) not null,
Email nvarchar(50) not null,
Passwords nvarchar(50) not null,
RoleId int not null,
PRIMARY KEY (Id),
FOREIGN KEY (RoleId) REFERENCES Roles(Id)
);

INSERT INTO Employee ("Id","Name","Position","Email","Passwords","Phone","Birthday","Address","RoleId")
VALUES
( '1','Trọng Hiếu', 'Manager', 'abcd@gmail.com','12345','0123456789','2/11/2023','HBT','1'),
( '2','Anh Tú', 'Staff', '1234@gmail.com','54321','0123456789','3/11/2023','PNT','2');

CREATE TABLE Customer
(
Id int identity not null,
Name nvarchar(50) not null,
Phone varchar(10) not null,
Email nvarchar(50) not null,
Address nvarchar(10) not null,
PRIMARY KEY (Id)


);

CREATE TABLE Product
(
Id int identity not null,
Name nvarchar(50) not null,
Price decimal(9,0) not null,
Descriptions text not null,
CategoryId int not null,
PRIMARY KEY (Id),
FOREIGN KEY (CategoryId) REFERENCES Category(Id)

);


CREATE TABLE Category
(
Id int identity not null,
Name nvarchar(50) not null,
PRIMARY KEY (Id)

);

CREATE TABLE Roles
(
Id int identity not null ,
EmployeeId int not null ,
NameRole nvarchar(50)
PRIMARY KEY (Id)

);

INSERT INTO Roles ("Id","EmployeeId","NameRole")
VALUES
('1','1','Admin'),
('2','2','Employee')


CREATE TABLE Orders
(
Id int identity not null,
OrderTime datetime not null,
Orderdate date,
EmployeeId int not null,
CustomerId int not null,
PRIMARY KEY (Id),
FOREIGN KEY (CustomerId) REFERENCES Customer(Id),
FOREIGN KEY (EmployeeId) REFERENCES Employee(Id)

);

CREATE TABLE OrderDetail
(
Id int identity not null,
OrderId int not null,
ProductId int not null,
Quantity int not null,
Note text ,
PRIMARY KEY (Id),
FOREIGN KEY (ProductId) REFERENCES Product(Id),
FOREIGN KEY (OrderId) REFERENCES Orders(Id)
);

CREATE TABLE Users
(
Id int not null,
Name nvarchar(50) not null,
Password nvarchar(50) not null
);

INSERT INTO Users ("Id",Name,Password)
VALUES
('1','Van A','123'),
('2','Van B','12345')