namespace Survey_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Use : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.Users", "Surname", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false));
        }
    }
}
