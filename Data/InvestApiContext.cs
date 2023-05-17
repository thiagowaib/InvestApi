using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InvestApi.Models;

    public class InvestApiContext : DbContext
    {
        public InvestApiContext (DbContextOptions<InvestApiContext> options)
            : base(options)
        {
        }

        public DbSet<InvestApi.Models.Ordem> Ordem { get; set; }
    }
