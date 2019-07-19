SELECT 
	Nome,
	Materia,

	(( Nota1 + Nota2 + Nota3 + Nota4 + Nota5 + Nota6) / 6 ) AS 'Média',
	IIF((( Nota1 + Nota2 + Nota3 + Nota4 + Nota5 + Nota6) / 6 ) >= 5, 'Aprovado', 'Reprovado') AS 'Status'
FROM Diario1