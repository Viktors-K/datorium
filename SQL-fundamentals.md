# Learning SQLite

### Selecting data from a table

```SQL
SELECT * FROM pets;
SELECT pets.*;
```
### Creating a new value and grouping/sorting by it

```SQL
SELECT Country, Count(*) AS number_of_transactions
FROM Sales
GROUP BY Country
Order by number_of_transactions desc;
```
### Joining two tables together

```SQL
SELECT Sales.*, Procedures.Price
From Sales
LEFT JOIN Procedures on Sales.ProcedureCode = Procedures.procedurecode
```
### Calculating the average and joining to tables

```SQL
SELECT 
	Sales.Country, 
	SUM(Procedures.Price) AS SalesAmount,
	COUNT(*) as SalesCount,
	SUM(Procedures.Price)/COUNT(*) AS AveragePrice

FROM Sales
LEFT JOIN Procedures on Sales.ProcedureCode = Procedures.procedurecode
GROUP BY Country
ORDER BY SalesAmount DESC
```
### Joining more than two tables

```SQL
SELECT 
    Pets.PetID,
    Pets.Name AS PetName,
    Owners.OwnerID,
    Owners.Name AS OwnerName,
    Owners.Surname AS OwnerSurname,
    Owners.Zipcode
FROM Pets
LEFT JOIN Sales ON Pets.PetID = Sales.PetID
LEFT JOIN Owners ON Pets.OwnerID = Owners.OwnerID
WHERE Sales.PetID IS NULL;
```
### Using WITH to create a temporary table for searching

```SQL
WITH PetLeads AS (
    SELECT Pets.* 
    FROM Pets
    LEFT JOIN Sales ON Sales.PetID = Pets.PetID
    WHERE Sales.PetID IS NULL
)

SELECT PetLeads.*, Owners.Name AS OwnerName, Owners.Surname
FROM PetLeads
LEFT JOIN Owners ON Owners.OwnerID = PetLeads.OwnerID;
```
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
