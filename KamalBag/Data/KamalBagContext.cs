using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KamalSelectedBag.Models;

    public class KamalBagContext : DbContext
    {
        public KamalBagContext (DbContextOptions<KamalBagContext> options)
            : base(options)
        {
        }

        public DbSet<KamalSelectedBag.Models.Bag> Bag { get; set; }
    }
