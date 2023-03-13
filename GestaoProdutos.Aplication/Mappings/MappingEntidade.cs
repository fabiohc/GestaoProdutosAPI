using AutoMapper;
using GestaoProdutos.Application.DTOs;
using GestaProdutos.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestaoProdutos.Application.Mappings
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
          
            CreateMap<ProdutoFornecedor, GetProdutoFornecedorDTO>().ReverseMap();
            CreateMap<ProdutoFornecedor, PostProdutoFornecedorDTO>().ReverseMap(); 


        }
    }
}
