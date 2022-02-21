using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("id")]
        [Display(Name="Código")]
        public int Id { get; set; }
        [Column("nome")]
        [Display(Name = "Nome")]
        public int Nome { get; set; }
    }
}
