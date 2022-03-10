namespace EFWeb.core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbDegreeMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Degree",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        University = c.String(),
                        GPA = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Degree");
        }
    }
}
