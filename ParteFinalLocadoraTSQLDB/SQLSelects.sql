SELECT * 
	FROM Carros c
	INNER JOIN Locacao l on L.Id_Carro = c.Id;

SELECT
	c.Modelo,
	l.Id_Carro AS 'Carro',
	--l.Id_Cliente,
	COUNT(l.Id_Carro) as 'Quatidade de locação',
	YEAR(l.Data_Dev) as 'Ano'
FROM Locacao l 
	inner join Carros c on l.Id_Carro = c.Id
GROUP BY c.Modelo, l.Id_Carro, YEAR(l.Data_Dev)
ORDER BY COUNT(l.Id_Carro) desc;
-- SELECT COM COUNT POR ANO

SELECT
	c.Modelo,
	l.Id_Carro AS 'Carro',
	--l.Id_Cliente,
	COUNT(l.Id_Carro) as 'Quatidade de locação',
	MONTH(l.Data_Dev) as 'Mês'
FROM Locacao l 
	inner join Carros c on l.Id_Carro = c.Id
GROUP BY c.Modelo, l.Id_Carro, MONTH(l.Data_Dev)
ORDER BY MONTH(l.Data_Dev) ASC;
-- SELECT COM COUNT POR MÊS

SELECT
	c.Modelo,
	l.Id_Carro AS 'Carro',
	--l.Id_Cliente,
	COUNT(l.Id_Carro) as 'Quatidade de locação',
	YEAR(l.Data_Dev) as 'Ano'
FROM Locacao l 
	inner join Carros c on l.Id_Carro = c.Id
GROUP BY c.Modelo, l.Id_Carro, YEAR(l.Data_Dev)
ORDER BY COUNT(l.Id_Carro) desc;
-- SELECT COM CARRO MAIS LOCADO NO ANO

