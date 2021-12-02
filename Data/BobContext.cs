using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PapaBob.Models;

    public class BobContext : DbContext
    {
        public BobContext (DbContextOptions<BobContext> options)
            : base(options)
        {
        }

        public DbSet<PapaBob.Models.Order> Order { get; set; }
    }
