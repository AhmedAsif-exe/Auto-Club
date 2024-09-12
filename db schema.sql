create database AutoClub
use AutoClub

CREATE TABLE users (
	id INT IDENTITY(1,1) PRIMARY KEY,
	user_name VARCHAR(255) NOT NULL,
	password VARCHAR(255) NOT NULL
);
CREATE TABLE cars (
    car_number VARCHAR(20) PRIMARY KEY,
    maker VARCHAR(50),
    model VARCHAR(50),
    engine_number VARCHAR(50),
    chassis_number VARCHAR(50),
	color varchar(50),
	status varchar(50)

);

CREATE TABLE customers (
    customer_id INT PRIMARY KEY IDENTITY(1,1), -- Auto-incrementing customer ID
    name VARCHAR(100) NOT NULL,                -- Customer's name
    parent_name VARCHAR(100) not null,         -- Customer's parent name
    cnic VARCHAR(15) NOT NULL UNIQUE,          -- Customer's CNIC (unique)
    phone_number VARCHAR(20) NOT NULL,         -- Customer's phone number
    phone_residence VARCHAR(255),               -- Customer's phone residence
    current_residence VARCHAR(255) NOT NULL,   -- Customer's current residence
    
    guarantor_name VARCHAR(100) Not NUll,      -- Guarantor's name
    guarantor_parent_name VARCHAR(100), -- Guarantor's parent name
    guarantor_cnic VARCHAR(15) UNIQUE Not NUll, -- Guarantor's CNIC (unique)
    guarantor_phone_number VARCHAR(20) Not NUll, -- Guarantor's phone number
    guarantor_phone_residence VARCHAR(20) ,     -- Guarantor's phone residence
    guarantor_current_residence VARCHAR(255) Not NUll -- Guarantor's current residence
);
CREATE TABLE customer_cars (
    rental_id INT PRIMARY KEY IDENTITY(1,1),    -- Auto-incrementing rental ID
    customer_id INT NOT NULL,                   -- Customer ID (foreign key)
    car_id VARCHAR(20) NOT NULL,                -- Car ID (foreign key)
    rental_date DATETIME NOT NULL,              -- Date and time when the car was rented
    return_date DATETIME,                       -- Date and time when the car was returned (nullable)

    -- Foreign key constraints
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
    FOREIGN KEY (car_id) REFERENCES cars(car_number)
);


INSERT INTO cars (car_number, maker, model, engine_number, chassis_number, color) VALUES
('NA-277', 'RECO', '2022', '1GD5206292', 'GUN126R-5555813', 'Red'),
('AQV-765', 'REVO', '2020', '1GD07955448', 'GUN126R-5539022', 'Blue'),
('SV-295', 'REVO', '2020', '1GD0795053', 'GUN126R-5538692', 'Black'),
('BDF-277', 'FORTUNER', '2024', '1GD5434715', 'GUN156R-1104918', 'White'),
('ATX-4', 'FORTUNER', '2021', '1GD0927669', 'GUN156R-1094520', 'Silver'),
('AMH-630', 'FORTUNER', '2019', '1GD0622035', 'GUN156R-1090446', 'Grey'),
('ASX-277', 'NEW HONDA', '2024', 'L15BG7918984', 'NFBFE1651RR008969', 'Orange'),
('AYE-852', 'HONDA CIVIC', '2022', 'L15BG7910878', 'NFBFE1656NR000876', 'Yellow'),
('BBK-479', 'HONDA CIVIC', '2022', 'L15BG7912456', 'NFBFE1659NR002525', 'Green'),
('BCD-656', 'HRV', '2022', 'L15ZG1001429', 'NFBRV3850PR001434', 'Purple'),
('BBW-621', 'HRV', '2022', 'L15ZG1001303', 'NFBRV385XNR001289', 'Brown'),
('ATD-143', 'HONDA CIVIC', '2021', 'R18Z16928535', 'NFBFC6669MR081110', 'Maroon'),
('ATV-649', 'HONDA CIVIC', '2021', 'R18Z16920112', 'NFBFC6666MR072395', 'Pink'),
('AVY-70', 'HONDA CIVIC', '2022', 'R18Z16930992', 'NFBFC666XNR083577', 'Beige'),
('ALX-15', 'HONDA CIVIC', '2018', 'R18Z12934286', 'NFBFC666XJR037712', 'Teal'),
('ARG-477', 'HONDA CIVIC', '2020', 'R18Z16912822', 'NFBFC6665LR064576', 'Cyan'),
('AVT-622', 'COROLLA ALTIS', '2021', 'Q082248', 'ZRE171R-6059803', 'Gold'),
('ATS-764', 'COROLLA ALTIS', '2020', 'Q066760', 'ZRE171R-6044284', 'Silver'),
('AQW-477', 'COROLLA', '2020', 'Z577753', 'NZE170R-4202814', 'Bronze'),
('ALE-477', 'COROLLA', '2018', 'Z538403', 'NZE170R-4164093', 'Copper'),
('VF-070', 'COROLLA', '2016', 'Z299532', 'NZE170R4041285', 'White'),
('IG-105', 'COROLLA ALTIS', '2019', 'Q067314', 'ZRE171R-6044791', 'Black'),
('RI-190', 'COROLLA', '2019', 'Z536522', 'NZE170R-4161838', 'Red'),
('LEB-4114', 'HONDA CITI', '2009', 'L13Z12421446', 'NFBGM16469R101453', 'Blue'),
('LE-954', 'HONDA CITI', '2015', 'L13Z17435377', 'NFBGM1643FR174727', 'Green'),
('ASU-477', 'HONDA CITI', '2021', NULL, NULL, 'Yellow'),
('FZ-405', 'COROLLA', '2015', 'Z371448', 'NZE170R4057174', 'Orange'),
('AVB-656', 'YARAS', '2021', '2A30631', 'NSP150R-7018850', 'Pink'),
('ATV-733', 'COROLLA', '2020', 'Z566609', 'NZE170R4192294', 'Purple'),
('RIB-555', 'HONDA CIVIC', '2019', 'R18Z12922031', 'NFBFC6663HR025377', 'Brown'),
('ATG-514', 'HONDA CIVIC', '2021', 'R18Z16921271', 'NFBSC6660MR073526', 'Beige'),
('ATW-41', 'HONDA CITI', '2021', 'L13Z17547048', 'NFBGM1644MR272212', 'Teal'),
('AET-796', 'COROLLA', '2017', 'Z498466', 'NZE170R-4124374', 'Cyan'),
('ANX-66', 'HONDA CIVIC', '2021', 'R18Z16919262', 'NFBFC6665MR071397', 'Gold'),
('LEF-2784', 'HONDA CITI', '2017', 'L13Z17462761', 'NFBGM1540HR206067', 'Silver'),
('LEC-1935', 'TOYOTA COROLLA', '2016', 'Z409432', 'NZE170R4066719', 'Bronze'),
('LEA-2900', 'COROLLA', '2020', 'Z573096', 'NZE170R4198961', 'Copper'),
('ASG-277', 'HONDA CIVIC', '2020', 'R18Z16916261', 'NFBFC666LR068285', 'White'),
('BHT-512', 'HONDA CIVIC', '2017', 'R18Z12908647', 'NFBFC6664HR011648', 'Black'),
('ATZ-046', 'HONDA BRV', '2021', 'L15Z14805097', 'NFBDG183XMR021791', 'Red'),
('ARY-424', 'HONDA BRV', '2020', 'L15Z14803254', 'NFBDG1831LR019930', 'Blue'),
('AJT-812', 'CORROLLA', '2018', 'Q048269', 'ZRE171R6025724', 'Green'),
('AQJ-560', 'CORROLLA', '2020', 'Z575214', 'NZE170R-4200768', 'Yellow'),
('CZ-522', 'CORROLLA', '2014', '2NZ-7110922', 'NZE170R-4006250', 'Orange'),
('AKS-831', 'HONDA CITY', '2018', 'L13Z17519418', 'NFBGM1646JR234976', 'Pink'),
('AKD-551', 'TOYOTA COROLLA', '2018', 'Q049739', 'ZRE171R-6027220', 'Purple'),
('ASG-567', 'TOYOTA YARIS', '2020', '2A07191', 'NSP150R-7003983', 'Brown'),
('AQW-251', 'CULTUS', '2020', '159699', '10059695', 'Beige'),
('AYS-934', 'CULTUS', '2022', 'PK10K195950', 'NF1AVK31H10095943', 'Teal'),
('AZT-722', 'ALTO', '2022', '6R235123', 'NF1AET306H1135075', 'Cyan'),
('APK-410', 'ALTO', '2019', '6R118394', 'NF1AET306H1018300', 'Gold'),
('AWW-477', 'ALTO', '2022', '6R205080', 'NF1AET306H1105067', 'Silver'),
('ASJ-953', 'ALTO', '2020', '6R106534', 'NF1AET306H1006515', 'Bronze'),
('BBE-46', 'ALTO', '2022', '6R268465', 'NF1AET306H1168456', 'Copper'),
('ATT-576', 'WAGON-R', '2021', 'PK10B195701', 'A1J310PK10107659', 'White'),
('BAE-278', 'WAGON-R', '2018', 'PK10B178775', 'A1J310PK10107055', 'Red'),
('BE-122', 'WAGON-R', '2021', 'PK10B194400', 'A1J310PK10107488', 'Blue'),
('BS-212', 'WAGON-R', '2020', 'PK10B190440', 'A1J310PK10106894', 'Green'),
('AE-055', 'WAGON-R', '2022', 'PK10B195716', 'A1J310PK10107882', 'Yellow'),
('BFT-777', 'WAGON-R', '2019', 'PK10B190915', 'A1J310PK10107320', 'Orange'),
('BHA-822', 'WAGON-R', '2020', 'PK10B192823', 'A1J310PK10106913', 'Pink'),
('AZ-777', 'WAGON-R', '2021', 'PK10B196650', 'A1J310PK10108533', 'Purple'),
('BFS-012', 'WAGON-R', '2022', 'PK10B195926', 'A1J310PK10111609', 'Brown'),
('BGM-555', 'WAGON-R', '2019', 'PK10B177425', 'A1J310PK10106224', 'Beige'),
('BE-432', 'WAGON-R', '2021', 'PK10B195402', 'A1J310PK10108221', 'Teal'),
('BA-442', 'WAGON-R', '2022', 'PK10B196100', 'A1J310PK10111536', 'Cyan'),
('BAB-011', 'WAGON-R', '2020', 'PK10B190102', 'A1J310PK10106847', 'Gold'),
('BAT-425', 'WAGON-R', '2021', 'PK10B195478', 'A1J310PK10107567', 'Silver'),
('BA-486', 'WAGON-R', '2022', 'PK10B196423', 'A1J310PK10111555', 'Bronze'),
('AA-555', 'ALTO', '2021', '6R254554', 'NF1AET306H1058090', 'Copper'),
('BAK-238', 'ALTO', '2022', '6R288555', 'NF1AET306H1110162', 'Pink'),
('BFD-333', 'ALTO', '2018', '6R213011', 'NF1AET306H1039642', 'Purple'),
('AS-766', 'ALTO', '2021', '6R248226', 'NF1AET306H1059911', 'Brown'),
('BA-993', 'ALTO', '2021', '6R248226', 'NF1AET306H1059911', 'Beige'),
('AG-726', 'ALTO', '2022', '6R233437', 'NF1AET306H1122328', 'Teal'),
('BBE-333', 'ALTO', '2021', '6R248237', 'NF1AET306H1059877', 'Cyan'),
('AP-292', 'ALTO', '2020', '6R273666', 'NF1AET306H1043421', 'Gold'),
('AG-888', 'ALTO', '2019', '6R232688', 'NF1AET306H1025435', 'Silver'),
('AE-772', 'ALTO', '2021', '6R270520', 'NF1AET306H1072498', 'Bronze'),
('BB-786', 'ALTO', '2022', '6R274620', 'NF1AET306H1111584', 'Orange'),
('ABB-487', 'ALTO', '2019', '6R232867', 'NF1AET306H1030904', 'Beige'),
('AY-782', 'ALTO', '2021', '6R231208', 'NF1AET306H1064740', 'Pink');


update cars
set status = 'Available'
where status is NULL

SELECT name, cnic, phone_number, guarantor_name, car_number, maker, model, rental_date, return_date 
FROM customer_cars cc
INNER JOIN customers c ON cc.customer_id = c.customer_id
INNER JOIN cars ON cc.car_id = cars.car_number
WHERE cc.rental_date BETWEEN CAST(GETDATE() AS DATE) AND CAST(GETDATE() AS DATE);
