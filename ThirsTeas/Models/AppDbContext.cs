using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThirsTeas.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //entities
        public DbSet<Tea> Teas { get; set; }
        public DbSet<Flavour> Flavours { get; set; }
        public DbSet<Type> Types { get; set; }

    }



}
