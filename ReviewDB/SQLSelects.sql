SELECT 
		tr.Nome as 'Turma',
		a.Aluno
	FROM Turmas tr
			inner join TurmaAlunos ta ON tr.Id = ta.Turma 
			inner join Alunos a ON ta.Aluno = a.Id
			left join Diarios d ON tr.Id = d.Id;
			--Tras todos os alunos da turma

SELECT 
		d.[Data],
		a.Aluno,
		n.Nota
	FROM Diarios d 
		inner join Turmas t on d.Turma = t.Id
		inner join TurmaAlunos tr on t.Id = tr.Turma
		inner join Alunos a on tr.Aluno =  a.Id
		left join Notas n on tr.Aluno = n.Aluno
		--Versão Lógica

SELECT 
		d.[Data],
		tr.Aluno,
		--a.Aluno,
		--SUM(n.Nota) as 'Média',
		n.Nota as 'Média',
		IIF(COUNT(p.Id) = 1, 'Presente', 'Ausente') as 'Presenças'
		--IIF(ISNULL(p.Id,0) > 0, 'Presente', 'Ausente') as 'Presença'
		--NULLIF(p.Id,1) as 'Presenças'
	FROM Diarios d 
		inner join TurmaAlunos tr on d.Turma = tr.Turma
		--inner join Turmas t on tr.Turma = t.Id
		--inner join Alunos a on tr.Aluno =  a.Id
		left  join Presenca p  on d.Id = p.Diario and tr.Aluno = p.Aluno
		left  join Notas n on tr.Aluno = n.Aluno and d.Id = n.Diario
	GROUP BY d.[Data],tr.Aluno, n.Nota
		--Versão Felipe

SELECT 
		a.Aluno,
		SUM(n.Nota) / COUNT (n.[Data]) as 'Média'
	FROM Alunos a 
		inner join TurmaAlunos tr on a.Id = tr.Aluno
		inner join Diarios d on tr.Turma = d.Turma
		left join Notas n on d.Id = n.Diario and a.Id = n.Aluno
WHERE tr.Turma = 1
GROUP BY a.Aluno