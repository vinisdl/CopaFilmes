using CopaFIlmes.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace CopaFilmes.Repository
{
    public class InMemoryContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }
        public DbSet<WorldCup> WorldCups { get; set; }

        public InMemoryContext(DbContextOptions options)
            : base(options)
        {
        }

    }
}
