
using Microsoft.EntityFrameworkCore;

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
    }
}