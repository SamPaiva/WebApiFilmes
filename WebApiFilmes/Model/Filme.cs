using System;

namespace WebApiFilmes.Model
{
    public class Filme
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public string Diretor { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
