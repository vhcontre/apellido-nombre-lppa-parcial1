namespace apellido_nombre_lppa_parcial1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Afiliado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 25),
                        Apellido = c.String(nullable: false, maxLength: 25),
                        Email = c.String(nullable: false, maxLength: 35),
                        Telefono = c.Long(nullable: false),
                        Cuit = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Afiliado");
        }
    }
}
