namespace Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class petsdbcontext1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pets", "Date_Recieved", c => c.DateTime(nullable: false));
            DropColumn("dbo.Pets", "Recieved");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pets", "Recieved", c => c.DateTime(nullable: false));
            DropColumn("dbo.Pets", "Date_Recieved");
        }
    }
}
