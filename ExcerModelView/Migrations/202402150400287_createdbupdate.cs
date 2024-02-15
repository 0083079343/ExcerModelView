namespace ExcerModelView.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdbupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.T_User", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.T_User", "Image");
        }
    }
}
