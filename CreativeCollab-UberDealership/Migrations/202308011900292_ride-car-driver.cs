namespace CreativeCollab_UberDealership.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ridecardriver : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Rides", "CarID");
            CreateIndex("dbo.Rides", "DriverID");
            AddForeignKey("dbo.Rides", "CarID", "dbo.Cars", "CarID", cascadeDelete: true);
            AddForeignKey("dbo.Rides", "DriverID", "dbo.Drivers", "DriverID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rides", "DriverID", "dbo.Drivers");
            DropForeignKey("dbo.Rides", "CarID", "dbo.Cars");
            DropIndex("dbo.Rides", new[] { "DriverID" });
            DropIndex("dbo.Rides", new[] { "CarID" });
        }
    }
}
