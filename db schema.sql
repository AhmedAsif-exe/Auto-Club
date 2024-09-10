create database AutoClub
use AutoClub

CREATE TABLE users (
	id INT IDENTITY(1,1) PRIMARY KEY,
	user_name VARCHAR(255) NOT NULL,
	password VARCHAR(255) NOT NULL
);

