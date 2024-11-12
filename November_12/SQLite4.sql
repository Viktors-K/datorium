ALTER TABLE Doctors 
    ADD COLUMN NewMultiplier INTEGER;
UPDATE Doctors
    SET NewMultiplier = Multiplier * 100;
SELECT * FROM Doctors;