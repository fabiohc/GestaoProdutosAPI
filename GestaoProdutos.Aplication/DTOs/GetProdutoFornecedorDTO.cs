using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Application.DTOs
{
    public class GetProdutoFornecedorDTO
    {
        [Key]
        public int CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }
        [StringLength(7)]
        public string Situacao { get; set; }
        public DateTime? DataFabricacao { get; set; }
        public DateTime? DataValidade { get; set; }
        public int? CodigoFornecedor { get; set; }
        [StringLength(255)]
        public string DescricaoFornecedor { get; set; }
        [StringLength(14)]
        public string Cnpj { get; set; }
    }




}
