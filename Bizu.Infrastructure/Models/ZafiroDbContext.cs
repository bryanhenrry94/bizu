using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models
{
    public class ZafiroDbContext : DbContext
    {
        public DbSet<TbEmpresa> TbEmpresa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseNpgsql("Host=localhost;Port=5432;Database=zafiro;Username=postgres;Password=M1n0T4ur0");
    }

}
