namespace EFWeb.core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbDoctorMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Doctor");
        }
    }
}
