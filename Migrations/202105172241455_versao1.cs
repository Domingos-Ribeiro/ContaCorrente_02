namespace ContaCorrente_02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versao1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeCliente = c.String(nullable: false, maxLength: 100),
                        Referencia = c.String(maxLength: 50),
                        Marcador = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movimentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataRegisto = c.DateTime(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        ValorDebito = c.Double(),
                        ValorCredito = c.Double(),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movimentoes", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Movimentoes", new[] { "ClienteId" });
            DropTable("dbo.Movimentoes");
            DropTable("dbo.Clientes");
        }
    }
}
