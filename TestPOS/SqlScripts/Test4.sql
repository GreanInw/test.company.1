With TableSales As 
(
	Select * From (Values('A', 20), ('B', 30), ('C', 25), ('D', 10), ('E', 15)) As Sales(Name, TotalSales)
)
Select *, SUM(TotalSales) Over(Order by TotalSales desc) Accumulate 
From TableSales