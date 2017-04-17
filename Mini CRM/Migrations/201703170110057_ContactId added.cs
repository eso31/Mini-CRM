namespace Mini_CRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactIdadded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Annotations", "Contact_Id", "dbo.Contacts");
            DropIndex("dbo.Annotations", new[] { "Contact_Id" });
            RenameColumn(table: "dbo.Annotations", name: "Contact_Id", newName: "ContactId");
            AlterColumn("dbo.Annotations", "ContactId", c => c.Int(nullable: false));
            CreateIndex("dbo.Annotations", "ContactId");
            AddForeignKey("dbo.Annotations", "ContactId", "dbo.Contacts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Annotations", "ContactId", "dbo.Contacts");
            DropIndex("dbo.Annotations", new[] { "ContactId" });
            AlterColumn("dbo.Annotations", "ContactId", c => c.Int());
            RenameColumn(table: "dbo.Annotations", name: "ContactId", newName: "Contact_Id");
            CreateIndex("dbo.Annotations", "Contact_Id");
            AddForeignKey("dbo.Annotations", "Contact_Id", "dbo.Contacts", "Id");
        }
    }
}
