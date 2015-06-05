namespace agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpansaoCamposBD : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.contatos", "nomeCompleto", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.contatos", "endereco", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.contatos", "endereco", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.contatos", "nomeCompleto", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
