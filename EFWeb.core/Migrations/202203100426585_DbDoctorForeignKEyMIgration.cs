namespace EFWeb.core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbDoctorForeignKEyMIgration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctor", "DegreeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Doctor", "DegreeID");
            AddForeignKey("dbo.Doctor", "DegreeID", "dbo.Degree", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctor", "DegreeID", "dbo.Degree");
            DropIndex("dbo.Doctor", new[] { "DegreeID" });
            DropColumn("dbo.Doctor", "DegreeID");
        }
    }
}
