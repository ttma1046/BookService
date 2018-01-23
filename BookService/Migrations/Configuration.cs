

namespace BookService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BookService.Models.DA;

    internal sealed class Configuration : DbMigrationsConfiguration<BookService.Models.BookServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookService.Models.BookServiceContext context)
        {
            context.Authors.AddOrUpdate(new Author[] {
                new Author() { Id = 1, Name = "Ralls, Kim" },
                new Author() { Id = 2, Name = "Corets, Eva" },
                new Author() { Id = 3, Name = "Randall, Cynthia" },
                new Author() { Id = 4, Name = "Thurman, Paula" }
            });

            context.Books.AddOrUpdate(new Book[] {
                new Book() { Id = 1,  Title= "Midnight Rain", Genre = "Fantasy",
                    PublicationDate = new DateTime(2000, 12, 16), AuthorId = 1, Description =
                        "A former architect battles an evil sorceress.", Price = 14.95M },

                new Book() { Id = 2, Title = "Maeve Ascendant", Genre = "Fantasy",
                    PublicationDate = new DateTime(2000, 11, 17), AuthorId = 2, Description =
                        "After the collapse of a nanotechnology society, the young" +
                        "survivors lay the foundation for a new society.", Price = 12.95M },

                new Book() { Id = 3, Title = "The Sundered Grail", Genre = "Fantasy",
                    PublicationDate = new DateTime(2001, 09, 10), AuthorId = 2, Description =
                        "The two daughters of Maeve battle for control of England.", Price = 12.95M },

                new Book() { Id = 4, Title = "Lover Birds", Genre = "Romance",
                    PublicationDate = new DateTime(2000, 09, 02), AuthorId = 3, Description =
                        "When Carla meets Paul at an ornithology conference, tempers fly.", Price = 7.99M },

                new Book() { Id = 5, Title = "Splish Splash", Genre = "Romance",
                    PublicationDate = new DateTime(2000, 11, 02), AuthorId = 4, Description =
                        "A deep sea diver finds true love 20,000 leagues beneath the sea.", Price = 6.99M},
            });
        }
    }
}
