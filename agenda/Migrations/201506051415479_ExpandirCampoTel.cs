namespace agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpandirCampoTel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.contatos", "telefone", c => c.String(maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.contatos", "telefone", c => c.String(maxLength: 10));
        }
    }
}
