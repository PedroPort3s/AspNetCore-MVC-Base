using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FilmeMvc.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }


        [Display(Name = "Data de Lancamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        public string Genero { get; set; }

        [Column(TypeName="decimal(18,2)")]
        public decimal Preco{ get; set; }
    }
}
