using AutoMapper;
using GestaoProdutos.Aplication.Interfaces;
using GestaoProdutos.Application.DTOs;
using GestaProdutos.Domain.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace GestaoProdutosAPI.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProdutoFornecedorController : Controller
    {
        private readonly IProdutoFornecedorRepositorio _produtoFornecedorRepositorio;
        private readonly IMapper _mapper;

        public ProdutoFornecedorController(IProdutoFornecedorRepositorio produtoFornecedorRepositorio, IMapper mapper)
        {
            _produtoFornecedorRepositorio = produtoFornecedorRepositorio;
            _mapper = mapper;
        }

        [HttpGet("/GetProdutos")]
        public async Task<ActionResult<IEnumerable<ProdutoFornecedor>>> GetProdutos([FromQuery] GetProdutoFornecedorDTO getProduto,int skip = 1, int take = 10)
        {
            try
            {
                var produto = _mapper.Map<ProdutoFornecedor>(getProduto);

                var produtos = await _produtoFornecedorRepositorio.ObterTodos(produto);

                return Ok(_mapper.Map<IEnumerable<GetProdutoFornecedorDTO>>(produtos).Skip(skip).Take(take));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/GetProdutoPorCodigo/{codigoProduto}")]
        public async Task<ActionResult<IEnumerable<ProdutoFornecedor>>> GetProdutoPorCodigo(int codigoProduto)
        {
            try
            {
                var produto = await _produtoFornecedorRepositorio.ObterProID(codigoProduto);

                if (produto == null) return NotFound("Produto não encontado.");

                return Ok(_mapper.Map<GetProdutoFornecedorDTO>(produto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("/CadastraProduto")]
        public async Task<ActionResult> CadastraProduto(PostProdutoFornecedorDTO produtoDTO)
        {
            try
            {
                var produto = _mapper.Map<ProdutoFornecedor>(produtoDTO);

                if (!TryValidateModel(produto)) return BadRequest(ModelState);

                _produtoFornecedorRepositorio.Incluir(produto);

                if (await _produtoFornecedorRepositorio.SaveOkAsync()) return Ok("Produto cadastrado com sucesso.");

                return BadRequest("Erro no cadastrado do produto.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("/AlterarProduto")]
        public async Task<ActionResult> AlterarProduto(PostProdutoFornecedorDTO produtoDTO)
        {
            try
            {
                var produto = _mapper.Map<ProdutoFornecedor>(produtoDTO);

                _produtoFornecedorRepositorio.Alterar(produto);

                if (await _produtoFornecedorRepositorio.SaveOkAsync()) return Ok("Produto alterado com sucesso.");

                return BadRequest("Erro ao alterar produto.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("/DeleteProduto/{CodigoProduto}")]
        public async Task<ActionResult> DeleteProduto(int CodigoProduto)
        {
            try
            {
                var produto = await _produtoFornecedorRepositorio.ObterProID(CodigoProduto);

                /*Altera o status para inativo*/
                _produtoFornecedorRepositorio.ExcluirLogico(produto);

                if (await _produtoFornecedorRepositorio.SaveOkAsync()) return Ok("Produto excluído com sucesso.");

                return BadRequest("Erro na exclusão do produto.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
