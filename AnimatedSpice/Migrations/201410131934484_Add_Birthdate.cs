namespace AnimatedSpice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Birthdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "BirthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "BirthDate");
        }
    }
}
