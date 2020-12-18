use C291_Project;



-- delete existing data
--
--
DELETE FROM RentalTransaction;
DELETE FROM Employee;
DELETE FROM Car;
DELETE FROM Branch;
DELETE FROM CarType;
DELETE FROM MemberStatus; 
DELETE FROM Customer;

-- insert sample data
--
--
-- Customer --
-- cID, driverLicense, name, phoneNumber, address1, city, province, postCode
insert into Customer values(1, 'DL0001', 'Justin Hunt', '7807807800', '12300 123 St','Edmonton', 'AB', 'T0T 0T0');
insert into Customer values(2, 'DL0002', 'James Smith', '6044561000', '10 Hill St','Calgary', 'AB', 'T1T 1T1');
insert into Customer values(3, 'DL0003', 'Alice Wu', '4031230202', '4020 Deerfoot','Vancouver', 'BC', 'V0V 0T0');
insert into Customer values(4, 'DL0004', 'Bob Doe', '6041230202', '10 Short Road','Edmonton', 'AB', 'T2T 2T2');
insert into Customer values(5, 'DL0005', 'John Wick', '3061230202', '9711 50 St','Winnipeg', 'MB', 'R0R 0T0');
insert into Customer values(6, 'DL0006', 'Bruce Wayne', '3065550202', '99 Bumpy Trail','Calgary', 'AB', 'T3T 3T3');
insert into Customer values(7, 'DL0007', 'Mickey Mouse', '2041230202', '6040 10 St','Regina', 'SK', 'S0S 0T0');
insert into Customer values(8, 'DL0008', 'Jim Bond', '4161230202', '410 Other Way','Vancouver', 'BC', 'V1V 1T1');
insert into Customer values(9, 'DL0009', 'Oscar Perez', '6131230202', '1099 23 Ave','Winnipeg', 'MB', 'R1R 1T1');
insert into Customer values(10, 'DL0010', 'Tim Burton', '5141230202', '10910 104 Ave','Edmonton', 'AB', 'T4T 4T4');

-- MemberStatus --
-- cID, memberStatus
insert into MemberStatus values(1, '2018-07-12');
insert into MemberStatus values(5, '2017-10-24');
insert into MemberStatus values(9, '2018-03-22');

-- CarType --
-- cType, dailyRate, lateDailyRate, penaltyRate
insert into CarType values('Luxury Car', 49.00, 10.00, 20.00);
insert into CarType values('Truck', 44.00, 11.00, 25.00);
insert into CarType values('SUV', 39.00, 12.00, 15.00);
insert into CarType values('Sedan', 29.00, 13.00, 10.00);

-- Branch --
-- branchID, branchName, phoneNumber, address1, city, province, postCode
insert into Branch values(1, 'Hilltop', '5871230000', '123 Car St', 'Edmonton', 'AB', 'T9T 9T9');
insert into Branch values(2, 'Valley', '4031010101', '50010 100 St', 'Calgary', 'AB', 'T8T 8T8');
insert into Branch values(3, 'Oceanview', '6041010101', '510 23 St', 'Vancouver', 'BC', 'V9V 9V9');
insert into Branch values(4, 'Downtown', '7804005010', '10010 101 St', 'Edmonton', 'AB', 'T5J 1V1');
insert into Branch values(5, 'South', '7805006123', '9923 23 Ave', 'Edmonton', 'AB', 'T6X 1M1');

-- Car --
-- VIN, make, model, color, cType, branchID
insert into Car values('FD900C001', 'Ford', 'Mustang', 'Blue', 'Luxury Car', 1);
insert into Car values('FD150T001', 'Ford', 'F150', 'Black', 'Truck', 1);
insert into Car values('FD150T002', 'Ford', 'F150', 'White', 'Truck', 2);
insert into Car values('MZ500S001', 'Mazda', 'CX-5', 'Grey', 'SUV', 2);
insert into Car values('HY300S001', 'Hyundai', 'Santa Fe', 'Black', 'SUV', 3);
insert into Car values('HN100C005', 'Honda', 'Civic', 'Blue', 'Sedan', 3);
insert into Car values('TY200C001', 'Toyota', 'Corolla', 'White', 'Sedan', 2);

-- Employee --
-- eID, name, position, phoneNumber, address1, city, province, postCode, branchID
insert into Employee values(1, 'Jim Bob', 'Manager', '7805551234', '100 Some St', 'Edmonton', 'AB', 'T1T 0T0', 1);
insert into Employee values(2, 'Tony Jim', 'Manager', '4035550101', '200 Flames St', 'Calgary', 'AB', 'T1T 9T9', 2);
insert into Employee values(3, 'Bob Tony', 'Not Manager', '6045551234', '20 River Rd', 'Vancouver', 'BC', 'V0V 0V0', 3);
insert into Employee values(4, 'Ned Ted', 'Not Manager', '7805555000', '10010 95 St', 'Edmonton', 'AB', 'T1T 2T2', 1);
insert into Employee values(5, 'Alex Wu', 'Not Manager', '7805555000', '10010 95 St', 'Edmonton', 'AB', 'T1T 2T2', 1);
insert into Employee values(6, 'Jane Parks', 'Not Manager', '7805555000', '10010 95 St', 'Edmonton', 'AB', 'T1T 2T2', 1);
insert into Employee values(7, 'Kyle Johnson', 'Not Manager', '7805555000', '10010 95 St', 'Edmonton', 'AB', 'T1T 2T2', 1);
insert into Employee values(8, 'Dan Bates', 'Not Manager', '7805555000', '10010 95 St', 'Edmonton', 'AB', 'T1T 2T2', 1);
insert into Employee values(9, 'Stu Sharp', 'Not Manager', '7805555000', '10010 95 St', 'Edmonton', 'AB', 'T1T 2T2', 1);
insert into Employee values(10, 'Rita Hayward', 'Not Manager', '7805555000', '10010 95 St', 'Edmonton', 'AB', 'T1T 2T2', 1);

-- RentalTransaction --
-- rID, customerID, carID, dateOut, dateIn, dateExpectedIn, branchOutID, branchInID, employeeOutID, employeeInID, paymentInformation, totalBalance
insert into RentalTransaction values(11,3,'FD900C001','2017-01-01','2017-01-07','2017-01-06',3,3,1,5,'debit5680',NULL);
insert into RentalTransaction values(12,5,'FD900C001','2017-03-06','2017-03-06','2017-03-07',4,5,8,5,'debit5551',NULL);
insert into RentalTransaction values(13,6,'FD900C001','2017-04-18','2017-04-25','2017-04-24',3,4,4,7,'debit4507',NULL);
insert into RentalTransaction values(14,6,'FD900C001','2017-08-20','2017-08-22','2017-08-21',2,1,4,5,'debit6568',NULL);
insert into RentalTransaction values(15,3,'FD900C001','2018-02-15','2018-02-21','2018-02-21',2,2,9,4,'debit5145',NULL);
insert into RentalTransaction values(16,6,'FD900C001','2018-07-06','2018-07-08','2018-07-08',1,2,7,1,'debit4100',NULL);
insert into RentalTransaction values(17,9,'FD900C001','2018-12-16','2018-12-22','2018-12-23',4,4,9,8,'debit5058',NULL);
insert into RentalTransaction values(18,8,'FD900C001','2019-04-30','2019-04-30','2019-05-01',5,3,5,5,'debit4193',NULL);
insert into RentalTransaction values(19,4,'FD900C001','2019-05-14','2019-05-16','2019-05-17',1,5,5,1,'debit6757',NULL);
insert into RentalTransaction values(20,1,'FD900C001','2019-05-22',NULL,'2019-06-24',2,NULL,4,NULL,'debit3547',NULL);
insert into RentalTransaction values(21,7,'FD150T001','2017-04-05','2017-04-06','2017-04-06',5,4,4,3,'debit7259',NULL);
insert into RentalTransaction values(22,3,'FD150T001','2017-05-30','2017-06-05','2017-06-04',5,4,7,8,'debit3900',NULL);
insert into RentalTransaction values(23,9,'FD150T001','2017-10-16','2017-10-22','2017-10-23',3,2,10,6,'debit6915',NULL);
insert into RentalTransaction values(24,3,'FD150T001','2017-11-19','2017-11-24','2017-11-25',5,1,10,2,'debit6065',NULL);
insert into RentalTransaction values(25,5,'FD150T001','2017-12-13','2017-12-14','2017-12-15',3,4,1,2,'debit1462',NULL);
insert into RentalTransaction values(26,6,'FD150T001','2018-03-08','2018-03-11','2018-03-12',3,2,5,8,'debit6658',NULL);
insert into RentalTransaction values(27,9,'FD150T001','2018-03-22','2018-03-26','2018-03-25',3,4,3,6,'debit4136',NULL);
insert into RentalTransaction values(28,3,'FD150T001','2018-05-02','2018-05-03','2018-05-03',4,4,2,8,'debit8884',NULL);
insert into RentalTransaction values(29,1,'FD150T001','2018-08-11','2018-08-17','2018-08-17',2,2,3,9,'debit4284',NULL);
insert into RentalTransaction values(30,9,'FD150T001','2019-06-06',NULL,'2019-06-08',3,NULL,7,NULL,'debit6136',NULL);
insert into RentalTransaction values(31,3,'FD150T002','2017-01-26','2017-01-30','2017-01-29',1,3,4,3,'debit4007',NULL);
insert into RentalTransaction values(32,10,'FD150T002','2017-07-17','2017-07-19','2017-07-20',2,5,9,8,'debit8433',NULL);
insert into RentalTransaction values(33,4,'FD150T002','2017-10-02','2017-10-05','2017-10-05',1,5,2,6,'debit2186',NULL);
insert into RentalTransaction values(34,6,'FD150T002','2018-01-12','2018-01-16','2018-01-17',3,2,10,3,'debit9937',NULL);
insert into RentalTransaction values(35,10,'FD150T002','2018-04-07','2018-04-11','2018-04-11',4,2,8,9,'debit7700',NULL);
insert into RentalTransaction values(36,10,'FD150T002','2018-04-19','2018-04-22','2018-04-22',5,4,5,6,'debit4337',NULL);
insert into RentalTransaction values(37,5,'FD150T002','2018-08-02','2018-08-07','2018-08-07',4,1,4,9,'debit4523',NULL);
insert into RentalTransaction values(38,1,'FD150T002','2018-08-14','2018-08-19','2018-08-20',4,4,8,8,'debit6114',NULL);
insert into RentalTransaction values(39,1,'FD150T002','2018-12-09','2018-12-10','2018-12-11',1,2,5,1,'debit7364',NULL);
insert into RentalTransaction values(40,5,'FD150T002','2019-06-12',NULL,'2019-06-26',2,NULL,4,NULL,'debit9234',NULL);
insert into RentalTransaction values(41,3,'MZ500S001','2017-04-01','2017-04-02','2017-04-03',5,4,5,9,'debit8214',NULL);
insert into RentalTransaction values(42,10,'MZ500S001','2017-09-09','2017-09-11','2017-09-12',2,5,9,2,'debit6728',NULL);
insert into RentalTransaction values(43,5,'MZ500S001','2017-10-24','2017-10-31','2017-10-31',5,1,3,2,'debit7919',NULL);
insert into RentalTransaction values(44,4,'MZ500S001','2018-02-04','2018-02-06','2018-02-06',4,4,2,6,'debit4057',NULL);
insert into RentalTransaction values(45,5,'MZ500S001','2018-07-10','2018-07-13','2018-07-12',2,3,5,3,'debit1687',NULL);
insert into RentalTransaction values(46,10,'MZ500S001','2018-11-10','2018-11-13','2018-11-14',4,3,3,4,'debit5193',NULL);
insert into RentalTransaction values(47,2,'MZ500S001','2019-03-07','2019-03-12','2019-03-13',1,3,2,5,'debit7664',NULL);
insert into RentalTransaction values(48,5,'MZ500S001','2019-04-26','2019-04-28','2019-04-29',4,2,9,5,'debit3679',NULL);
insert into RentalTransaction values(49,9,'MZ500S001','2019-05-07','2019-05-07','2019-05-08',4,2,3,5,'debit1034',NULL);
insert into RentalTransaction values(50,10,'MZ500S001','2019-06-24',NULL,'2019-06-26',3,NULL,3,NULL,'debit6151',NULL);
insert into RentalTransaction values(51,10,'HN100C005','2017-01-29','2017-01-31','2017-01-31',5,5,7,7,'debit6996',NULL);
insert into RentalTransaction values(52,10,'HN100C005','2017-03-04','2017-03-09','2017-03-09',4,4,6,6,'debit9241',NULL);
insert into RentalTransaction values(53,7,'HN100C005','2017-08-07','2017-08-13','2017-08-12',5,2,10,4,'debit1848',NULL);
insert into RentalTransaction values(54,5,'HN100C005','2017-09-08','2017-09-13','2017-09-13',5,3,9,2,'debit6516',NULL);
insert into RentalTransaction values(55,9,'HN100C005','2018-01-21','2018-01-25','2018-01-24',2,2,7,4,'debit1019',NULL);
insert into RentalTransaction values(56,5,'HN100C005','2018-02-25','2018-02-25','2018-02-26',5,4,1,4,'debit9584',NULL);
insert into RentalTransaction values(57,5,'HN100C005','2018-08-23','2018-08-28','2018-08-27',5,4,3,9,'debit8035',NULL);
insert into RentalTransaction values(58,4,'HN100C005','2018-08-30','2018-09-05','2018-09-04',3,3,6,9,'debit2301',NULL);
insert into RentalTransaction values(59,8,'HN100C005','2018-12-06','2018-12-08','2018-12-08',3,5,10,2,'debit4455',NULL);
insert into RentalTransaction values(60,7,'HN100C005','2019-06-07',NULL,'2019-06-11',5,NULL,2,NULL,'debit8458',NULL);
insert into RentalTransaction values(61,4,'TY200C001','2017-01-29','2017-01-30','2017-01-30',4,4,10,9,'debit5717',NULL);
insert into RentalTransaction values(62,8,'TY200C001','2017-05-25','2017-05-29','2017-05-30',4,5,3,2,'debit1909',NULL);
insert into RentalTransaction values(63,4,'TY200C001','2017-06-12','2017-06-13','2017-06-14',3,5,5,10,'debit5562',NULL);
insert into RentalTransaction values(64,6,'TY200C001','2017-09-24','2017-09-28','2017-09-27',1,4,7,3,'debit3313',NULL);
insert into RentalTransaction values(65,3,'TY200C001','2018-01-27','2018-02-03','2018-02-03',5,4,9,7,'debit2735',NULL);
insert into RentalTransaction values(66,1,'TY200C001','2018-03-30','2018-04-04','2018-04-05',1,2,7,1,'debit1920',NULL);
insert into RentalTransaction values(67,1,'TY200C001','2018-05-26','2018-05-26','2018-05-27',3,4,5,7,'debit9261',NULL);
insert into RentalTransaction values(68,4,'TY200C001','2018-06-05','2018-06-07','2018-06-08',1,2,3,10,'debit2636',NULL);
insert into RentalTransaction values(69,1,'TY200C001','2018-07-12','2018-07-20','2018-07-19',4,1,5,8,'debit7709',NULL);
insert into RentalTransaction values(70,2,'TY200C001','2019-06-01',NULL,'2019-06-12',3,NULL,9,NULL,'debit2264',NULL);

-- set the transaction totals -- 
--
--
-- calculate the regular daily rate
UPDATE RentalTransaction
SET totalBalance = (SELECT DATEDIFF(day, dateOut, dateIn)) * dailyRate
FROM RentalTransaction
JOIN Car ON RentalTransaction.carID = Car.VIN
JOIN CarType ON Car.cType = CarType.cType
JOIN Customer ON RentalTransaction.customerID = Customer.cID
LEFT JOIN MemberStatus on Customer.cID = MemberStatus.cID;
--
-- calculate the late fee if returned after expected date
UPDATE RentalTransaction
SET totalBalance = totalBalance + ((SELECT DATEDIFF(day, dateExpectedIn, dateIn)) * lateDailyRate)
FROM RentalTransaction
JOIN Car ON RentalTransaction.carID = Car.VIN
JOIN CarType ON Car.cType = CarType.cType
JOIN Customer ON RentalTransaction.customerID = Customer.cID
LEFT JOIN MemberStatus on Customer.cID = MemberStatus.cID
WHERE dateIn > dateExpectedIn;
--
-- apply location penalty if returned at different location and not gold member
UPDATE RentalTransaction
SET totalBalance = totalBalance + penaltyRate
FROM RentalTransaction
JOIN Car ON RentalTransaction.carID = Car.VIN
JOIN CarType ON Car.cType = CarType.cType
JOIN Customer ON RentalTransaction.customerID = Customer.cID
WHERE NOT EXISTS (SELECT * FROM MemberStatus WHERE MemberStatus.cID = Customer.cID) and
	  RentalTransaction.branchInID != RentalTransaction.branchOutID;

