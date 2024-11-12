# Learning SQLite
## Creating new table for Doctors

```SQL
DROP TABLE Doctors;

Create table Doctors (
  DoctorID INTEGER PRIMARY KEY AUTOINCREMENT,
  Name TEXT NOT NULL,
  Surname TEXT NOT NULL,
  Multiplier DECIMAL NOT NULL
 );
 ```
