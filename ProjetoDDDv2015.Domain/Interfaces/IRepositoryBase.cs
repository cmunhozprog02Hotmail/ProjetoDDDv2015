using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDDv2015.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        //Adicionar
        void Add(TEntity obj);

        // Selecionar
        TEntity GetById(int id);
        
        // Listar Todos
        IEnumerable<TEntity> GetAll();

        // Updata
        void Update(TEntity obj);

        // Delete
        void Remove(TEntity obj);

        void Dispose();
    }
} 
