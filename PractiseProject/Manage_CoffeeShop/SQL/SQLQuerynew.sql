
CREATE TABLE Roles (
  Id INT PRIMARY KEY not null,
  Name VARCHAR(100) not null
);

Insert into Roles (Id,Name)
values
('1','Manager'),
('2','Staff');


CREATE TABLE Users (
  Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY not null,
  Name VARCHAR(100) not null,
  Password VARCHAR(50) not null,
  RoleId INT not null,
  FOREIGN KEY (RoleId) REFERENCES Roles(Id)
);

Insert into Users (Name,Password,RoleId)
values
('Nguyen Van A','123','1'),
('Nguyen Van B','123','2'),
('Nguyen Van C','123','2'),
('Nguyen Van D','123','2');


SET IDENTITY_INSERT dbo.Users OFF; 
Insert into Users(Name,Password,RoleId)
values
('Ho Hao H','321','1');	

SET IDENTITY_INSERT dbo.Users ON;
SET IDENTITY_INSERT dbo.Users OFF;	

CREATE TABLE Products (
  Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY not null,
  Name VARCHAR(100) not null,
  Description TEXT,
  Quantity INT,
  Images VARBINARY (MAX),
  Price DECIMAL(10,2) not null ,

);

INSERT INTO Products (Name,Description,Quantity,Images,Price)
VALUES 
('Milk Coffee','Milk coffee is a category of coffee-based drinks made with milk',200,(SELECT *FROM OPENROWSET(BULK 'D:\project\exam300sample\PractiseProject\Manage_CoffeeShop\wwwroot\images\milkcoffee.jpg', SINGLE_BLOB) as Images), 1.60),

('Black Coffee','Brown sugar, boiling water, ice cubes, coffee granules ',200,(SELECT *FROM OPENROWSET(BULK 'D:\project\exam300sample\PractiseProject\Manage_CoffeeShop\wwwroot\images\blackcoffee.jpg', SINGLE_BLOB) as Images), 1.60),

('Cappucino',' espresso coffee drink, topped with a small amount of foamed or steamed milk ',200,(SELECT *FROM OPENROWSET(BULK 'D:\project\exam300sample\PractiseProject\Manage_CoffeeShop\wwwroot\images\download.jpg', SINGLE_BLOB) as Images), 1.60)


CREATE TABLE Customers (
  Id INT Identity PRIMARY KEY not null,
  Name VARCHAR(100) not null,
  Email VARCHAR(100) not null
);

CREATE TABLE Orders (
  Id INT Identity PRIMARY KEY not null,
  CustomerId INT not null,
  Orderdate DATE not null,
  FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
);

CREATE TABLE OrderItems (
  Id INT Identity PRIMARY KEY not null,
  OrderId INT not null,
  ProductId INT not null,
  Quantity INT not null,
  FOREIGN KEY (OrderId) REFERENCES Orders(Id),
  FOREIGN KEY (ProductId) REFERENCES Products(Id)
);

