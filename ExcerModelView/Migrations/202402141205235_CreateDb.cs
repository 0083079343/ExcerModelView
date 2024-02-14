namespace ExcerModelView.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Family = c.String(nullable: false, maxLength: 30),
                        Birthdate = c.DateTime(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 15),
                        Ncode = c.String(nullable: false, maxLength: 10),
                        Password = c.String(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        RegisterDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.T_User");
        }
    }
}
