using Microsoft.EntityFrameworkCore;
using WebApiFilmes.Model;

namespace WebApiFilmes.Context
{
    public class FilmesContext : DbContext
    {
        public FilmesContext(DbContextOptions<FilmesContext> options) : base(options) { }

        public DbSet<Filme> Filmes { get; set; }
    }
}
