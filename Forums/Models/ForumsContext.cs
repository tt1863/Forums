using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Forums.Models
{
    public class ForumsContext : DbContext
    {
        public ForumsContext()
            : base("ForumsContext")
        {
        }

        public DbSet<Forum> Forums { get; set; }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}