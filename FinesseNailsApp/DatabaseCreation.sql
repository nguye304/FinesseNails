USE kevindb;

CREATE TABLE Employees(
	 EmpID INTEGER(4),
     Name VARCHAR(25),
     Phone CHAR(12),
     Email VARCHAR(30),
     Gender CHAR(1),
     MgrID INTEGER(4),
     
     CONSTRAINT EmployeePK PRIMARY KEY(EmpID),
     CONSTRAINT EmployeeMgrFK FOREIGN KEY (MgrID)
		REFERENCES Employees(EmpID)
     );
     
     
     
     INSERT INTO Employees(EmpID,Name,Phone,Email,Gender)
     VALUES (1000,"Kevin Nguyen", "858-111-2222", "kevin.nguyen38@yahoo.com","M");     
     INSERT INTO Employees(EmpID,Name,Phone,Email,Gender)
     VALUES (1001,"Bebe Nguyen", "858-111-5467", "bebe.nguyen38@yahoo.com","F");
     INSERT INTO Employees(EmpID,Name,Phone,Email,Gender)
     VALUES (1002,"Ana Espiritu", "858-111-2123", "ana.nguyen38@yahoo.com","F");
     INSERT INTO Employees(EmpID,Name,Phone,Email,Gender)
     VALUES (1003,"Jose Reloj", "858-111-2345", "jr.nguyen38@yahoo.com","M");
     INSERT INTO Employees(EmpID,Name,Phone,Email,Gender)
     VALUES (1004,"Daniel Tran", "858-123-4567", "daniel.nguyen38@yahoo.com","M");
     
     UPDATE Employees
     SET MgrId = 1001
     WHERE EmpID=1000;
     
	 UPDATE Employees SET MgrId = 1002 WHERE EmpID=1001;
	 UPDATE Employees SET MgrId = 1000 WHERE EmpID=1002;
	 UPDATE Employees SET MgrId = 1004 WHERE EmpID=1003;
     UPDATE Employees SET MgrId = 1003 WHERE EmpID=1004;
 
	SELECT * FROM Employees;