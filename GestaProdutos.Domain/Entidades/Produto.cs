using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaProdutos.Domain.Entidades
{
    public class Produto
    {
        public int CodigoProduto { get; set; }
        [Required]
        [StringLength(255)]       
        public string DescricaoProduto { get; set; }
        public bool Situacao { get; set; }
        public DateTime? DataFabricacao { get; set; }
        public DateTime? DataValidade { get; set; }

        [ForeignKey("CodigoProduto")]
        public virtual Fornecedor CodigoProdutoNavigation { get; set; }
    }
}
