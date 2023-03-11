using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GestaProdutos.Domain.Entidades
{
     public class Fornecedor
    {
        [Key]
        public int CodigoFornecedor { get; set; }
        [StringLength(255)]
        public string DescricaoFornecedor { get; set; }
        [Column("CNPJ")]
        [StringLength(14)]       
        public string Cnpj { get; set; }
    }
}
