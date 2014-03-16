namespace Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class petsdbcontext : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pets", "Short_Description", c => c.String());
            AddColumn("dbo.Pets", "Long_Description", c => c.String());
            DropColumn("dbo.Pets", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pets", "Description", c => c.String());
            DropColumn("dbo.Pets", "Long_Description");
            DropColumn("dbo.Pets", "Short_Description");
        }
    }
}
