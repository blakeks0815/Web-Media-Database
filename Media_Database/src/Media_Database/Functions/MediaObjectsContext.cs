using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Media_Database.Models;
using Microsoft.Data.Entity;

namespace Media_Database.Functions
{
    public class MediaObjectsContext : DbContext {

        public DbSet<Games> MediaObjects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Games>().HasKey(m => m.ID);
            base.OnModelCreating(builder);
        }
    }
}
