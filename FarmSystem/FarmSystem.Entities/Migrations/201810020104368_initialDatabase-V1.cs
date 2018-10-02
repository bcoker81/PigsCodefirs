namespace FarmSystem.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDatabaseV1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        AnimalId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TagNumber = c.String(),
                        Breed = c.String(),
                        AnimalType = c.String(),
                        Dob = c.DateTime(nullable: false),
                        DateAcquired = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AnimalId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Animals");
        }
    }
}
