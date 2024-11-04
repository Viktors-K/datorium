SELECT Country, Count(*) AS number_of_transactions
FROM Sales
GROUP BY Country
Order by number_of_transactions desc;