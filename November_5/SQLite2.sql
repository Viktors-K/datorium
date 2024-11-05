WITH PetLeads AS (
    SELECT Pets.* 
    FROM Pets
    LEFT JOIN Sales ON Sales.PetID = Pets.PetID
    WHERE Sales.PetID IS NULL
)

SELECT PetLeads.*, Owners.Name AS OwnerName, Owners.Surname
FROM PetLeads
LEFT JOIN Owners ON Owners.OwnerID = PetLeads.OwnerID;