namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Finish : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Autores", "Ativo", c => c.Boolean());
            AddColumn("dbo.Autores", "UsuInc", c => c.Int());
            AddColumn("dbo.Autores", "UsuAlt", c => c.Int());
            AddColumn("dbo.Autores", "DatInc", c => c.DateTime());
            AddColumn("dbo.Autores", "DatAlt", c => c.DateTime());
            AlterColumn("dbo.Usuarios", "Ativo", c => c.Boolean());
            AlterColumn("dbo.Usuarios", "UsuInc", c => c.Int());
            AlterColumn("dbo.Usuarios", "UsuAlt", c => c.Int());
            AlterColumn("dbo.Usuarios", "DatInc", c => c.DateTime());
            AlterColumn("dbo.Usuarios", "DatAlt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "DatAlt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Usuarios", "DatInc", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Usuarios", "UsuAlt", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuarios", "UsuInc", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuarios", "Ativo", c => c.Boolean(nullable: false));
            DropColumn("dbo.Autores", "DatAlt");
            DropColumn("dbo.Autores", "DatInc");
            DropColumn("dbo.Autores", "UsuAlt");
            DropColumn("dbo.Autores", "UsuInc");
            DropColumn("dbo.Autores", "Ativo");
        }
    }
}
