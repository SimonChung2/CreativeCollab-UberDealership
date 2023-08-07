namespace CreativeCollab_UberDealership.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carcarmodeldealer : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Cars", "ModelID");
            CreateIndex("dbo.Cars", "DealerID");
            AddForeignKey("dbo.Cars", "ModelID", "dbo.CarModels", "ModelID", cascadeDelete: true);
            AddForeignKey("dbo.Cars", "DealerID", "dbo.Dealers", "DealerID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "DealerID", "dbo.Dealers");
            DropForeignKey("dbo.Cars", "ModelID", "dbo.CarModels");
            DropIndex("dbo.Cars", new[] { "DealerID" });
            DropIndex("dbo.Cars", new[] { "ModelID" });
        }
    }
}
