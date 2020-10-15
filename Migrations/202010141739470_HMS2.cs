namespace HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HMS2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userid = c.Int(nullable: false, identity: true),
                        username = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Contact = c.String(nullable: false),
                        DateofBirth = c.DateTime(nullable: false),
                        CNIC = c.String(nullable: false, maxLength: 13),
                        Password = c.String(nullable: false, maxLength: 25),
                        ConfirmPassword = c.String(nullable: false, maxLength: 25),
                        Gender = c.String(nullable: false),
                        Agree = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.userid);
            
            CreateIndex("dbo.Bookings", "UserID");
            AddForeignKey("dbo.Bookings", "UserID", "dbo.Users", "userid", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "UserID", "dbo.Users");
            DropIndex("dbo.Bookings", new[] { "UserID" });
            DropTable("dbo.Users");
        }
    }
}
