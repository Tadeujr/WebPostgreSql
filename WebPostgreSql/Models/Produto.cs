using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSql.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name="Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Valor")]
        [Display(Name = "Valor")]
        public float Valor { get; set; }
    }
}
