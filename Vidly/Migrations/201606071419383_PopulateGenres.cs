namespace VideoStoreExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Genre) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Genre) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres (Id, Genre) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (Id, Genre) VALUES (4, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
