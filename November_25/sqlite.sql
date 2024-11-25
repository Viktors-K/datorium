DROP TABLE Kafejnicas;
CREATE TABLE Kafejnicas (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  nosaukums VARCHAR(32),
  adrese VARCHAR(100)
);

INSERT INTO Kafejnicas (nosaukums, adrese) VALUES
('Pie Jāna', 'Brīvības iela 10'),
('Pie Rimi', 'Kartupeļu iela 10'),
('Pie Origo', 'Graudu iela 10');

DROP TABLE Darbinieki;
CREATE TABLE Darbinieki (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  vards VARCHAR(32),
  uzvards VARCHAR(32),
  telefons CHAR(12),
  amats VARCHAR(32),
  kafejnica INTEGER,
  atvalinajums BOOLEAN,
  FOREIGN KEY (kafejnica) REFERENCES Kafejnicas(id)
);

INSERT INTO Darbinieki (vards, uzvards, telefons, amats, Kafejnica, atvalinajums)
VALUES
('Jānis', 'Bērziņs', '+37120000000', 'viesmīlis', 1, TRUE),
('V', 'Martin', '+37120000000', 'viesmīlis', 3, FALSE),
('Elchin', 'J', '+37120000000', 'boss', 2, TRUE);

DROP TABLE Pasutijumi;
CREATE TABLE Pasutijumi (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  summa REAL,
  datums DATE,
  apraksts VARCHAR(100),
  darbinieks INTEGER,
  FOREIGN KEY (darbinieks) REFERENCES Darbinieki(id)
);