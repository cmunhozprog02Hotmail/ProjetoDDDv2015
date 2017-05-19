using System;
using System.Collections.Generic;
using ProjetoDDDv2015.Domain.Entities;
using ProjetoDDDv2015.Domain.Interfaces;
using System.Linq;

namespace ProjetoDDDv2015.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
