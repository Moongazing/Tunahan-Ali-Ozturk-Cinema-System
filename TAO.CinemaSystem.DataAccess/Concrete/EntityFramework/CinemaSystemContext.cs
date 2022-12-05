using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using TAO.CinemaSystem.Entities.Concrete;

namespace TAO.CinemaSystem.DataAccess.Concrete.EntityFramework
{
  public class CinemaSystemContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Server =(localdb)\MSSQLLocalDB;Database =Cinema_System;Trusted_Connection=true");
    }
    public DbSet<Movie> Movies { get; set; }
  }
}
