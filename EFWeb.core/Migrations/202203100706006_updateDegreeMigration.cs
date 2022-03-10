namespace EFWeb.core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDegreeMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Degree", "GPA");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Degree", "GPA", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
