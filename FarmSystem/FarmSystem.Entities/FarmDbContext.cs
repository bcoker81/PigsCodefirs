using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Entities
{
    public class FarmDbContext : DbContext
    {
        public FarmDbContext() : base("FarmDb")
        {

        }
        public DbSet<Animal> Animals { get; set; }
    }
}
