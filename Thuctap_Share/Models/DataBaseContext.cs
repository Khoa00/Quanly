using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuctap_Share.Models
{
    public class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        public DbSet<GiangvienModel> GiangvienModels { get; set; }

        public DbSet<MuchocphiModel> MuchocphiModels { get; set; }
        public DbSet<QuanlyhocphiModel> QuanlyhocphiModels { get; set; }
    }
}
