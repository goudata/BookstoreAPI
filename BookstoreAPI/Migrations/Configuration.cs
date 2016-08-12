namespace BookstoreAPI.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookstoreAPI.Models.BookstoreAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BookstoreAPI.Models.BookstoreAPIContext context)
        {
            //  This method will be called after migrating to the latest version.

            // Category Seed
            context.Categories.AddOrUpdate(
              c => c.Id,
              new Category { Id = 1, Name = "Drama" },
              new Category { Id = 2,  Name = "Action and Adventure" },
              new Category { Id = 3, Name = "Romance" },
              new Category { Id = 4, Name = "Mystery" },
              new Category { Id = 5, Name = "Horror" },
              new Category { Id = 6, Name = "Audio Book" }
            );

            // Author Seed
            context.Authors.AddOrUpdate(
                c => c.Id,
             new Author { Id = 1, FirstName = "Jane", LastName = "Austen" },
             new Author { Id = 2, FirstName = "Charles", LastName = "Dickens" },
             new Author { Id = 3, FirstName = "Scott", LastName = "Adams" }
           );

            // BookReview Seed
            context.BookReviews.AddOrUpdate(
                c => c.Id,
                new BookReview { Id = 1, ReviewerName = "John Doe", ReviewerText = "Very awesome book, must read!", Rating = 3, PublishDate = Convert.ToDateTime("05/08/2015") }
            );

            // Book Seed
            context.Books.AddOrUpdate(
                c => c.Id,
                new Book { Id = 1, Title = "Harry Potter and the Sorcerer's Stone", Description = "Real Story!", PublishDate = Convert.ToDateTime("02/05/1998"), CoverImageURL = "https://pics.cdn.librarything.com/picsizes/be/e9/bee9fe568e3dd0a593551665267444341587343.jpg", CategoryId = 6, AuthorId = 3, BookReviewId = 1 },
                new Book { Id = 2, Title = "Lord of the Flies", Description = "Real Story!", PublishDate = Convert.ToDateTime("10/11/1984"), CoverImageURL = "https://pics.cdn.librarything.com/picsizes/23/9a/239ae72f983cd49593655615267444341587343.jpg", CategoryId = 6, AuthorId = 3, BookReviewId = 1 },
                new Book { Id = 3, Title = "Mockingjay", Description = "Real Story!", PublishDate = Convert.ToDateTime("02/05/1998"), CoverImageURL = "https://pics.cdn.librarything.com/picsizes/23/9a/239ae72f983cd49593655615267444341587343.jpg", CategoryId = 6, AuthorId = 3, BookReviewId = 1 },
                new Book { Id = 4, Title = "Dark side of engineering Ver 1", Description = "Work Environment", PublishDate = Convert.ToDateTime("07/25/2008"), CoverImageURL = "https://pics.cdn.librarything.com/picsizes/23/9a/239ae72f983cd49593655615267444341587343.jpg", CategoryId = 4, AuthorId = 1, BookReviewId = 1 },
                new Book { Id = 5, Title = "Dark side of engineering Ver 2", Description = "Work Environment", PublishDate = Convert.ToDateTime("07/25/2009"), CoverImageURL = "https://pics.cdn.librarything.com/picsizes/23/9a/239ae72f983cd49593655615267444341587343.jpg", CategoryId = 4, AuthorId = 2, BookReviewId = 1 },
                new Book { Id = 6, Title = "Dark side of engineering Ver 3", Description = "Work Environment", PublishDate = Convert.ToDateTime("07/25/2010"), CoverImageURL = "https://pics.cdn.librarything.com/picsizes/23/9a/239ae72f983cd49593655615267444341587343.jpg", CategoryId = 4, AuthorId = 2, BookReviewId = 1 },
                new Book { Id = 7, Title = "Dark side of engineering Ver 4", Description = "Work Environment", PublishDate = Convert.ToDateTime("07/25/2011"), CoverImageURL = "https://pics.cdn.librarything.com/picsizes/23/9a/239ae72f983cd49593655615267444341587343.jpg", CategoryId = 4, AuthorId = 2, BookReviewId = 1 },
                new Book { Id = 8, Title = "Dark side of engineering Ver 5", Description = "Work Environment", PublishDate = Convert.ToDateTime("07/25/2012"), CoverImageURL = "https://pics.cdn.librarything.com/picsizes/23/9a/239ae72f983cd49593655615267444341587343.jpg", CategoryId = 4, AuthorId = 1, BookReviewId = 1 },
                new Book { Id = 9, Title = "Dark side of engineering Ver 6", Description = "Work Environment", PublishDate = Convert.ToDateTime("07/25/2013"), CoverImageURL = "https://pics.cdn.librarything.com/picsizes/23/9a/239ae72f983cd49593655615267444341587343.jpg", CategoryId = 4, AuthorId = 1, BookReviewId = 1 },
                new Book { Id = 10, Title = "Dark side of engineering Ver 7", Description = "Work Environment", PublishDate = Convert.ToDateTime("07/25/2014"), CoverImageURL = "https://pics.cdn.librarything.com/picsizes/23/9a/239ae72f983cd49593655615267444341587343.jpg", CategoryId = 4, AuthorId = 2, BookReviewId = 1 },
                new Book { Id = 11, Title = "Dark side of engineering Ver 8", Description = "Work Environment", PublishDate = Convert.ToDateTime("07/25/2015"), CoverImageURL = "https://pics.cdn.librarything.com/picsizes/23/9a/239ae72f983cd49593655615267444341587343.jpg", CategoryId = 4, AuthorId = 1, BookReviewId = 1 },
                new Book { Id = 12, Title = "Dark side of engineering Ver 9", Description = "Work Environment", PublishDate = Convert.ToDateTime("07/25/2016"), CoverImageURL = "https://pics.cdn.librarything.com/picsizes/23/9a/239ae72f983cd49593655615267444341587343.jpg", CategoryId = 4, AuthorId = 1, BookReviewId = 1 },
                new Book { Id = 13, Title = "Dark side of engineering Ver 10", Description = "Work Environment", PublishDate = Convert.ToDateTime("09/25/2016"), CoverImageURL = "https://pics.cdn.librarything.com/picsizes/23/9a/239ae72f983cd49593655615267444341587343.jpg", CategoryId = 4, AuthorId = 1, BookReviewId = 1 }

            );
        }
    }
}
