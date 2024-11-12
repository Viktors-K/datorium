# Learning SQLite
### Creating new table for Doctors

```SQL
DROP TABLE Doctors;

Create table Doctors (
  DoctorID INTEGER PRIMARY KEY AUTOINCREMENT,
  Name TEXT NOT NULL,
  Surname TEXT NOT NULL,
  Multiplier DECIMAL NOT NULL
 );
 ```
### Adding new values to the table and displaying them
```SQL
INSERT INTO Doctors (Name, Surname, Multiplier)
VALUES 
    ('Anna', 'Apse', 2),
    ('Oskars', 'Andersons', 0.5),
    ('Jenifere', 'Pottere', 3.2);
SELECT * FROM Doctors
 ```
