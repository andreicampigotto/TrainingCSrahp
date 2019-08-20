namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inserindoEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Autores", "DataCriacao", c => c.DateTime());
            AlterColumn("dbo.Livros", "DataCriacao", c => c.DateTime());
            AlterColumn("dbo.Editoras", "DataCriacao", c => c.DateTime());
            AlterColumn("dbo.Generos", "DataCriacao", c => c.DateTime());
            AlterColumn("dbo.Locacoes", "DataCriacao", c => c.DateTime());
            DropColumn("dbo.Usuarios", "Ativo");
            DropColumn("dbo.Usuarios", "IdCriacao");
            DropColumn("dbo.Usuarios", "IdAlteracao");
            DropColumn("dbo.Usuarios", "DataCriacao");
            DropColumn("dbo.Usuarios", "DataAlteracao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "DataAlteracao", c => c.DateTime());
            AddColumn("dbo.Usuarios", "DataCriacao", c => c.DateTime());
            AddColumn("dbo.Usuarios", "IdAlteracao", c => c.Int());
            AddColumn("dbo.Usuarios", "IdCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "Ativo", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Locacoes", "DataCriacao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Generos", "DataCriacao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Editoras", "DataCriacao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Livros", "DataCriacao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Autores", "DataCriacao", c => c.DateTime(nullable: false));
            DropColumn("dbo.Usuarios", "Email");
        }
    }
}
