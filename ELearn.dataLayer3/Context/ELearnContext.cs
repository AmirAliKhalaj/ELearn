using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.dataLayer.Context
{
    public class ELearnContext : DbContext
    {
        public ELearnContext(DbContextOptions<ELearnContext> options): base(options)
        {


        }
        public DbSet
    }
}
