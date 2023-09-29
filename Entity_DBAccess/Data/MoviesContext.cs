using Entity_DBAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity_DBAccess.Data
{
    public class MoviesContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MovieApp;Data Source=BUECKER-VANESSA\\SQLEXPRESS");
        }
    }
}
