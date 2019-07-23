-- Marcas que só o felipe cadastrou:
SELECT 
		Nome as 'Marcas'
	FROM Marcas
WHERE UsuInc = 1;

-- Mascas que só o Giomar cadastrou:
SELECT 
		Nome as 'Marcas'
	FROM Marcas
WHERE UsuInc = 2;

-- Somente a quantidade de marcas que Felipe cadastrou do maior para menor:
SELECT 
		COUNT (*) as 'Número de marcas cadastradas por Felipe:'
	FROM Marcas
WHERE UsuInc = 1
ORDER BY COUNT (*) DESC;

-- Somente a quantidade de marcas que Giomar cadastrou do menor para maior:
SELECT 
		COUNT (*) as 'Número de marcas cadastradas por Giomar'
	FROM Marcas
WHERE UsuInc = 2
ORDER BY COUNT (*) ASC;

-- Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram: 
SELECT 
		COUNT (*) as 'Número de marcas cadastradas por Felipe e Giomar'
	FROM Marcas
ORDER BY COUNT (*) ASC;

-- Trazer somente os carros que Felipe cadastrou:
SELECT 
		Modelo as 'Carro'
	FROM Carros
WHERE UsuInc = 1;

-- Trazer somente os carros que Giomar cadastrou:
SELECT 
		Modelo as 'Carro'
	FROM Carros
WHERE UsuInc = 2;

--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor:
SELECT 
		COUNT (*) as 'Número de carros cadastradas por Felipe:'
	FROM Carros
WHERE UsuInc = 1
ORDER BY COUNT (*) DESC;

--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior:
SELECT 
		COUNT (*) as 'Número de carros cadastradas por Giomar:'
	FROM Carros
WHERE UsuInc =2
ORDER BY COUNT (*) ASC;

-- Trazer somente a quantidade de carros que Felipe e Giomar cadastraram:
SELECT 
		COUNT (*) as 'Número de Carros cadastradas por Felipe:'
	FROM Carros
ORDER BY COUNT (*) ASC;

--Trazer somente os carros das marcas que Felipe cadastrou:
SELECT 
		c.Modelo as 'Carro' 
	FROM  Carros c
	inner join Marcas m on c.Marca = m.Id
WHERE m.UsuInc = 1;

--Trazer somente os carros das marcas que Giomar cadastrou:
SELECT 
		c.Modelo as 'Carro' 
	FROM  Carros c
	inner join Marcas m on c.Marca = m.Id
WHERE m.UsuInc = 2;

--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
SELECT 
		COUNT(c.Modelo) AS 'Carros cadastrados por felipe:'
	FROM  Carros c
	inner join Marcas m on c.Marca = m.Id
WHERE m.UsuInc = 1
ORDER BY COUNT(c.Modelo) DESC;

--Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior:
SELECT 
		COUNT(c.Modelo) AS 'Carros cadastrados por Giomar:'
	FROM  Carros c
	inner join Marcas m on c.Marca = m.Id
WHERE m.UsuInc = 2
ORDER BY COUNT(c.Modelo) ASC;

--Trazer o valor total de vendas 2019 isolado:
SELECT 
		SUM(v.Valor * v.Quantidade) AS 'Valor total das vendas em 2019'
	FROM Vendas v
WHERE YEAR(v.DatInc) = 2019;

--Trazer a quantidade total de vendas 2019 isolado
SELECT 
		SUM(v.Quantidade) AS 'Vendas em 2019'
	FROM Vendas v

WHERE YEAR(v.DatInc) = 2019;

--Trazer o valor total de vendas em cada ano e ordernar do maior para o menor
SELECT 
		SUM(v.Valor * v.Quantidade) AS 'Valor total de vendas por ano',
		YEAR(v.DatInc) AS 'Ano'
	FROM Vendas v
GROUP BY YEAR(v.DatInc)
ORDER BY SUM(v.Valor * v.Quantidade) DESC;

--Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor
SELECT 
		SUM(v.Quantidade) AS 'Quantidade de vendas por ano',
		YEAR(v.DatInc) AS 'Ano'
	FROM Vendas v
GROUP BY YEAR(v.DatInc)
ORDER BY SUM(v.Quantidade) DESC;

--Trazer o mês de cada ano que retornou a maior quantidade de vendas
		-- Tradução "Retornar agrupado por mês e ordernar do maior para menor
SELECT 
		SUM(v.Quantidade) AS 'Maior quantidade de vendas por mês/ano',
		FORMAT(v.DatInc, 'MM-yyyy') AS 'Mês-Ano'  
	FROM Vendas v
GROUP BY FORMAT(v.DatInc, 'MM-yyyy')
ORDER BY SUM(v.Quantidade) DESC;

--Trazer o mês de cada ano que retornou o maior valor de vendas
		-- Tradução "Retornar agrupado por mês e ordernar do maior para menor"
SELECT 
		SUM(v.Quantidade * v.Valor) AS 'Valor total de vendas por mês/ano',
		FORMAT(v.DatInc, 'MM-yyyy') AS 'Mês-Ano'  
	FROM Vendas v
GROUP BY FORMAT(v.DatInc, 'MM-yyyy')
ORDER BY SUM(v.Quantidade * v.Valor) DESC;

-- Trazer o valor total de vendas que Felipe realizou
SELECT
		SUM(v.Quantidade * v.Valor) AS 'Valor total das vendas do Felipe'
	FROM Vendas v
WHERE UsuInc = 1;

--Trazer o valor total de vendas que Giomar realizou
SELECT
		SUM(v.Quantidade * v.Valor) AS 'Valor total das vendas do Giomar'
	FROM Vendas v
WHERE UsuInc = 2;

--Trazer a quantidade total de vendas que Felipe realizou
SELECT
		SUM(v.Quantidade) as 'Quantidade de vendas do felipe'
	FROM Vendas v
WHERE v.UsuInc = 1;

--Trazer a quantidade de vendas que Giomar realizou
SELECT
		SUM(v.Quantidade) as 'Quantidade de vendas do Giomar'
	FROM Vendas v
WHERE v.UsuInc = 2

-- Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
SELECT 
		SUM(v.Quantidade) as 'Quantidade total de vendas'
	FROM Vendas v
ORDER BY SUM(v.Quantidade) DESC;

--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
SELECT 
		SUM(v.Quantidade * v.Valor) as 'Valor total de vendas'
	FROM Vendas v
ORDER BY SUM(v.Quantidade) DESC;

--Trazer  a marca mais vendida de todos os anos
		-- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"
SELECT 
		m.Nome as 'Marca', 
		SUM(v.Quantidade) as 'Quantidade de vendas:'
	FROM Vendas v
INNER JOIN Carros c on v.Carro = c.Id
INNER JOIN Marcas m on c.Marca = m.Id
GROUP BY m.Nome
ORDER BY SUM(v.Quantidade) DESC, m.Nome;

--Trazer o valor total da marca mais vendida de todos os anos
SELECT 
		m.Nome as 'Marca', 
		SUM(v.Quantidade * v.Valor) as 'Valor total de vendas:'
	FROM Vendas v
INNER JOIN Carros c on v.Carro = c.Id
INNER JOIN Marcas m on c.Marca = m.Id
GROUP BY m.Nome
ORDER BY SUM(v.Quantidade * v.Valor) DESC, m.Nome;

--Trazer a quantidade do carro mais vendido de todos os anos
SELECT 
		c.Modelo as 'Marca', 
		SUM(v.Quantidade) as 'Carro mais vendido'
	FROM Vendas v
INNER JOIN Carros c on v.Carro = c.Id
GROUP BY c.Modelo
ORDER BY SUM(v.Quantidade) DESC, c.Modelo;

--Trazer o valor do carro mais vendido de todos os anos
SELECT 
		c.Modelo as 'Marca', 
		SUM(v.Quantidade * v.Valor) as 'Valor ganho por vendido'
	FROM Vendas v
INNER JOIN Carros c on v.Carro = c.Id
GROUP BY c.Modelo
ORDER BY SUM(v.Quantidade * v.Valor) DESC, c.Modelo;
