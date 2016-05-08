using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Media_Database.Functions;

namespace Media_Database.Migrations
{
    [DbContext(typeof(MediaObjectsContext))]
    [Migration("20160508135205_testMigration")]
    partial class testMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("Media_Database.Models.MediaObject", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Owner");

                    b.Property<string>("Path");

                    b.Property<string>("Titel");

                    b.HasKey("ID");
                });
        }
    }
}
