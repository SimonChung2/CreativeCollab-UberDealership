namespace CreativeCollab_UberDealership.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class drivercar : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Drivers", "CarID");
            AddForeignKey("dbo.Drivers", "CarID", "dbo.Cars", "CarID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Drivers", "CarID", "dbo.Cars");
            DropIndex("dbo.Drivers", new[] { "CarID" });
        }
    }
}
