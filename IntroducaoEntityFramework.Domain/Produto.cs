using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoEntityFramework.Domain
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(150)]
        [Required]
        public string Nome { get; set; }

        [MaxLength(500)]
        public string Descricao { get; set; }

        [Range(-999999999999.99, 999999999999.99)]
        [Required]
        public decimal Valor { get; set; }

        [ForeignKey("Loja")]
        public int LojaID { get; set; }

        public virtual Loja Loja { get; set; }
    }
}
