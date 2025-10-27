using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBoto.Models
{
    internal class EbotoDBContext : DbContext
    {
        public EbotoDBContext() : base("name=EbotoDBContext"){}
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Election> Elections { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Voted> Voted { get; set; }
        public DbSet<Voter> Voters { get; set; }



    }
}
