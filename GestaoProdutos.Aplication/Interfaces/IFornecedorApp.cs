﻿using GestaProdutos.Domain.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoProdutos.Aplication.Interfaces
{
    public interface IFornecedorApp
    {

        void Incluir(Fornecedor produto);
        void Alterar(Fornecedor produto);
        void Excluir(Fornecedor produto);
        Task<Fornecedor> ObterProID(int id);
        Task<IEnumerable<Fornecedor>> ObterTodos();

    }
}
