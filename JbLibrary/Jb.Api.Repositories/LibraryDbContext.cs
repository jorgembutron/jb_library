using System;
using Jb.Api.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Jb.Api.Repositories
{
    public class LibraryDbContext : DbContext
    {
        private const string ConnectionString =@"Server=(localdb)\mssqllocaldb; Database=JbEfCoreDb; Trusted_Connection=True";

        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
