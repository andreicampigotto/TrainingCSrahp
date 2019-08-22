namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Iniciand : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 64, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 512, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        IdCriacao = c.Int(nullable: false),
                        IdAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdAlteracao)
                .ForeignKey("dbo.Usuarios", t => t.IdCriacao)
                .Index(t => t.IdCriacao)
                .Index(t => t.IdAlteracao);
            
            CreateTable(
                "dbo.LivrosAutores",
                c => new
                    {
                        Livro = c.Int(nullable: false),
                        Autor = c.Int(nullable: false),
                        IdCriacao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdAlteracao = c.Int(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.Livro, t.Autor, t.IdCriacao, t.DataCriacao })
                .ForeignKey("dbo.Usuarios", t => t.IdAlteracao)
                .ForeignKey("dbo.Usuarios", t => t.IdCriacao)
                .ForeignKey("dbo.Livros", t => t.Livro)
                .ForeignKey("dbo.Autores", t => t.Autor)
                .Index(t => t.Livro)
                .Index(t => t.Autor)
                .Index(t => t.IdCriacao)
                .Index(t => t.IdAlteracao);
            
            CreateTable(
                "dbo.Livros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 128, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 1024, unicode: false),
                        Isbn = c.String(nullable: false, maxLength: 17, unicode: false),
                        Genero = c.Int(nullable: false),
                        Editora = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        IdCriacao = c.Int(nullable: false),
                        IdAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Editoras", t => t.Editora)
                .ForeignKey("dbo.Generos", t => t.Genero)
                .ForeignKey("dbo.Usuarios", t => t.IdAlteracao)
                .ForeignKey("dbo.Usuarios", t => t.IdCriacao)
                .Index(t => t.Genero)
                .Index(t => t.Editora)
                .Index(t => t.IdCriacao)
                .Index(t => t.IdAlteracao);
            
            CreateTable(
                "dbo.Editoras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 64, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 512, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        IdCriacao = c.Int(nullable: false),
                        IdAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdAlteracao)
                .ForeignKey("dbo.Usuarios", t => t.IdCriacao)
                .Index(t => t.IdCriacao)
                .Index(t => t.IdAlteracao);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 64, unicode: false),
                        Login = c.String(nullable: false, maxLength: 32, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 16, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        Ativo = c.Boolean(nullable: false),
                        IdCriacao = c.Int(nullable: false),
                        IdAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Generos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 64, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 512, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        IdCriacao = c.Int(nullable: false),
                        IdAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdAlteracao)
                .ForeignKey("dbo.Usuarios", t => t.IdCriacao)
                .Index(t => t.IdCriacao)
                .Index(t => t.IdAlteracao);
            
            CreateTable(
                "dbo.Locacoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Livro = c.Int(nullable: false),
                        Usuario = c.Int(nullable: false),
                        Tipo = c.Int(nullable: false),
                        Devolucao = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        IdCriacao = c.Int(nullable: false),
                        IdAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdAlteracao)
                .ForeignKey("dbo.Usuarios", t => t.IdCriacao)
                .ForeignKey("dbo.Usuarios", t => t.Usuario)
                .ForeignKey("dbo.Livros", t => t.Livro)
                .Index(t => t.Livro)
                .Index(t => t.Usuario)
                .Index(t => t.IdCriacao)
                .Index(t => t.IdAlteracao);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LivrosAutores", "Autor", "dbo.Autores");
            DropForeignKey("dbo.Locacoes", "Livro", "dbo.Livros");
            DropForeignKey("dbo.LivrosAutores", "Livro", "dbo.Livros");
            DropForeignKey("dbo.Locacoes", "Usuario", "dbo.Usuarios");
            DropForeignKey("dbo.Locacoes", "IdCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.Locacoes", "IdAlteracao", "dbo.Usuarios");
            DropForeignKey("dbo.LivrosAutores", "IdCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.LivrosAutores", "IdAlteracao", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "IdCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "IdAlteracao", "dbo.Usuarios");
            DropForeignKey("dbo.Generos", "IdCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.Generos", "IdAlteracao", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "Genero", "dbo.Generos");
            DropForeignKey("dbo.Editoras", "IdCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.Editoras", "IdAlteracao", "dbo.Usuarios");
            DropForeignKey("dbo.Autores", "IdCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.Autores", "IdAlteracao", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "Editora", "dbo.Editoras");
            DropIndex("dbo.Locacoes", new[] { "IdAlteracao" });
            DropIndex("dbo.Locacoes", new[] { "IdCriacao" });
            DropIndex("dbo.Locacoes", new[] { "Usuario" });
            DropIndex("dbo.Locacoes", new[] { "Livro" });
            DropIndex("dbo.Generos", new[] { "IdAlteracao" });
            DropIndex("dbo.Generos", new[] { "IdCriacao" });
            DropIndex("dbo.Editoras", new[] { "IdAlteracao" });
            DropIndex("dbo.Editoras", new[] { "IdCriacao" });
            DropIndex("dbo.Livros", new[] { "IdAlteracao" });
            DropIndex("dbo.Livros", new[] { "IdCriacao" });
            DropIndex("dbo.Livros", new[] { "Editora" });
            DropIndex("dbo.Livros", new[] { "Genero" });
            DropIndex("dbo.LivrosAutores", new[] { "IdAlteracao" });
            DropIndex("dbo.LivrosAutores", new[] { "IdCriacao" });
            DropIndex("dbo.LivrosAutores", new[] { "Autor" });
            DropIndex("dbo.LivrosAutores", new[] { "Livro" });
            DropIndex("dbo.Autores", new[] { "IdAlteracao" });
            DropIndex("dbo.Autores", new[] { "IdCriacao" });
            DropTable("dbo.Locacoes");
            DropTable("dbo.Generos");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Editoras");
            DropTable("dbo.Livros");
            DropTable("dbo.LivrosAutores");
            DropTable("dbo.Autores");
        }
    }
}
