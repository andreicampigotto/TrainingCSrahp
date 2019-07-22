ALTER TABLE Presenca
ADD CONSTRAINT UC_Presenca_Insert
UNIQUE (Diario)

-------------------------------------------------
CREATE UNIQUE INDEX UC_Presenca_Insert
ON Presenca(Diario, Aluno);