using System;
using Microsoft.EntityFrameworkCore;
using Project.Entities;

namespace Project.Data;

public class ProjectContext(DbContextOptions<ProjectContext> options) : DbContext(options)
{
    public DbSet<CategoryEntity> Categories => Set<CategoryEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoryEntity>().HasData(
         new { Id = 1, Name = "Kids and Family" },
         new { Id = 2, Name = "Eco-Friendly Living" },
         new {Id = 3, Name = "Smart Home Technology"}

        );
    }

}
