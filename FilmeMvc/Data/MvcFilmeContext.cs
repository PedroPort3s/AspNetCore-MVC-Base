using FilmeMvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmeMvc.Data
{
    public class MvcFilmeContext : DbContext
    {
        public MvcFilmeContext(DbContextOptions<MvcFilmeContext> options):base(options)
        {

        }

        public DbSet<Filme> Filme { get; set; } 
    }
}
