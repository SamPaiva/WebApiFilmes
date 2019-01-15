using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApiFilmes.IRepository;
using WebApiFilmes.Model;

namespace WebApiFilmes.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class FilmeController : Controller
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeController(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        [HttpGet]
        public IQueryable<Filme> GetFilmes(Filme filme)
        {
            return _filmeRepository.GetFilme(filme);
        }

        [HttpGet("{id}", Name = "GetFilmePorId")]
        public IActionResult GetFilmeById(long id)
        {
            var filme = _filmeRepository.BuscarFilmePorId(id);
            if (filme == null)
            {
                return NotFound();
            }

            return new ObjectResult(filme);
        }


    }
}