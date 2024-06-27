/* 
1.	Escriba un script SQL que realice las siguientes tareas:
•	Cree una base de datos llamada ContactDb y defina las tablas Contact y Appointment con las relaciones correspondientes.
•	Inserte al menos 5 registros en la tabla Contact y 5 registros en la tabla Appointment.
•	Cree procedimientos almacenados para agregar, actualizar y eliminar contactos.
•	Implemente un trigger que registre las actualizaciones en la tabla Contact.
•	Cree un índice en la columna LastName de la tabla Contact para mejorar el rendimiento de las consultas.


*/

CREATE DATABASE ContactDb;
USE ContactDb;

CREATE TABLE Contact (
    ContactID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    PhoneNumber VARCHAR(20)
);

CREATE TABLE Appointment (
    AppointmentID INT PRIMARY KEY,
    ContactID INT,
    AppointmentDate DATETIME,
    Description VARCHAR(255),
    FOREIGN KEY (ContactID) REFERENCES Contact(ContactID)
);
 
INSERT INTO Contact (ContactID, FirstName, LastName, Email, PhoneNumber)
VALUES 
    (1, 'John', 'Doe', 'john.doe@example.com', '123-456-7890'),
    (2, 'Jane', 'Smith', 'jane.smith@example.com', '987-654-3210'),
    (3, 'Alice', 'Johnson', 'alice.johnson@example.com', '555-123-4567'),
    (4, 'Bob', 'Brown', 'bob.brown@example.com', '555-765-4321'),
    (5, 'Charlie', 'Davis', 'charlie.davis@example.com', '555-987-6543');

INSERT INTO Appointment (AppointmentID, ContactID, AppointmentDate, Description)
VALUES
    (1, 1, '2024-06-01 09:00', 'Dentist Appointment'),
    (2, 2, '2024-06-02 10:00', 'Meeting with Client'),
    (3, 3, '2024-06-03 11:00', 'Lunch with Alice'),
    (4, 4, '2024-06-04 14:00', 'Project Presentation'),
    (5, 5, '2024-06-05 16:00', 'Gym Session');
 
CREATE PROCEDURE AddContact
    @ContactID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100),
    @PhoneNumber VARCHAR(20)
AS
BEGIN
    INSERT INTO Contact (ContactID, FirstName, LastName, Email, PhoneNumber)
    VALUES (@ContactID, @FirstName, @LastName, @Email, @PhoneNumber);
END;

CREATE PROCEDURE UpdateContact
    @ContactID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100),
    @PhoneNumber VARCHAR(20)
AS
BEGIN
    UPDATE Contact
    SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber
    WHERE ContactID = @ContactID;
END;

CREATE PROCEDURE DeleteContact
    @ContactID INT
AS
BEGIN
    DELETE FROM Contact
    WHERE ContactID = @ContactID;
END;



