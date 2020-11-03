using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FYTT.models;

namespace FYTT.Data
{
    public class FYTTContext : DbContext
    {
        public FYTTContext (DbContextOptions<FYTTContext> options)
            : base(options)
        {
        }

        public DbSet<FYTT.models.Form> Form { get; set; }
    }
}
