using System.Linq;
using WebApiFilmes.Context;
using WebApiFilmes.IRepository;
using WebApiFilmes.Model;

namespace WebApiFilmes.Repository
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly FilmesContext db;

        public IQueryable<Filme> GetFilme(Filme filme)
        {
            return db.Filmes;
        }

        public void AddFilme(Filme filme)
        {
            db.Filmes.Add(filme);
            db.SaveChanges();
        }

        public Filme BuscarFilmePorId(long id)
        {
            return db.Filmes.FirstOrDefault(c => c.Id == id);
        }

        public void RemoverFilme(long id)
        {
            var filme = db.Filmes.FirstOrDefault(c => c.Id == id);
            db.Filmes.Remove(filme);
            db.SaveChanges();
        }

        public void AtualizarFilme(Filme filme)
        {
            db.Filmes.Update(filme);
            db.SaveChanges();
        }


    }
}
