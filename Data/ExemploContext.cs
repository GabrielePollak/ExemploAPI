using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Exemplo.Models;

namespace Exemplo.Data
{
    public class ExemploContext : DbContext
    {
        public ExemploContext (DbContextOptions<ExemploContext> options)
            : base(options)
        {
        }

        public DbSet<Exemplo.Models.Person> Person { get; set; }
    }
}
