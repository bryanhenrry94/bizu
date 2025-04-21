using Bizu.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

using var sourceDb = new DberpDbContext();
using var targetDb = new ZafiroDbContext();

await targetDb.Database.EnsureCreatedAsync();

var datos = await sourceDb.TbEmpresa.ToListAsync();
await targetDb.TbEmpresa.AddRangeAsync(datos);
await targetDb.SaveChangesAsync();
