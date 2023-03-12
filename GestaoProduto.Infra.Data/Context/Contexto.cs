using GestaProdutos.Domain.Entidades;
using Microsoft.EntityFrameworkCore;


namespace GestaoProduto.Infra.Data.Context
{
    public partial class Contexto : DbContext
    {
        public Contexto()
        {
        }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.HasKey(e => e.CodigoFornecedor);
                // .HasName("PK__Forneced__1FA78911A8D536FF");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.Property(e => e.CodigoProduto).ValueGeneratedOnAdd();

                entity.HasOne(d => d.CodigoProdutoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CodigoProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull);
                //.HasConstraintName("fk_FornecedorProduto");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
