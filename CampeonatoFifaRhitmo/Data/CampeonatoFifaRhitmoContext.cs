using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CampeonatoFifaRhitmo.Models;

namespace CampeonatoFifaRhitmo.Data
{
    public class CampeonatoFifaRhitmoContext : DbContext
    {
        public CampeonatoFifaRhitmoContext (DbContextOptions<CampeonatoFifaRhitmoContext> options)
            : base(options)
        {
        }

        public DbSet<CampeonatoFifaRhitmo.Models.Player> Player { get; set; }
    }
}
