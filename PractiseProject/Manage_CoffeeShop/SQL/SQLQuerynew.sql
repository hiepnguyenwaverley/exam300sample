
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
('Milk Coffee','Milk coffee is a category of coffee-based drinks made with milk',200,(SELECT *FROM OPENROWSET(BULK 'D:\project\exam300sample\PractiseProject\Manage_CoffeeShop\wwwroot\images\milkcoffee.jpg', SINGLE_BLOB) as Images), 3.60),

('Black Coffee','Brown sugar, boiling water, ice cubes, coffee granules ',200,(SELECT *FROM OPENROWSET(BULK 'D:\project\exam300sample\PractiseProject\Manage_CoffeeShop\wwwroot\images\blackcoffee.jpg', SINGLE_BLOB) as Images), 2.60),

('Cappucino',' espresso coffee drink, topped with a small amount of foamed or steamed milk ',200,(SELECT *FROM OPENROWSET(BULK 'D:\project\exam300sample\PractiseProject\Manage_CoffeeShop\wwwroot\images\Cappucino.jpg', SINGLE_BLOB) as Images), 3.60),

('Cafe Mocha','Chocolate, espresso and steamed milk ',200,(SELECT *FROM OPENROWSET(BULK 'D:\project\exam300sample\PractiseProject\Manage_CoffeeShop\wwwroot\images\Mocha.jpg', SINGLE_BLOB) as Images), 3.60),

('Affogato','Espresso poured over ice cream',200,(SELECT *FROM OPENROWSET(BULK 'D:\project\exam300sample\PractiseProject\Manage_CoffeeShop\wwwroot\images\Affogato.jpg', SINGLE_BLOB) as Images), 5.20),

('Cold Brew','Slow-steeped chilled coffee',200,(SELECT *FROM OPENROWSET(BULK 'D:\project\exam300sample\PractiseProject\Manage_CoffeeShop\wwwroot\images\coldbrew.jpg', SINGLE_BLOB) as Images), 3.00)

DELETE FROM Products;

CREATE TABLE Customers (
  Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY not null,
  Name VARCHAR(100) not null,
  Phone VARCHAR(20) not null,
  Email VARCHAR(100) not null,
  Country VARCHAR(100) not null
  
);

INSERT INTO Customers(Name,Phone,Email,Country)
VALUES 
('Nguyen Van A','9725550145','nguyenvana@gmail.com','TPHCM'),
('Nguyen Van B','9725550145','nguyenvanb@gmail.com','Ha Noi'),
('Nguyen Van C','9725550145','nguyenvanc@gmail.com','Hai Phong'),
('Nguyen Van D','9725550145','nguyenvand@gmail.com','Da Nang')

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

