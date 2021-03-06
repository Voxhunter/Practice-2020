﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace pract.Models
{
    public class WorkContext : DbContext
    {
        public WorkContext(DbContextOptions<WorkContext> options)
            : base(options)
        {
        }

        public DbSet<Work> Work { get; set; }
    }
}
