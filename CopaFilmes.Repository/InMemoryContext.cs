using Microsoft.EntityFrameworkCore;
using System;

namespace CopaFilmes.Repository
{
    public class InMemoryContext : DbContext
    {

        public InMemoryContext(DbContextOptions options)
            : base(options)
        {
        }

    }
}
