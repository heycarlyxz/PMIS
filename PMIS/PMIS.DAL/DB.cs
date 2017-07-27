using PMIS.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMIS.DAL
{
    public class DB : DbContext

    {
        public DB() : base("DefaultConnection") { }

        public DbSet<Users> Users { get; set; }
        
    }
}
