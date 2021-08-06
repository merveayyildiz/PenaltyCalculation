using Microsoft.EntityFrameworkCore;
using PenaltyCalculation.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PenaltyCalculation.Models
{
  public class PenaltyCalculationDbContext:DbContext
  {
    public PenaltyCalculationDbContext(DbContextOptions<PenaltyCalculationDbContext> options)
       : base(options)
    {
    }

    public virtual DbSet<Country> Country { get; set; }
    public virtual DbSet<SpecialHoliday> SpecialHoliday { get; set; }
  }
}
