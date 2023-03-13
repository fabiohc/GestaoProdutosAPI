using GestaoProdutos.Aplication.Interfaces;
using GestaProdutos.Domain.Entidades;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace GestaoFornecedorTest
{
    public class Tests
    {
        private ProdutoFornecedorApp _produtoFornecedorApp;
        private Mock<IProdutoFornecedorRepositorio> _produtoFornecedorRepositoryMock;


        [SetUp]
        public void Setup()
        {
            _produtoFornecedorRepositoryMock = new Mock<IProdutoFornecedorRepositorio>();
            _produtoFornecedorApp = new ProdutoFornecedorApp(_produtoFornecedorRepositoryMock.Object);           

        }
                      

        [Test]
        public void ValidarEntidade_QuandoSituacaoForInvalida_DeveRetornarErro()
        {
            // Arrange
            var produtoFornecedor = new ProdutoFornecedor
            {
                CodigoProduto = 1,
                DescricaoProduto = "Produto teste",
                Situacao = "Invalida",
                DataFabricacao = DateTime.Now,
                DataValidade = DateTime.Now.AddDays(10),
                CodigoFornecedor = 1,
                DescricaoFornecedor = "Fornecedor teste",
                Cnpj = "12345678901234"
            };

            var context = new ValidationContext(produtoFornecedor, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(produtoFornecedor, context, results, true);

            // Assert
            Assert.IsFalse(isValid);
            Assert.IsTrue(results.Any(x => x.ErrorMessage.Contains("Na Situação use Ativo ou Inativo.")));
        }

        [Test]
        public void ValidarEntidade_QuandoCnpjForInvalido_DeveRetornarErro()
        {
            // Arrange
            var produtoFornecedor = new ProdutoFornecedor
            {
                CodigoProduto = 1,
                DescricaoProduto = "Produto teste",
                Situacao = "Ativo",
                DataFabricacao = DateTime.Now,
                DataValidade = DateTime.Now.AddDays(10),
                CodigoFornecedor = 1,
                DescricaoFornecedor = "Fornecedor teste",
                Cnpj = "1234"
            };

            var context = new ValidationContext(produtoFornecedor, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(produtoFornecedor, context, results, true);

            // Assert
            Assert.IsFalse(isValid);
            Assert.IsTrue(results.Any(x => x.ErrorMessage.Contains("O CNPJ deve 14 caracteres.")));
        }

        [Test]
        public void ValidarEntidade_QuandoDataFabricacaoMaiorOuIgualDataValidade_DeveRetornarErro()
        {
            // Arrange
            var produtoFornecedor = new ProdutoFornecedor
            {
                CodigoProduto = 1,
                DescricaoProduto = "Produto teste",
                Situacao = "Ativo",
                DataFabricacao = DateTime.Now.AddDays(1),
                DataValidade = DateTime.Now,
                CodigoFornecedor = 1,
                DescricaoFornecedor = "Fornecedor teste",
                Cnpj = "12345678901234"
            };

            var context = new ValidationContext(produtoFornecedor, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(produtoFornecedor, context, results, true);

            // Assert
            Assert.IsFalse(isValid);
            Assert.IsTrue(results.Any(x => x.ErrorMessage.Contains("Data de fabricação não deve ser maior ou igual validade.")));
        }
    }
}
