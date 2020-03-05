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

        [StringLength(60,MinimumLength =3)]
        [Required]
        public string Titulo { get; set; }

        [Display(Name = "Data de Lancamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Genero { get; set; }

        [Range(1,100)]
        [DataType(DataType.Currency)]
        [Column(TypeName="decimal(18,2)")]
        public decimal Preco{ get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Avaliacao{ get; set; }
    }
}
