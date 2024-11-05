SELECT 
    Pets.PetID,
    Pets.Name AS PetName,
    Owners.OwnerID,
    Owners.Name AS OwnerName,
    Owners.Surname AS OwnerSurname,
    Owners.Zipcode
FROM Pets
LEFT JOIN Sales ON Pets.PetID = Sales.PetID
Left JOIN Owners ON Pets.OwnerID = Owners.OwnerID
WHERE Sales.PetID IS NULL;