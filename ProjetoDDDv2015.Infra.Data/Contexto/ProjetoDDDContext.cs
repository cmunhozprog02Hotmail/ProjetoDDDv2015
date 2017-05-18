using ProjetoDDDv2015.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDDv2015.Infra.Data.Contexto
{
    public class ProjetoDDDContext : DbContext
    {
        public ProjetoDDDContext() : base("ProjetoModelDDD")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
    
}
