namespace Practica_semanal2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Generos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Generoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Detalle = c.String(),
                        Precio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Citas", "GeneroId", c => c.Int(nullable: false));
            CreateIndex("dbo.Citas", "GeneroId");
            AddForeignKey("dbo.Citas", "GeneroId", "dbo.Generoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Citas", "GeneroId", "dbo.Generoes");
            DropIndex("dbo.Citas", new[] { "GeneroId" });
            DropColumn("dbo.Citas", "GeneroId");
            DropTable("dbo.Generoes");
        }
    }
}
