using ProjetoDDDv2015.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ProjetoDDDv2015.Domain.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(String nome);
    }
}
