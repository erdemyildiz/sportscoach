namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurulum2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CoursesID = c.Int(nullable: false, identity: true),
                        CoursesImage = c.String(),
                        CoursesName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CoursesID);
            
            CreateTable(
                "dbo.Pricings",
                c => new
                    {
                        PricingID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.String(),
                    })
                .PrimaryKey(t => t.PricingID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pricings");
            DropTable("dbo.Courses");
        }
    }
}
