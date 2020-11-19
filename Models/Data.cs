// create a dbcontext

using Microsoft.EntityFrameworkCore;
using stickynotes.Models;

namespace stickynotes.Data {
    public class StickyContext : DbContext
    {
        public StickyContext (DbContextOptions<StickyContext> options)
            : base(options)
        {
        }

        // create a model, then insert a dbset here that matches it.
        // public DbSet<Movie> Movie { get; set; }
    }
}