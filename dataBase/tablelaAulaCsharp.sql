﻿INSERT INTO dbo.AulaCsharp 
(Aluno,Idade,Ativo,UsuInc,UsuAlt,DatInc,DatFin)
VALUES
('Andrei',24,1,2019002324,2019002324,GETDATE(),GETDATE()),
('Cristopher',26,1,2019002324,2019002324,GETDATE(),GETDATE()),
('Daniela',35,1,2019002324,2019002324,GETDATE(),GETDATE()),
('David',24,1,2019002324,2019002324,GETDATE(),GETDATE()),
('Isabella',23,0,2019002324,2019002324,GETDATE(),GETDATE());
GO
SELECT * FROM AulaCsharp