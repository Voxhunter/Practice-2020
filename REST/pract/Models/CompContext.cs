using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace pract.Models
{
    public class CompContext : DbContext
    {
        public CompContext(DbContextOptions<CompContext> options)
            : base(options) 
        { 
        }

        public DbSet<Comp> Comp { get; set; }
    }
}
