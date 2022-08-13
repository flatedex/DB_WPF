using System.Data.Entity;

namespace DB_WPF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(string source) : base("DefaultConnection") { }
        public DbSet<Goods> Goods { get; set; }
    }
}
