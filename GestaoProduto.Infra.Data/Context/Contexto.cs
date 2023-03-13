using GestaProdutos.Domain.Entidades;
using Microsoft.EntityFrameworkCore;


namespace GestaoProduto.Infra.Data.Context
{
    public partial class Contexto : DbContext
    {
        public Contexto(DbContextOptionsBuilder<Contexto> options)
        {
        }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public virtual DbSet<ProdutoFornecedor> ProdutoFornecedor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<ProdutoFornecedor>(entity =>
            {
                entity.Property(e => e.Cnpj).IsUnicode(false);

                entity.Property(e => e.CodigoProduto).ValueGeneratedOnAdd();

                entity.Property(e => e.DescricaoFornecedor).IsUnicode(false);

                entity.Property(e => e.DescricaoProduto).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
