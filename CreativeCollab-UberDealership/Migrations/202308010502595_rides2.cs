namespace CreativeCollab_UberDealership.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rides2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rides",
                c => new
                    {
                        RideId = c.Int(nullable: false, identity: true),
                        RideName = c.String(),
                        StartLocation = c.String(),
                        EndLocation = c.String(),
                        CarID = c.Int(nullable: false),
                        DriverID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RideId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rides");
        }
    }
}
