using System.Linq;
using WebApiFilmes.Model;

namespace WebApiFilmes.IRepository
{
    public interface IFilmeRepository
    {
        void AddFilme(Filme filme);
        IQueryable<Filme> GetFilme(Filme filme);
        Filme BuscarFilmePorId(long id);
        void RemoverFilme(long id);
        void AtualizarFilme(Filme filme);

    }
}
