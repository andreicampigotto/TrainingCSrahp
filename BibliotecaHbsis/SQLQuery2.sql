﻿--Executar somente a linha 2 por primeiro--
create database BibliotecaHbsis;
--Executar somente a linha 4 por segundo--
use BibliotecaHbsis;
--Executar da linha 6 em diante na ordem que consta por último--
create table Usuarios
(
	[Id] int not null primary key identity(0,1),
	[Nome] varchar(64) not null,
	[Login] varchar(32) not null,
	[Senha] varchar (16) not null,
	[Ativo] bit not null,
	[IdCriacao] int not null,
	[IdAlteracao] int null,
	[DataCriacao] datetime not null default current_timestamp,
	[DataAlteracao] datetime null
);

insert into Usuarios
	(Nome, [Login], Senha, Ativo, IdCriacao)
		values
			('admin', 'admin', 'admin', 1, 0);

create table Generos
(
	[Id] int not null primary key identity(0,1),
	[Nome] varchar(64) not null,
	[Descricao] varchar(512) not null,
	[Ativo] bit not null,
	[IdCriacao] int not null,
	[IdAlteracao] int null,
	[DataCriacao] datetime not null default current_timestamp,
	[DataAlteracao] datetime null,
		constraint FK_Genero_UsuarioCriacao
			foreign key (IdCriacao)
			references Usuarios (Id),
		constraint FK_Genero_UsuarioAlteracao
			foreign key (IdAlteracao)
			references Usuarios (Id)
);

insert into Generos
	(Nome, Descricao, Ativo, IdCriacao)
		values
			('Ficção', 'Livros com conteúdo sobre ficção.', 1, 0),
			('Não Ficção', 'Livros com conteúdo sobre não ficção.', 1, 0),
			('Autoajuda', 'Livros com conteúdo sobre autoajuda.', 1, 0),
			('Infantojuvenil', 'Livros com conteúdo sobre infantojuvenil.', 1, 0),
			('Negócios', 'Livros com conteúdo sobre negócios.', 1, 0);

create table Editoras
(
	[Id] int not null primary key identity(0,1),
	[Nome] varchar(64) not null,
	[Descricao] varchar(512) not null,
	[Ativo] bit not null,
	[IdCriacao] int not null,
	[IdAlteracao] int null,
	[DataCriacao] datetime not null default current_timestamp,
	[DataAlteracao] datetime null,
		constraint FK_Editora_UsuarioCriacao
			foreign key (IdCriacao)
			references Usuarios (Id),
		constraint FK_Editora_UsuarioAlteracao
			foreign key (IdAlteracao)
			references Usuarios (Id)
);

insert into Editoras
	(Nome, Descricao, Ativo, IdCriacao)
		values
			('HarperCollins', 'Livros com conteúdo autoral de HarperCollins.', 1, 0),
			('Sextante', 'Livros com conteúdo autoral de Sextante.', 1, 0),
			('Globo Alt', 'Livros com conteúdo autoral de Globo Alt.', 1, 0),
			('Faro Editorial', 'Livros com conteúdo autoral de Faro Editorial.', 1, 0),
			('Rocco', 'Livros com conteúdo autoral de Rocco.', 1, 0),
			('Companhia das Letras', 'Livros com conteúdo autoral de Companhia das Letras.', 1, 0),
			('Intrínseca', 'Livros com conteúdo autoral de Intrínseca.', 1, 0),
			('Novo Século', 'Livros com conteúdo autoral de Novo Século.', 1, 0),
			('Pandorga', 'Livros com conteúdo autoral de Pandorga.', 1, 0),
			('Suma de Letras', 'Livros com conteúdo autoral de Suma de Letras.', 1, 0),
			('Arqueiro', 'Livros com conteúdo autoral de Arqueiro.', 1, 0),
			('Objetiva', 'Livros com conteúdo autoral de Objetiva.', 1, 0),
			('L&PM', 'Livros com conteúdo autoral de L&PM.', 1, 0),
			('BestSeller', 'Livros com conteúdo autoral de BestSeller.', 1, 0),
			('Planeta do Brasil', 'Livros com conteúdo autoral de Planeta do Brasil.', 1, 0),
			('Agir', 'Livros com conteúdo autoral de Agir.', 1, 0),
			('Record', 'Livros com conteúdo autoral de Record.', 1, 0),
			('Estação Brasil', 'Livros com conteúdo autoral de Estação Brasil.', 1, 0),
			('L&PM POCKET', 'Livros com conteúdo autoral de L&PM POCKET.', 1, 0),
			('Zahar', 'Livros com conteúdo autoral de Zahar.', 1, 0),
			('Petra', 'Livros com conteúdo autoral de Petra.', 1, 0),
			('CDG', 'Livros com conteúdo autoral de CDG.', 1, 0),
			('Vozes', 'Livros com conteúdo autoral de Vozes.', 1, 0),
			('Buzz', 'Livros com conteúdo autoral de Buzz.', 1, 0),
			('Saraiva', 'Livros com conteúdo autoral de Saraiva.', 1, 0),
			('Companhia Editora Nacional', 'Livros com conteúdo autoral de Companhia Editora Nacional.', 1, 0),
			('Citadel', 'Livros com conteúdo autoral de Citadel.', 1, 0),
			('Pixel', 'Livros com conteúdo autoral de Pixel.', 1, 0),
			('Universo dos Livros', 'Livros com conteúdo autoral de Universo dos Livros.', 1, 0),
			('VR Editora', 'Livros com conteúdo autoral de VR Editora.', 1, 0),
			('Ciranda Cultural', 'Livros com conteúdo autoral de Ciranda Cultural.', 1, 0),
			('Gente', 'Livros com conteúdo autoral de Gente.', 1, 0),
			('Astral Cultural', 'Livros com conteúdo autoral de Astral Cultural.', 1, 0),
			('Cia das Letrinhas', 'Livros com conteúdo autoral de Cia das Letrinhas.', 1, 0),
			('Alta Books Editora', 'Livros com conteúdo autoral de Alta Books Editora.', 1, 0);

create table Autores
(
	[Id] int not null primary key identity(0,1),
	[Nome] varchar(64) not null,
	[Descricao] varchar(512) not null,
	[Ativo] bit not null,
	[IdCriacao] int not null,
	[IdAlteracao] int null,
	[DataCriacao] datetime not null default current_timestamp,
	[DataAlteracao] datetime null,
		constraint FK_Autor_UsuarioCriacao
			foreign key (IdCriacao)
			references Usuarios (Id),
		constraint FK_Autor_UsuarioAlteracao
			foreign key (IdAlteracao)
			references Usuarios (Id)
);

insert into Autores
	(Nome, Descricao, Ativo, IdCriacao)
		values
			('Augusto Cury', 'Livros com conteúdo autoral de Augusto Cury.', 1, 0),
			('Bráulio Bessa', 'Livros com conteúdo autoral de Bráulio Bessa.', 1, 0),
			('Igor Pires da Silva', 'Livros com conteúdo autoral de Igor Pires da Silva.', 1, 0),
			('Gabriela Barreira', 'Livros com conteúdo autoral de Gabriela Barreira.', 1, 0),
			('Charlie Donlea', 'Livros com conteúdo autoral de Charlie Donlea.', 1, 0),
			('Margaret Atwood', 'Livros com conteúdo autoral de Margaret Atwood.', 1, 0),
			('Igor Pires', 'Livros com conteúdo autoral de Igor Pires.', 1, 0),
			('Leticia Nazareth', 'Livros com conteúdo autoral de Leticia Nazareth.', 1, 0),
			('Malu Moreira', 'Livros com conteúdo autoral de Malu Moreira.', 1, 0),
			('George Orwell', 'Livros com conteúdo autoral de George Orwell.', 1, 0),
			('C. J. Tudor', 'Livros com conteúdo autoral de C. J. Tudor.', 1, 0),
			('Jojo Moyes', 'Livros com conteúdo autoral de Jojo Moyes.', 1, 0),
			('Rainbow Rowell', 'Livros com conteúdo autoral de Rainbow Rowell.', 1, 0),
			('Josh Malerman', 'Livros com conteúdo autoral de Josh Malerman.', 1, 0),
			('H.P. Lovecraft', 'Livros com conteúdo autoral de H.P. Lovecraft.', 1, 0),
			('George R. R. Martin', 'Livros com conteúdo autoral de George R. R. Martin.', 1, 0),
			('Neil Gaiman', 'Livros com conteúdo autoral de Neil Gaiman.', 1, 0),
			('Lucinda Riley', 'Livros com conteúdo autoral de Lucinda Riley.', 1, 0),
			('Nicholas Sparks', 'Livros com conteúdo autoral de Nicholas Sparks.', 1, 0),
			('E. L. James', 'Livros com conteúdo autoral de E. L. James.', 1, 0),
			('Michelle Obama', 'Livros com conteúdo autoral de Michelle Obama.', 1, 0),
			('Yuval Noah Harari', 'Livros com conteúdo autoral de Yuval Noah Harari.', 1, 0),
			('Gisele Bündchen', 'Livros com conteúdo autoral de Gisele Bündchen.', 1, 0),
			('Carol Dweck', 'Livros com conteúdo autoral de Carol Dweck.', 1, 0),
			('Stephen Hawking', 'Livros com conteúdo autoral de Stephen Hawking.', 1, 0),
			('Leandro Karnal', 'Livros com conteúdo autoral de Leandro Karnal.', 1, 0),
			('Clarissa Pinkola Estes', 'Livros com conteúdo autoral de Clarissa Pinkola Estes.', 1, 0),
			('Leo Dias', 'Livros com conteúdo autoral de Leo Dias.', 1, 0),
			('Mario Sergio Cortella', 'Livros com conteúdo autoral de Mario Sergio Cortella.', 1, 0),
			('Mirjam Pressler', 'Livros com conteúdo autoral de Mirjam Pressler.', 1, 0),
			('Otto H. Frank', 'Livros com conteúdo autoral de Otto H. Frank.', 1, 0),
			('Jessé Souza', 'Livros com conteúdo autoral de Jessé Souza.', 1, 0),
			('Johanna Basford', 'Livros com conteúdo autoral de Johanna Basford.', 1, 0),
			('Millie Marotta', 'Livros com conteúdo autoral de Millie Marotta.', 1, 0),
			('Olavo de Carvalho', 'Livros com conteúdo autoral de Olavo de Carvalho.', 1, 0),
			('Lilia Moritz Schwarcz', 'Livros com conteúdo autoral de Lilia Moritz Schwarcz.', 1, 0),
			('Daniel Ziblatt', 'Livros com conteúdo autoral de Daniel Ziblatt.', 1, 0),
			('Steven Levitsky', 'Livros com conteúdo autoral de Steven Levitsky.', 1, 0),
			('Mark Manson', 'Livros com conteúdo autoral de Mark Manson.', 1, 0),
			('Hal Elrod', 'Livros com conteúdo autoral de Hal Elrod.', 1, 0),
			('Padre Reginaldo Manzotti', 'Livros com conteúdo autoral de Padre Reginaldo Manzotti.', 1, 0),
			('Charles Duhigg', 'Livros com conteúdo autoral de Charles Duhigg.', 1, 0),
			('Napoleon Hill', 'Livros com conteúdo autoral de Napoleon Hill.', 1, 0),
			('Eckhart Tolle', 'Livros com conteúdo autoral de Eckhart Tolle.', 1, 0),
			('C. Torres Pastorino', 'Livros com conteúdo autoral de C. Torres Pastorino.', 1, 0),
			('Pe. Fábio de Melo', 'Livros com conteúdo autoral de Pe. Fábio de Melo.', 1, 0),
			('Adriana Santanna', 'Livros com conteúdo autoral de Adriana Santanna.', 1, 0),
			('Dale Carnegie', 'Livros com conteúdo autoral de Dale Carnegie.', 1, 0),
			('Ana Claudia Quintana Arantes', 'Livros com conteúdo autoral de Ana Claudia Quintana Arantes.', 1, 0),
			('Brené Brown', 'Livros com conteúdo autoral de Brené Brown.', 1, 0),
			('Baltasar Gracián', 'Livros com conteúdo autoral de Baltasar Gracián.', 1, 0),
			('Ricardo Bellino', 'Livros com conteúdo autoral de Ricardo Bellino.', 1, 0),
			('Rick Chesther', 'Livros com conteúdo autoral de Rick Chesther.', 1, 0),
			('Andréa Fernanda Morais', 'Livros com conteúdo autoral de Andréa Fernanda Morais.', 1, 0),
			('Luccas Neto', 'Livros com conteúdo autoral de Luccas Neto.', 1, 0),
			('Alex Hirsch', 'Livros com conteúdo autoral de Alex Hirsch.', 1, 0),
			('Rachael Lippincott', 'Livros com conteúdo autoral de Rachael Lippincott.', 1, 0),
			('Mikki Daughtry', 'Livros com conteúdo autoral de Mikki Daughtry.', 1, 0),
			('Tobias Laconis', 'Livros com conteúdo autoral de Tobias Laconis.', 1, 0),
			('Jenny Han', 'Livros com conteúdo autoral de Jenny Han.', 1, 0),
			('Jeff Kinney', 'Livros com conteúdo autoral de Jeff Kinney.', 1, 0),
			('Felipe Neto', 'Livros com conteúdo autoral de Felipe Neto.', 1, 0),
			('Ciranda Cultural', 'Livros com conteúdo autoral de Ciranda Cultural.', 1, 0),
			('R. J. Palacio', 'Livros com conteúdo autoral de R. J. Palacio.', 1, 0),
			('Paulo Vieira', 'Livros com conteúdo autoral de Paulo Vieira.', 1, 0),
			('Mauricio de Sousa', 'Livros com conteúdo autoral de Mauricio de Sousa.', 1, 0),
			('J. K. Rowling', 'Livros com conteúdo autoral de J. K. Rowling.', 1, 0),
			('Antoine Saint-Exupéry', 'Livros com conteúdo autoral de Antoine Saint-Exupéry.', 1, 0),
			('Melissa e Nicole', 'Livros com conteúdo autoral de Melissa e Nicole.', 1, 0),
			('Adriana Carranca', 'Livros com conteúdo autoral de Adriana Carranca.', 1, 0),
			('Caio Carneiro', 'Livros com conteúdo autoral de Caio Carneiro.', 1, 0),
			('Nathalia Arcuri', 'Livros com conteúdo autoral de Nathalia Arcuri.', 1, 0),
			('Thiago Nigro', 'Livros com conteúdo autoral de Thiago Nigro.', 1, 0),
			('T. Harv Eker', 'Livros com conteúdo autoral de T. Harv Eker.', 1, 0),
			('Robert T. Kiyosak', 'Livros com conteúdo autoral de Robert T. Kiyosak.', 1, 0),
			('Flávio Augusto da Silva', 'Livros com conteúdo autoral de Flávio Augusto da Silva.', 1, 0),
			('Gustavo Cerbasi', 'Livros com conteúdo autoral de Gustavo Cerbasi.', 1, 0),
			('Robert B. Cialdini', 'Livros com conteúdo autoral de Robert B. Cialdini.', 1, 0),
			('Elainne Ourives', 'Livros com conteúdo autoral de Elainne Ourives.', 1, 0),
			('James Hunter', 'Livros com conteúdo autoral de James Hunter.', 1, 0),
			('Deibson Silva', 'Livros com conteúdo autoral de Deibson Silva.', 1, 0),
			('Daniel Kahneman', 'Livros com conteúdo autoral de Daniel Kahneman.', 1, 0),
			('Stephen Covey', 'Livros com conteúdo autoral de Stephen Covey.', 1, 0);

create table Livros
(
	[Id] int not null primary key identity(0,1),
	[Nome] varchar(128) not null,
	[Descricao] varchar(1024) not null,
	[Isbn] varchar(17) not null,
	[Genero] int not null,
	[Editora] int not null,
	[Ativo] bit not null,
	[IdCriacao] int not null,
	[IdAlteracao] int null,
	[DataCriacao] datetime not null default current_timestamp,
	[DataAlteracao] datetime null,
		constraint FK_Livro_Genero
			foreign key (Genero)
			references Generos (Id),
		constraint FK_Livro_Editora
			foreign key (Editora)
			references Editoras (Id),
		constraint FK_Livro_UsuarioCriacao
			foreign key (IdCriacao)
			references Usuarios (Id),
		constraint FK_Livro_UsuarioAlteracao
			foreign key (IdAlteracao)
			references Usuarios (Id)
);

insert into Livros
	(Nome, Descricao, Isbn, Genero, Editora, Ativo, IdCriacao)
		values
			('Prisioneiros da mente', 'Nenhuma descrição disponível...', '978-85-95084-29-2', 0, 0, 1, 0),
			('Poesia que transforma', 'Nenhuma descrição disponível...', '978-85-43105-75-8', 0, 1, 1, 0),
			('Textos cruéis demais para serem lidos rapidamente', 'Nenhuma descrição disponível...', '978-85-25065-36-0', 0, 2, 1, 0),
			('A garota do lago', 'Nenhuma descrição disponível...', '978-85-62409-88-2', 0, 3, 1, 0),
			('O conto da Aia', 'Nenhuma descrição disponível...', '978-85-32520-66-1', 0, 4, 1, 0),
			('Textos cruéis demais para serem lidos rapidamente: Onde dorme o amor', 'Nenhuma descrição disponível...', '978-85-25066-65-7', 0, 2, 1, 0),
			('A revolução dos bichos', 'Nenhuma descrição disponível...', '978-85-35909-55-5', 0, 5, 1, 0),
			('O homem de giz', 'Nenhuma descrição disponível...', '978-85-51002-93-3', 0, 6, 1, 0),
			('O homem mais inteligente da história', 'Nenhuma descrição disponível...', '978-85-43104-35-5', 0, 1, 1, 0),
			('1984', 'Nenhuma descrição disponível...', '978-85-35914-84-9', 0, 5, 1, 0),
			('Ainda sou eu', 'Nenhuma descrição disponível...', '978-85-51002-81-0', 0, 6, 1, 0),
			('Eleanor & Park', 'Nenhuma descrição disponível...', '978-85-42810-39-4', 0, 7, 1, 0),
			('Caixa de pássaros', 'Nenhuma descrição disponível...', '978-85-80576-52-8', 0, 6, 1, 0),
			('H. P. Lovecraft : Os melhores contos', 'Nenhuma descrição disponível...', '978-85-84422-82-1', 0, 8, 1, 0),
			('Fogo & sangue', 'Nenhuma descrição disponível...', '978-85-56510-76-1', 0, 9, 1, 0),
			('Mitologia nórdica', 'Nenhuma descrição disponível...', '978-85-51001-28-8', 0, 6, 1, 0),
			('O homem mais feliz da história', 'Nenhuma descrição disponível...', '978-85-43105-27-7', 0, 1, 1, 0),
			('A carta secreta', 'Nenhuma descrição disponível...', '978-85-80419-40-5', 0, 10, 1, 0),
			('Almas gêmeas', 'Nenhuma descrição disponível...', '978-85-80418-63-7', 0, 10, 1, 0),
			('Mister', 'Nenhuma descrição disponível...', '978-85-51005-15-6', 0, 6, 1, 0),
			('Minha história', 'Nenhuma descrição disponível...', '978-85-47000-64-6', 1, 11, 1, 0),
			('Sapiens', 'Nenhuma descrição disponível...', '978-85-25432-18-6', 1, 12, 1, 0),
			('Aprendizados', 'Nenhuma descrição disponível...', '978-85-46501-27-4', 1, 13, 1, 0),
			('Mindset', 'Nenhuma descrição disponível...', '978-85-47000-24-0', 1, 11, 1, 0),
			('21 lições para o século 21', 'Nenhuma descrição disponível...', '978-85-35930-91-7', 1, 5, 1, 0),
			('Breves respostas para grandes questões', 'Nenhuma descrição disponível...', '978-85-51004-31-9', 1, 6, 1, 0),
			('O dilema do porco-espinho', 'Nenhuma descrição disponível...', '978-85-42214-36-9', 1, 14, 1, 0),
			('Mulheres que correm com os lobos (capa dura)', 'Nenhuma descrição disponível...', '978-85-32529-78-7', 1, 4, 1, 0),
			('Homo Deus', 'Nenhuma descrição disponível...', '978-85-35928-19-8', 1, 5, 1, 0),
			('Furacão Anitta', 'Nenhuma descrição disponível...', '978-85-22001-84-2', 1, 15, 1, 0),
			('Box - Mario Sergio Cortella', 'Nenhuma descrição disponível...', '978-85-42212-11-2', 1, 14, 1, 0),
			('O diário de Anne Frank', 'Nenhuma descrição disponível...', '978-85-01044-45-7', 1, 16, 1, 0),
			('A elite do atraso: Da escravidão a Bolsonaro', 'Nenhuma descrição disponível...', '978-85-56080-42-4', 1, 17, 1, 0),
			('Coleção Livros de Colorir', 'Nenhuma descrição disponível...', '978-85-43103-54-9', 1, 1, 1, 0),
			('O mínimo que você precisa saber para não ser um idiota', 'Nenhuma descrição disponível...', '978-85-01402-51-6', 1, 16, 1, 0),
			('Sobre o autoritarismo brasileiro', 'Nenhuma descrição disponível...', '978-85-35932-19-5', 1, 5, 1, 0),
			('Sapiens ( edição de bolso)', 'Nenhuma descrição disponível...', '978-85-25434-61-6', 1, 18, 1, 0),
			('Como as democracias morrem', 'Nenhuma descrição disponível...', '978-85-37818-00-8', 1, 19, 1, 0),
			('A sutil arte de ligar o foda-se', 'Nenhuma descrição disponível...', '978-85-51002-49-0', 2, 6, 1, 0),
			('O milagre da manhã', 'Nenhuma descrição disponível...', '978-85-76849-94-0', 2, 13, 1, 0),
			('O poder oculto', 'Nenhuma descrição disponível...', '978-85-82781-52-4', 2, 20, 1, 0),
			('O poder do hábito', 'Nenhuma descrição disponível...', '978-85-39004-11-9', 2, 11, 1, 0),
			('Mais esperto que o diabo', 'Nenhuma descrição disponível...', '978-85-68014-00-4', 2, 21, 1, 0),
			('O poder do agora', 'Nenhuma descrição disponível...', '978-85-75420-27-0', 2, 1, 1, 0),
			('F*deu geral', 'Nenhuma descrição disponível...', '978-85-51004-90-6', 2, 6, 1, 0),
			('Minutos de sabedoria', 'Nenhuma descrição disponível...', '978-85-32604-91-0', 2, 22, 1, 0),
			('Por onde for o teu passo, que lá esteja o teu coração', 'Nenhuma descrição disponível...', '978-85-42215-49-6', 2, 14, 1, 0),
			('Nunca foi sorte', 'Nenhuma descrição disponível...', '978-85-93156-95-3', 2, 23, 1, 0),
			('Ansiedade - Como enfrentar o mal do século', 'Nenhuma descrição disponível...', '978-85-02218-48-2', 2, 24, 1, 0),
			('Como fazer amigos e influenciar pessoas', 'Nenhuma descrição disponível...', '978-85-04018-02-8', 2, 25, 1, 0),
			('A morte é um dia que vale a pena viver', 'Nenhuma descrição disponível...', '978-85-43107-20-2', 2, 1, 1, 0),
			('A coragem de ser imperfeito', 'Nenhuma descrição disponível...', '978-85-43104-33-1', 2, 1, 1, 0),
			('A arte da sabedoria', 'Nenhuma descrição disponível...', '978-85-95810-34-1', 2, 3, 1, 0),
			('Ninguém é f#dido por acaso', 'Nenhuma descrição disponível...', '978-85-68014-82-0', 2, 26, 1, 0),
			('O milagre da manhã - Diário', 'Nenhuma descrição disponível...', '978-85-46500-85-7', 2, 13, 1, 0),
			('Pega a visão', 'Nenhuma descrição disponível...', '978-85-93156-72-4', 2, 23, 1, 0),
			('Por que fazemos o que fazemos?', 'Nenhuma descrição disponível...', '978-85-42207-41-5', 2, 14, 1, 0),
			('Tamo junto', 'Nenhuma descrição disponível...', '978-85-93156-82-3', 2, 23, 1, 0),
			('As aventuras na Netoland com Luccas Neto', 'Nenhuma descrição disponível...', '978-85-55461-00-2', 3, 27, 1, 0),
			('Brincando com Luccas Neto', 'Nenhuma descrição disponível...', '978-85-55461-76-7', 3, 27, 1, 0),
			('O diário perdido de Gravity Falls', 'Nenhuma descrição disponível...', '978-85-50303-62-8', 3, 28, 1, 0),
			('A cinco passos de você', 'Nenhuma descrição disponível...', '978-85-25067-42-5', 3, 2, 1, 0),
			('Para todos os garotos que já amei', 'Nenhuma descrição disponível...', '978-85-80577-26-6', 3, 6, 1, 0),
			('Diário de um banana - Batalha Neval', 'Nenhuma descrição disponível...', '978-85-50702-47-6', 3, 29, 1, 0),
			('P.S.: Ainda amo você', 'Nenhuma descrição disponível...', '978-85-80578-69-0', 3, 6, 1, 0),
			('Agora e para sempre, Lara Jean', 'Nenhuma descrição disponível...', '978-85-51001-98-1', 3, 6, 1, 0),
			('Felipe Neto - A vida por trás das câmeras', 'Nenhuma descrição disponível...', '978-85-55461-01-9', 3, 27, 1, 0),
			('Meu diário mágico', 'Nenhuma descrição disponível...', '978-85-38066-47-7', 3, 30, 1, 0),
			('Extraordinário', 'Nenhuma descrição disponível...', '978-85-80573-01-5', 3, 6, 1, 0),
			('O poder da ação para crianças', 'Nenhuma descrição disponível...', '978-85-45202-66-0', 3, 31, 1, 0),
			('Harry Potter e a pedra filosofal (capa dura)', 'Nenhuma descrição disponível...', '978-85-32530-78-3', 3, 4, 1, 0),
			('Pique-esconde com Luccas Neto', 'Nenhuma descrição disponível...', '978-85-55461-91-0', 3, 27, 1, 0),
			('O pequeno príncipe', 'Nenhuma descrição disponível...', '978-85-95081-51-2', 3, 0, 1, 0),
			('Coisas de menino', 'Nenhuma descrição disponível...', '978-85-38060-51-2', 3, 30, 1, 0),
			('Planeta das gêmeas - A diversão é aqui', 'Nenhuma descrição disponível...', '978-85-82466-82-7', 3, 32, 1, 0),
			('Diário de um banana - Edição comemorativa', 'Nenhuma descrição disponível...', '978-85-50701-84-4', 3, 29, 1, 0),
			('Malala, a menina que queria ir para a escola', 'Nenhuma descrição disponível...', '978-85-74066-70-7', 3, 33, 1, 0),
			('Harry Potter e a câmara secreta (capa dura)', 'Nenhuma descrição disponível...', '978-85-32530-79-0', 3, 4, 1, 0),
			('Seja foda!', 'Nenhuma descrição disponível...', '978-85-93156-29-8', 4, 23, 1, 0),
			('Me poupe!', 'Nenhuma descrição disponível...', '978-85-43105-81-9', 4, 1, 1, 0),
			('O poder da autorresponsabilidade', 'Nenhuma descrição disponível...', '978-85-45202-21-9', 4, 31, 1, 0),
			('Do mil ao milhão', 'Nenhuma descrição disponível...', '978-85-95083-27-1', 4, 0, 1, 0),
			('O poder da ação', 'Nenhuma descrição disponível...', '978-85-45200-34-5', 4, 31, 1, 0),
			('Os segredos da mente milionária', 'Nenhuma descrição disponível...', '978-85-75422-39-7', 4, 1, 1, 0),
			('Pai rico, pai pobre - Edição de 20 anos', 'Nenhuma descrição disponível...', '978-85-50801-48-3', 4, 34, 1, 0),
			('Os segredos da mente milionária (edição econômica)', 'Nenhuma descrição disponível...', '978-85-75425-92-3', 4, 1, 1, 0),
			('Ponto de inflexão', 'Nenhuma descrição disponível...', '978-85-93156-83-0', 4, 23, 1, 0),
			('Quem pensa enriquece: o legado', 'Nenhuma descrição disponível...', '978-85-68014-54-7', 4, 26, 1, 0),
			('A riqueza da vida simples', 'Nenhuma descrição disponível...', '978-85-43107-45-5', 4, 1, 1, 0),
			('As armas da persuasão', 'Nenhuma descrição disponível...', '978-85-75428-09-2', 4, 1, 1, 0),
			('Box - Paulo Vieira', 'Nenhuma descrição disponível...', '978-85-45202-15-8', 4, 31, 1, 0),
			('DNA milionário', 'Nenhuma descrição disponível...', '978-85-45202-96-7', 4, 31, 1, 0),
			('O monge e o executivo ( edição econômica )', 'Nenhuma descrição disponível...', '978-85-75424-67-4', 4, 1, 1, 0),
			('O monge e o executivo', 'Nenhuma descrição disponível...', '978-85-75421-02-4', 4, 1, 1, 0),
			('Decifre e influencie pessoas', 'Nenhuma descrição disponível...', '978-85-45202-51-6', 4, 31, 1, 0),
			('Rápido e devagar', 'Nenhuma descrição disponível...', '978-85-39003-83-9', 4, 11, 1, 0),
			('Os 7 hábitos das pessoas altamente eficazes', 'Nenhuma descrição disponível...', '978-85-76840-62-6', 4, 13, 1, 0),
			('Criação de riqueza', 'Nenhuma descrição disponível...', '978-85-45202-88-2', 4, 31, 1, 0);

create table LivrosAutores
(
	[Livro] int not null,
	[Autor] int not null,
	[IdCriacao] int not null,
	[IdAlteracao] int null,
	[DataCriacao] datetime not null default current_timestamp,
	[DataAlteracao] datetime null,
		constraint FK_LivroAutor_Livro
			foreign key (Livro)
			references Livros (Id),
		constraint FK_LivroAutor_Autor
			foreign key (Autor)
			references Autores (Id),
		constraint FK_LivroAutor_UsuarioCriacao
			foreign key (IdCriacao)
			references Usuarios (Id),
		constraint FK_LivroAutor_UsuarioAlteracao
			foreign key (IdAlteracao)
			references Usuarios (Id)
);

insert into LivrosAutores
	(Livro, Autor, IdCriacao)
		values
			(0, 0, 0),
			(1, 1, 0),
			(2, 2, 0),
			(2, 3, 0),
			(3, 4, 0),
			(4, 5, 0),
			(5, 6, 0),
			(5, 7, 0),
			(5, 8, 0),
			(5, 3, 0),
			(6, 9, 0),
			(7, 10, 0),
			(8, 0, 0),
			(9, 9, 0),
			(10, 11, 0),
			(11, 12, 0),
			(12, 13, 0),
			(13, 14, 0),
			(14, 15, 0),
			(15, 16, 0),
			(16, 0, 0),
			(17, 17, 0),
			(18, 18, 0),
			(19, 19, 0),
			(20, 20, 0),
			(21, 21, 0),
			(22, 22, 0),
			(23, 23, 0),
			(24, 21, 0),
			(25, 24, 0),
			(26, 25, 0),
			(27, 26, 0),
			(28, 21, 0),
			(29, 27, 0),
			(30, 28, 0),
			(31, 29, 0),
			(31, 30, 0),
			(32, 31, 0),
			(33, 32, 0),
			(33, 33, 0),
			(34, 34, 0),
			(35, 35, 0),
			(36, 21, 0),
			(37, 36, 0),
			(37, 37, 0),
			(38, 38, 0),
			(39, 39, 0),
			(40, 40, 0),
			(41, 41, 0),
			(42, 42, 0),
			(43, 43, 0),
			(44, 38, 0),
			(45, 44, 0),
			(46, 45, 0),
			(47, 46, 0),
			(48, 0, 0),
			(49, 47, 0),
			(50, 48, 0),
			(51, 49, 0),
			(52, 50, 0),
			(53, 51, 0),
			(54, 39, 0),
			(55, 52, 0),
			(56, 28, 0),
			(57, 53, 0),
			(58, 54, 0),
			(59, 54, 0),
			(60, 55, 0),
			(61, 56, 0),
			(61, 57, 0),
			(61, 58, 0),
			(62, 59, 0),
			(63, 60, 0),
			(64, 59, 0),
			(65, 59, 0),
			(66, 61, 0),
			(67, 62, 0),
			(68, 63, 0),
			(69, 64, 0),
			(69, 65, 0),
			(70, 66, 0),
			(71, 54, 0),
			(72, 67, 0),
			(73, 62, 0),
			(74, 68, 0),
			(75, 60, 0),
			(76, 69, 0),
			(77, 66, 0),
			(78, 70, 0),
			(79, 71, 0),
			(80, 64, 0),
			(81, 72, 0),
			(82, 64, 0),
			(83, 73, 0),
			(84, 74, 0),
			(85, 73, 0),
			(86, 75, 0),
			(87, 42, 0),
			(88, 76, 0),
			(89, 77, 0),
			(90, 64, 0),
			(91, 78, 0),
			(92, 79, 0),
			(93, 79, 0),
			(94, 64, 0),
			(94, 80, 0),
			(95, 81, 0),
			(96, 82, 0),
			(97, 64, 0);