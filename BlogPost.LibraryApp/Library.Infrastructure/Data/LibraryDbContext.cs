using Library.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Data
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public LibraryDbContext() { }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                var connectionString = "Server=(localdb)\\MSSQLLocalDB; Database=LibraryDb; Integrated Security=True;";

                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Author>().HasData(
                    new Author
                    {
                        Id = 1,
                        FirstName = "Elizabeth",
                        LastName = "Gilbert"
                    },
                    new Author
                    {
                        Id = 2,
                        FirstName = "Alex",
                        LastName = "Michaelides"
                    },
                      new Author
                      {
                          Id = 3,
                          FirstName = "Jayson",
                          LastName = "Greene"
                      },
                    new Author
                    {
                        Id = 4,
                        FirstName = "Jennifer",
                        LastName = "Weiner"
                    },
                     new Author
                     {
                         Id = 5,
                         FirstName = "Yangsze",
                         LastName = "Choo"
                     },
                     new Author
                     {
                         Id = 6,
                         FirstName = "Taylor",
                         LastName = "Jenkins Reid"
                     });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Novel" },
                new Category { Id = 2, CategoryName = "Thriller" },
                new Category { Id = 3, CategoryName = "Memoir" }
                );

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, BookName = "City of Girls", AuthorId = 1, CategoryId = 1 },
                new Book { Id = 2, BookName = "The Silent Patient", AuthorId = 2, CategoryId = 2 },
                new Book { Id = 3, BookName = "Once More We Saw Stars", AuthorId = 3, CategoryId = 3 },
                new Book { Id = 4, BookName = "Mrs. Everything", AuthorId = 4, CategoryId = 1 },
                new Book { Id = 5, BookName = "The Night Tiger", AuthorId = 5, CategoryId = 1 },
                new Book { Id = 6, BookName = "Daisy Jones & The Six", AuthorId = 6, CategoryId = 1 }
            );
        }
    }
}
