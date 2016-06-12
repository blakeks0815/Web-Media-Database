using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Media_Database.Models;
namespace Media_Database
{
    public class MediaObjectContext : DbContext {

        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Filename=./datasets.sqlite");
        }

        //protected override void OnModelCreating(ModelBuilder builder) {
        //    builder.Entity<Game>().HasKey(m => m.ID);
        //    base.OnModelCreating(builder);
        //}
    }
}
