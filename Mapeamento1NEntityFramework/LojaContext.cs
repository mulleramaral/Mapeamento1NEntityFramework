using System.Data.Entity;

namespace Mapeamento1NEntityFramework
{
    public class LojaContext:DbContext
    {
        public LojaContext():base("Loja")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<LojaContext>());
            Database.Initialize(false);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
    }
}
