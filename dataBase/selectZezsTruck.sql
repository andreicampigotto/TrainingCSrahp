SELECT * FROM (SELECT
	Tipo_Dog as 'Tipo do Dog',
	SUM(Total_Vendas) as 'Vendas',
	MONTH(Data_Venda) as 'Mês'
FROM Zezs_Truck
GROUP BY Tipo_Dog, MONTH(Data_Venda)) TabelaXGH
ORDER BY TabelaXGH.[Vendas] desc