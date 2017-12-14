namespace CarApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BodyTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Model = c.String(),
                        BrandId = c.Int(nullable: false),
                        BodyTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BodyTypes", t => t.BodyTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId)
                .Index(t => t.BodyTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Cars", "BodyTypeId", "dbo.BodyTypes");
            DropIndex("dbo.Cars", new[] { "BodyTypeId" });
            DropIndex("dbo.Cars", new[] { "BrandId" });
            DropTable("dbo.Cars");
            DropTable("dbo.Brands");
            DropTable("dbo.BodyTypes");
        }
    }
}
