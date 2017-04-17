namespace Mini_CRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phonechanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "PhoneNumber", c => c.Int(nullable: false));
        }
    }
}
