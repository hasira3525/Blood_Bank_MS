Create Database BloodBankDb;
Use BloodBankDb;

Create table DonorTbl
(DNum int identity, 
DName varchar(50) not null, 
DAge int not null, 
DGender varchar(10) not null,
DPhone varchar(50) not null,
DAddress varchar(50) not null, 
DBGroup varchar(5) not null,
Primary key (DNum));

insert into DonorTbl
values('Sandaru', 22, 'Male', '0703476860', 'Rathnapura', 'O+'); 

Create table PatientTbl
(PNum int identity,
PName varchar(50) not null,
P_Age int not null,
PPhone varchar(50) not null,
PGender varchar(50) not null,
PBGroup varchar(50) not null,
PAddress varchar(50) not null,
Primary key(PNum));

insert into PatientTbl
values('Hasira', 20, '0785853300', 'Male', 'AB+', 'Oruwala');

Create table BloodTbl
(BGroup varchar(50),
BStock int);

insert into BloodTbl
values('A+', 0),('O+', 1),('B+', 0),('AB+', 0),
('A-', 0),('O-', 0),('B-', 0),('AB-', 0);

Create table TransferTbl
(TNum int identity,
PName varchar(50) not null,
BGroup varchar(50) not null);

Create table EmployeeTbl
(EmpNum int identity,
EmpId varchar(50) not null,
EmpPass varchar(50) not null);

select* from DonorTbl;


