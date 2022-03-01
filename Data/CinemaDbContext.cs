using Microsoft.EntityFrameworkCore;
using netcore5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore5.Data {
    public class CinemaDbContext : DbContext {

        public CinemaDbContext(DbContextOptions<CinemaDbContext> options): base(options) { 
            //
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
