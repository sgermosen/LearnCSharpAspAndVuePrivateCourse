/*
1.	Escriba un script SQL que realice las siguientes tareas:
o	Cree una tabla llamada Authors con las columnas AuthorID (llave primaria), FirstName y LastName.
o	Cree una tabla llamada Books con las columnas BookID (llave primaria), Title, PublicationYear y AuthorID (llave foránea que referencia a Authors).
o	Inserte al menos 3 registros en la tabla Authors.
o	Inserte al menos 3 registros en la tabla Books, asegurándose de que cada libro esté relacionado con un autor.
o	Actualice el apellido de uno de los autores
o	Elimine uno de los autores

*/
CREATE TABLE Authors (
    AuthorID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50)
);

CREATE TABLE Books (
    BookID INT PRIMARY KEY,
    Title NVARCHAR(100),
    PublicationYear INT,
    AuthorID INT,
    FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID)
);

INSERT INTO Authors (AuthorID, FirstName, LastName) VALUES (1, 'John', 'Doe');
INSERT INTO Authors (AuthorID, FirstName, LastName) VALUES (2, 'Jane', 'Smith');
INSERT INTO Authors (AuthorID, FirstName, LastName) VALUES (3, 'Emily', 'Johnson');

INSERT INTO Books (BookID, Title, PublicationYear, AuthorID) VALUES (1, 'C# Programming', 2020, 1);
INSERT INTO Books (BookID, Title, PublicationYear, AuthorID) VALUES (2, 'Database Design', 2019, 2);
INSERT INTO Books (BookID, Title, PublicationYear, AuthorID) VALUES (3, 'Advanced SQL', 2021, 3);
   
 
UPDATE Authors
SET LastName = 'Davis'
WHERE AuthorID = 2;

 
SELECT * FROM Authors;

 
DELETE FROM Authors
WHERE AuthorID = 3;

