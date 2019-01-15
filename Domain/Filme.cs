using System;

namespace Domain
{
    public class Filme
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Sinopse { get; set; }

    }
}
