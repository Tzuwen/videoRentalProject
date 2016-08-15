namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailableToMovie : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Rentals", newName: "NewRentals");
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));
            AddColumn("dbo.NewRentals", "Customer_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.NewRentals", "Customer_Id");
            AddForeignKey("dbo.NewRentals", "Customer_Id", "dbo.Customers", "Id", cascadeDelete: true);

            Sql("UPDATE Movies SET NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewRentals", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.NewRentals", new[] { "Customer_Id" });
            DropColumn("dbo.NewRentals", "Customer_Id");
            DropColumn("dbo.Movies", "NumberAvailable");
            RenameTable(name: "dbo.NewRentals", newName: "Rentals");
        }
    }
}
