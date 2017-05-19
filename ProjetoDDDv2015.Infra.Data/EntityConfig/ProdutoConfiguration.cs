using ProjetoDDDv2015.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoDDDv2015.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Valor)
                .IsRequired();

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);

        }
    }
  
}
