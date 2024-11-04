SELECT 
	Sales.Country, 
	SUM(Procedures.Price) AS SalesAmount,
	cOUNT(*) as SalesCount,
	SUM(Procedures.Price)/cOUNT(*) AS AveragePrice

From Sales
Left join Procedures on Sales.ProcedureCode = Procedures.procedurecode
Group by Country
order by SalesAmount Desc