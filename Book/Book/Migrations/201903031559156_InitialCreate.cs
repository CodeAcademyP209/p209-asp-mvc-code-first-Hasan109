namespace Book.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookName = c.String(nullable: false, maxLength: 100),
                        Genre = c.String(nullable: false, maxLength: 100),
                        Page = c.Int(nullable: false),
                        Author = c.String(nullable: false, maxLength: 100),
                        ISBN = c.String(),
                        Image = c.String(maxLength: 100),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
