use C291_Project;



-- drop all tables in reverse order of creation for dependencies --
--
--

drop table IF EXISTS RentalTransaction;
drop table IF EXISTS Employee;
drop table IF EXISTS Car;
drop table IF EXISTS Branch;
drop table IF EXISTS CarType;
drop table IF EXISTS MemberStatus;
drop table IF EXISTS Customer;

-- create tables in order of dependency --
--
--

create table Customer(
cID int,
driverLicense varchar(30) NOT NULL, -- changed from int
name varchar(30) NOT NULL,
phoneNumber varchar(10), 
address1 varchar(30),
city varchar(30),
province varchar(30),
postCode varchar(10),
-- keys --
primary key(cID),
);

create table MemberStatus(
cID int, 
sinceDate date NOT NULL, 
-- keys --
primary key(cID), 
foreign key(cID) references Customer
);

create table CarType(
cType varchar(30),
dailyRate float NOT NULL,
lateDailyRate float NOT NULL, 
penaltyRate float NOT NULL,
-- keys --
primary key(cType)
);

create table Branch(
branchID int,
branchName varchar(30) NOT NULL,
phoneNumber varchar(10), 
address1 varchar(30),
city varchar(30), 
province varchar(30), 
postCode varchar(30),
-- keys --
primary key(branchID)
);

create table Car(
VIN varchar(30), -- changed from int
make varchar(30) NOT NULL, 
model varchar(30) NOT NULL,
color varchar(30) NOT NULL, 
cType varchar(30) NOT NULL, 
branchID int, -- changed from not null
-- keys --
primary key(VIN),
foreign key(cType) references CarType,
foreign key(branchID) references Branch
);

create table Employee(
eID int,
name varchar(30) NOT NULL, 
position varchar(30),
phoneNumber varchar(10), 
address1 varchar(30), 
city varchar(30), 
province varchar(30),
postCode varchar(30),
branchID int NOT NULL,
-- keys --
primary key(eID),
foreign key(branchID) references Branch
);

create table RentalTransaction(
rID int, 
customerID int NOT NULL,
carID varchar(30) NOT NULL, -- changed from int
dateOut date NOT NULL,
dateIn date,
dateExpectedIn date NOT NULL,
branchOutID int NOT NULL,
branchInID int,
employeeOutID int NOT NULL,
employeeInID int,
paymentInformation varchar (30) NOT NULL,
totalBalance float,
-- keys --
primary key(rID), 
foreign key(customerID) references Customer, 
foreign key(carID) references Car, 
foreign key(branchOutID) references Branch, 
foreign key(branchInID) references Branch,
foreign key(employeeOutID) references Employee,
foreign key(employeeInID) references Employee
);

