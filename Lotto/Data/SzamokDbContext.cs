using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Data
{
    public class SzamokDbContext : DbContext
    {
        public DbSet<Szamok> Lottoszamok { get; set; }
        public SzamokDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Lotto;Trusted_Connection=True");
        }
    }
}
