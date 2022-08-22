/* Creating Database to our Project */
CREATE DATABASE educational_app;
USE educational_app;

/* Creating Tables in educational_app */
CREATE TABLE directors
(
	id int identity(1,1) primary key,
	username varchar(100) not null,
	surname varchar(100) not null,
	email varchar(100) not null UNIQUE,
	phone varchar(20),
	password nvarchar(50) not null,
	gender_id int not null default 1,
	roll_id int not null default 3
);

CREATE TABLE professors
(
	id int identity(1,1) primary key,
	username varchar(100) not null,
	surname varchar(100) not null,
	email varchar(100) not null UNIQUE,
	phone varchar(20),
	password nvarchar(50) not null,
	gender_id int not null default 1,
	roll_id int not null default 2
);

CREATE TABLE students
(
	id int identity(1,1) primary key,
	username varchar(100) not null,
	surname varchar(100) not null,
	email varchar(100) not null UNIQUE,
	phone varchar(20),
	password nvarchar(50) not null,
	gender_id int not null default 1,
	roll_id int not null default 1
);
/* Creating sub tables */

CREATE TABLE subjects
(
	id int identity(1,1) primary key,
	title varchar(70) not null,
	teacher_id int not null,
	category varchar(70) not null
);

CREATE TABLE gender
(
	gender_id int not null primary key,
	desc_gender char not null
);

CREATE TABLE roll
(
	roll_id int not null primary key,
	desc_roll varchar(20) not null
)

/* views */
CREATE VIEW vw_students 
AS
	SELECT s.id, s.username, s.surname, s.email, s.phone, s.password, g.desc_gender, r.desc_roll
	FROM students s
	INNER JOIN gender g ON (s.gender_id = g.gender_id)
	INNER JOIN roll r ON (s.roll_id = r.roll_id);

CREATE VIEW vw_professors 
AS
	SELECT p.id, p.username, p.surname, p.email, p.phone, p.password, g.desc_gender, r.desc_roll
	FROM professors p
	INNER JOIN gender g ON (p.gender_id = g.gender_id)
	INNER JOIN roll r ON (p.roll_id = r.roll_id);

CREATE VIEW vw_directors
AS
	SELECT d.id, d.username, d.surname, d.email, d.phone, d.password, g.desc_gender, r.desc_roll
	FROM directors d
	INNER JOIN gender g ON (d.gender_id = g.gender_id)
	INNER JOIN roll r ON (d.roll_id = r.roll_id);

/*CREATE VIEW vw_allsubjects
AS
	SELECT s.id, s.title, d.password, g.desc_gender, r.desc_roll
	FROM subjects s
	INNER JOIN gender g ON (d.gender_id = g.gender_id)
	INNER JOIN roll r ON (d.roll_id = r.roll_id);*/

/* Inserting Values into Directors */
INSERT INTO directors
VALUES('Onell Antonio', 'Dishmey Mena', 'Onelldish@hotmail.com', '+1 (809)-883-1449', HASHBYTES('SHA2_512', ''), 1, 3);

INSERT INTO professors
VALUES('Ramy Daniel', 'Campusano Vólquez', 'ramyc@hotmail.com', '+1 (809)-598-5566', HASHBYTES('SHA2_512', 'ramyc'), 1, 3);

INSERT INTO students
VALUES ('Ashley', 'Durán Alcantara', 'ADuran@hotmail.com', '+1 (809)-555-2222', HASHBYTES('SHA2_512', 'aduran1'), 1, 3),
	  ('Anna', 'Caba', 'ACaba@hotmail.com', '+1 (809)-555-2222', HASHBYTES('SHA2_512', 'acaba1'), 2, 3),
	  ('Armando', 'Casas', 'ACasas@hotmail.com', '+1 (809)-555-2222', HASHBYTES('SHA2_512', 'acasa1'), 1, 3)

/* Inserting values into subtables */
INSERT INTO subjects
VALUES('DATA MINING', 2, 'Software'),
	  ('ARTIFICIAL INTELLIGENCE', 3, 'Software'),
	  ('DEVELOPMENT INTRODUCTION', 1, 'Software'),
	  ('ILUSTRATOR INTRODUCTION', 4, 'Multimedia')

INSERT INTO gender
VALUES(1, 'M'), (2, 'F');

INSERT INTO roll
VALUES(1, 'Student'), (2, 'Professor'), (3, 'Director');

/* Select all */
SELECT * FROM directors;

/* Update */
UPDATE directors
SET password = HASHBYTES('SHA2_512', 'onelld')
WHERE id = 1;

UPDATE subjects
SET category = 'Software';

UPDATE professors
SET roll_id = 2;

/* Altering tables */
ALTER TABLE subjects
ADD student_id int default 0;

ALTER TABLE subjects
DROP student_id;
