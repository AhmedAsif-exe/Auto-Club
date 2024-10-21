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
	color varchar(50)
);

select * from cars where car_number = ' ALX-15'

UPDATE cars SET maker = 'HONDA CIVIC', model = '2018', engine_number = 'R18Z12934286', chassis_number = 'NFBFC666XJR037712', color = 'WHITE', status = 'Not Available' WHERE car_number = ' ALX-15'

ALTER TABLE cars
ADD status VARCHAR(50) DEFAULT NULL;
select * from cars where maker = 'ALT'

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
    guarantor_cnic VARCHAR(15) Not NUll, -- Guarantor's CNIC (unique)
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
	destination varchar(200) Not NULL,
    -- Foreign key constraints
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
    FOREIGN KEY (car_id) REFERENCES cars(car_number)

);

ALTER TABLE customer_cars
DROP CONSTRAINT FK__customer___car_i__5165187F;

ALTER TABLE customer_cars
DROP CONSTRAINT FK__customer___custo__5165187F;

SELECT 
    fk.name AS ForeignKeyName,
    t.name AS TableName
FROM 
    sys.foreign_keys AS fk
INNER JOIN 
    sys.tables AS t ON fk.parent_object_id = t.object_id
WHERE 
    t.name = 'customer_cars';  -- Replace with your table name
-- Step 2: Re-add the foreign key constraint with ON UPDATE CASCADE



drop table customer_cars
select * from customer_cars
drop table customers
drop table customer_cars

select * from customers
update cars
set status = 'Available'
where status is NULL
select * from users
SELECT * FROM CUSTOMERS
select * from customer_cars
select * from cars
SELECT customer_id, name 
drop table customer_cars
drop table cars
SELECT name, cnic, phone_number, parent_name, phone_residence, current_residence, guarantor_name, guarantor_cnic, guarantor_phone_number, guarantor_parent_name, guarantor_phone_residence, guarantor_current_residence, car_number, maker, model, engine_number, chassis_number, color, rental_date, return_date, destination
                                FROM customer_cars cc
                                INNER JOIN customers c ON cc.customer_id = c.customer_id
                                INNER JOIN cars ON cc.car_id = cars.car_number
SELECT * FROM cars WHERE status = 'Deleted'
update customer_cars
set return_date = GETDATE()
where return_date is null and car_id = 'NA-277'  

BULK INSERT cars
FROM 'C:\Users\LENOVO\Desktop\autoClub.csv'
WITH (
	FORMAT = 'CSV',
    FIELDTERMINATOR = ',', 
    ROWTERMINATOR = '0x0A',  
    FIRSTROW = 2
);
drop table cars

drop table customer_cars