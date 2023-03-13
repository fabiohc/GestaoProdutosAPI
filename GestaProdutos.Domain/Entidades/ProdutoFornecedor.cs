using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static GestaProdutos.Domain.Entidades.DataInUseAttribute;

#nullable disable

namespace GestaProdutos.Domain.Entidades
{

    [Table("ProdutoFornecedor")]
    public partial class ProdutoFornecedor
    {
        [Key]
        public int CodigoProduto { get; set; }
        [Required]
        [StringLength(255)]
        [MinLength(1, ErrorMessage = "Informe uma descrição para o produto.")]
        [MaxLength(255, ErrorMessage = "A quantidade máxima de caracteres e permitidos é 255.")]
        public string DescricaoProduto { get; set; }
        [StringLength(7)]
        [SituacaoIsValid(ErrorMessage = "Na Situação use Ativo ou Inativo.")]
        public string Situacao { get; set; }
        [Column(TypeName = "date")]
        [DataInUseAttribute(ErrorMessage = "Data de fabricação não deve ser maior ou igual validade.")]
        public DateTime DataFabricacao { get; set; }
        [Column(TypeName = "date")]
        public DateTime DataValidade { get; set; }
        public int? CodigoFornecedor { get; set; }
        [StringLength(255)]
        public string DescricaoFornecedor { get; set; }
        [Column("CNPJ")]
        [StringLength(14)]
        [MinLength(14, ErrorMessage = "O CNPJ deve 14 caracteres.")]
        [MaxLength(14, ErrorMessage = "O CNPJ deve 14 caracteres.")]
        public string Cnpj { get; set; }
    }

    public class DataInUseAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dataFabricacao = (DateTime)value;

            // Obter o valor da data de validade
            var property = validationContext.ObjectType.GetProperty("DataValidade");
            var dataValidade = (DateTime)property.GetValue(validationContext.ObjectInstance);


            return dataFabricacao >= dataValidade
            ? new ValidationResult("Data de fabricação não deve ser maior ou igual validade.")
            : ValidationResult.Success;

        }

    }
    public class SituacaoIsValidAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (((string)value) == null) new ValidationResult("Valor inválido para propriedade");

            return ((string)value).Contains("Ativo") || ((string)value).Contains("Inativo")
            ? ValidationResult.Success
            : new ValidationResult("Na Situação use Ativo ou Inativo.");
        }
    }
}
