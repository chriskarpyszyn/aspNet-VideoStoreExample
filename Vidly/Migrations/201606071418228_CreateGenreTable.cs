namespace VideoStoreExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGenreTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Genre = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "Genres_Id", c => c.Byte());
            CreateIndex("dbo.Movies", "Genres_Id");
            AddForeignKey("dbo.Movies", "Genres_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genres_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genres_Id" });
            DropColumn("dbo.Movies", "Genres_Id");
            DropColumn("dbo.Movies", "GenreId");
            DropTable("dbo.Genres");
        }
    }
}
