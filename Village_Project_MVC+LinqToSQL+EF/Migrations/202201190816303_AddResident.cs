namespace Village_Project_MVC_LinqToSQL_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddResident : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Residents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        FatherName = c.String(),
                        Gender = c.String(),
                        IsBornInVillage = c.Boolean(nullable: false),
                        boorn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Residents");
        }
    }
}
