
using Microsoft.EntityFrameworkCore;
using Movietheque.Data.Configurations;

namespace Movietheque.Data
{
    public class MoviethequeContext:DbContext
    {
        protected MoviethequeContext()
        {
        }

        public MoviethequeContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfigurator());
        }
    }
}