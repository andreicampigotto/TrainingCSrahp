namespace WebMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pessoas", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.Pessoas", "UsuarioEdicao", c => c.Int(nullable: false));
            AddColumn("dbo.Pessoas", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pessoas", "DataEdicao", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pessoas", "DataEdicao");
            DropColumn("dbo.Pessoas", "DataCriacao");
            DropColumn("dbo.Pessoas", "UsuarioEdicao");
            DropColumn("dbo.Pessoas", "UsuarioCriacao");
            DropColumn("dbo.Pessoas", "Ativo");
        }
    }
}
