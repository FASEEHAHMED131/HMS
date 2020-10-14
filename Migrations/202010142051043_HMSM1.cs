namespace HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HMSM1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccomodationPackages",
                c => new
                    {
                        AccomodationPackage_ID = c.Int(nullable: false, identity: true),
                        AccomodationType_ID = c.Int(nullable: false),
                        AccomodationPackage_Name = c.String(),
                        Rooms = c.Int(nullable: false),
                        Package = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AccomodationType_AcccomodationType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.AccomodationPackage_ID)
                .ForeignKey("dbo.AccomodationTypes", t => t.AccomodationType_AcccomodationType_ID)
                .Index(t => t.AccomodationType_AcccomodationType_ID);
            
            CreateTable(
                "dbo.AccomodationTypes",
                c => new
                    {
                        AcccomodationType_ID = c.Int(nullable: false, identity: true),
                        AcccomodationType_Name = c.String(),
                    })
                .PrimaryKey(t => t.AcccomodationType_ID);
            
            CreateTable(
                "dbo.Accomodations",
                c => new
                    {
                        Accomodation_ID = c.Int(nullable: false, identity: true),
                        AccomodationPackageID = c.Int(nullable: false),
                        Room_Number = c.Int(nullable: false),
                        status = c.Boolean(nullable: false),
                        AccomodationPackage_AccomodationPackage_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Accomodation_ID)
                .ForeignKey("dbo.AccomodationPackages", t => t.AccomodationPackage_AccomodationPackage_ID)
                .Index(t => t.AccomodationPackage_AccomodationPackage_ID);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        AccomodationID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Duration = c.Int(nullable: false),
                        Accomodation_Accomodation_ID = c.Int(),
                    })
                .PrimaryKey(t => t.BookingID)
                .ForeignKey("dbo.Accomodations", t => t.Accomodation_Accomodation_ID)
                .Index(t => t.Accomodation_Accomodation_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "Accomodation_Accomodation_ID", "dbo.Accomodations");
            DropForeignKey("dbo.Accomodations", "AccomodationPackage_AccomodationPackage_ID", "dbo.AccomodationPackages");
            DropForeignKey("dbo.AccomodationPackages", "AccomodationType_AcccomodationType_ID", "dbo.AccomodationTypes");
            DropIndex("dbo.Bookings", new[] { "Accomodation_Accomodation_ID" });
            DropIndex("dbo.Accomodations", new[] { "AccomodationPackage_AccomodationPackage_ID" });
            DropIndex("dbo.AccomodationPackages", new[] { "AccomodationType_AcccomodationType_ID" });
            DropTable("dbo.Bookings");
            DropTable("dbo.Accomodations");
            DropTable("dbo.AccomodationTypes");
            DropTable("dbo.AccomodationPackages");
        }
    }
}
