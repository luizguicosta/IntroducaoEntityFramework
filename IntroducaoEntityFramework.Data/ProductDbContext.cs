using IntroducaoEntityFramework.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoEntityFramework.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(): base("ProductDb")
        {
            Database.SetInitializer<ProductDbContext>(new CreateDatabaseIfNotExists<ProductDbContext>());
            Database.Initialize(false);

            Database.Log = d => System.Diagnostics.Debug.WriteLine(d);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Loja> Lojas { get; set; }
    }
}
