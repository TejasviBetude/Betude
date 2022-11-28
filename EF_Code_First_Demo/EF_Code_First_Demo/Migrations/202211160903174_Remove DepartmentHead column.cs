namespace EF_Code_First_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDepartmentHeadcolumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Departments", "DepartmentHead");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "DepartmentHead", c => c.String());
        }
    }
}
