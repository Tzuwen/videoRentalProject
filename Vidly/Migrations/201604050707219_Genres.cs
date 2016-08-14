namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genres : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres(Id, Name) values(1,'Comedy')");
            Sql("insert into Genres(Id, Name) values(2,'Action')");
            Sql("insert into Genres(Id, Name) values(3,'Family')");
            Sql("insert into Genres(Id, Name) values(4,'Romance')");

            Sql("insert into Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values('Hangover', 1,'8/1/2016','11/6/2009',5)");
            Sql("insert into Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values('Die Hard', 2,'8/1/2016','9/24/1988',5)");
            Sql("insert into Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values('Vacation', 3,'8/1/2016','7/29/2015',5)");
            Sql("insert into Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values('Ted 2', 1,'8/1/2016','6/26/2015',5)");
            Sql("insert into Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values('22 Jump Street', 1,'8/1/2016','8/8/2014',5)");
            Sql("insert into Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values('Wonder Woman', 2,'8/1/2016','9/30/2013',5)");

            Sql("insert into Customers(Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) values('Michael Hwang', 0, 1, '11/6/1980')");
            Sql("insert into Customers(Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) values('Favor Lo', 0, 2,'11/3/1979')");
        }
        
        public override void Down()
        {
        }
    }
}
