/* Run this first if you are creatigna database the first time.

CREATE DATABASE `samsjacksonville`;

**Run this to user to databse app uses

GRANT USAGE ON samsjacksonville.* TO 'KIPPDemo'@'localhost'IDENTIFIED BY 'KIPPDemo';
GRANT select,execute,insert,update,delete ON samsjacksonville.* TO 'KIPPDemo'@'localhost'IDENTIFIED BY'KIPPDemo';

*/


/* Students */
DROP TABLE student;

CREATE TABLE `student` (
  `StudentId` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(45) NOT NULL,
  `MiddleName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) NOT NULL,
  PRIMARY KEY (`StudentId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

ALTER TABLE student AUTO_INCREMENT = 0;


INSERT INTO `samsjacksonville`.`student`(`FirstName`,`MiddleName`,`LastName`)VALUES('Jackie',	'J',	'Jack');
INSERT INTO `samsjacksonville`.`student`(`FirstName`,`MiddleName`,`LastName`)VALUES('Tommy',	'T',	'Tom');
INSERT INTO `samsjacksonville`.`student`(`FirstName`,`MiddleName`,`LastName`)VALUES('Mikey',	'M',	'Mike');
INSERT INTO `samsjacksonville`.`student`(`FirstName`,`MiddleName`,`LastName`)VALUES('Billy',	'B'	,'Bill');
INSERT INTO `samsjacksonville`.`student`(`FirstName`,`MiddleName`,`LastName`)VALUES('Nicky',	'N',	'Nick');
INSERT INTO `samsjacksonville`.`student`(`FirstName`,`MiddleName`,`LastName`)VALUES('Nickie',	'N',	'Nick');
INSERT INTO `samsjacksonville`.`student`(`FirstName`,`MiddleName`,`LastName`)VALUES('Frankie',	'F',	'Frank');

/*Profiles*/
DROP TABLE profile;

CREATE TABLE `profile` (
  `ProfileId` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(45) NOT NULL,
  `MiddleName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) NOT NULL,
  `Password` char(9) NOT NULL,
  `UserID` char(9) NOT NULL,
  PRIMARY KEY (`ProfileId`,`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

ALTER TABLE profile AUTO_INCREMENT = 0;

INSERT INTO `samsjacksonville`.`profile`(`FirstName`,`MiddleName`,`LastName`,`Password`,`UserID`)VALUES('TIM','E','Harrison','Tim','Timmy');

