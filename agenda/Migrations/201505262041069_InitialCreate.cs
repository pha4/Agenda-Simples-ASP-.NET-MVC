namespace agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.contatos",
                c => new
                    {
                        contatoId = c.Long(nullable: false, identity: true),
                        nomeCompleto = c.String(nullable: false, maxLength: 20),
                        endereco = c.String(nullable: false, maxLength: 30),
                        telefone = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.contatoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.contatos");
        }
    }
}
