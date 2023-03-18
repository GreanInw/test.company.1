With TableSales As 
(
	Select * From (Values('A', 15), ('B', 35), ('C', 25), ('D', 10), ('E', 15)) As Sales(Name, TotalSales)
)
Select *, ROW_NUMBER() Over(Order By TotalSales desc) As [Rank]
From TableSales;



