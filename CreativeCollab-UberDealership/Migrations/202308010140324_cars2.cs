namespace CreativeCollab_UberDealership.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cars2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "ModelID", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "DealerID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "DealerID");
            DropColumn("dbo.Cars", "ModelID");
        }
    }
}
