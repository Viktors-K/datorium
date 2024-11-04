SELECT Sales.*, Procedures.Price
From Sales
Left join Procedures on Sales.ProcedureCode = Procedures.procedurecode