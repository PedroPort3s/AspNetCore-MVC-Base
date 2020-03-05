using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmeMvc.Models
{
    public class FilmeGeneroViewModel
    { 
        public List<Filme> Filmes { get; set; }
        public SelectList Generos { get; set; }
        public string FilmeGenero { get; set; }
        public string StrPesquisa { get; set; }
    }
}
