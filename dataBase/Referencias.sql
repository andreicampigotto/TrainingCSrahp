﻿//Select com inner join

SELECT
	LV.Id,
	LV.Nome_Livro,
	IIF(LV.Alocado = 1, 'Sim', 'Não') as 'Alocado',
	BL.Nome as 'Nome da Biblioteca'
FROM Biblioteca BL
inner join Livro LV on BL.Id = LV.Biblioteca
//////////////////////// OTA \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
SELECT
	BL.Nome,
	COUNT(LV.Id) AS 'Quantidade de Livros',
	US.Nome as 'UserName'
FROM Biblioteca BL
inner join Livro LV on BL.Id = LV.Biblioteca
inner join Usuario US on LV.UsuInc = US.Id
group by BL.Nome, Us.Nome

/////////////////////// GAMBIARRA \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

SELECT
	BL.Nome,
	(SELECT COUNT(*)
	FROM Livro LV
	WHERE LV.Biblioteca = BL.Id) AS 'Quantidade Livros'
FROM Biblioteca BL
