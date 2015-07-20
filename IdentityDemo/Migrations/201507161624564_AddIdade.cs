namespace IdentityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIdade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Idade", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Idade");
        }
    }
}
