using AutoFixture;
using GestaoProduto.Infra.Data.Context;
using GestaoProdutos.Aplication.Interfaces;
using GestaoProdutos.Application.DTOs;
using GestaProdutos.Domain.Entidades;
using GestaProdutos.Domain.Servicos;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestsGestaoProduto
{
    public class ProdutoFornecedorFake 
    {

        //public class MeuTeste
        //{
        //    [Fact]
        //    public void DataFabricacaoNaoPodeSerMaiorOuIgualDataValidade()
        //    {
        //        // Arrange
        //        var options = new DbContextOptionsBuilder<Contexto>();

        //        var contexto = new Contexto(options);
        //        var produtoFornecedor = new ProdutoFornecedor
        //        {
        //            CodigoProduto = 1,
        //            DescricaoProduto = "Produto Teste",
        //            Situacao = "Ativo",
        //            DataFabricacao = new DateTime(2022, 1, 1),
        //            DataValidade = new DateTime(2021, 12, 31), // Data de validade menor que a data de fabricação
        //            CodigoFornecedor = 1,
        //            DescricaoFornecedor = "Fornecedor Teste",
        //            Cnpj = "00000000000000"
        //        };
        //        contexto.ProdutosFornecedores.Add(produtoFornecedor);
        //        contexto.SaveChanges();

        //        // Act
        //        var result = contexto.Entry(produtoFornecedor).State;

        //        // Assert
        //        Assert.NotEqual(EntityState.Unchanged, result);
        //    }


        //}


        [Fact]
        public void DataFabricacaoNaoPodeSerMaiorOuIgualDataValidade()
        {
            // Arrange
            // Cria dados aliatório com DTO
            var produtoFornecedor = new Fixture().Create<ProdutoFornecedor>();

            var produtoFornecedorRepositorio = new Mock<IProdutoFornecedorRepositorio>();

            var produtoFornecedorServico = new ProdutoFornecedorServico();


            // Act

            produtoFornecedorServico.Incluir(produtoFornecedor);

            // Assert

            produtoFornecedorRepositorio.VerifyAdd(x => x.Incluir(produtoFornecedor), Times.Once());




        }

       


    }


}

