using Jb.Api.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
//using Microsoft.Extensions.Logging.Console;

namespace Jb.Api.Infrastructure.Context
{
    public class LibraryDbContext : DbContext
    {
        //public static readonly LoggerFactory ConsoleLoggerFactory = new LoggerFactory(new[]
        //{
        //    new ConsoleLoggerProvider((category, level) => category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information, true)
        //});

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<PriceOffer> PriceOffers { get; set; }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>().HasKey(x => new { x.BookId, x.AuthorId });
            modelBuilder.Entity<Book>().Property(p => p.Price).HasColumnType("decimal(18, 2)");
            modelBuilder.Entity<PriceOffer>().Property(p => p.NewPrice).HasColumnType("decimal(18, 2)");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLoggerFactory(ConsoleLoggerFactory);
            //optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
