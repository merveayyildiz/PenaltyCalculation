using PenaltyCalculation.Models;
using PenaltyCalculation.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PenaltyCalculation.Repository.SpecialHolidayRepo
{
  public class SpecialHolidayRepository : ISpecialHolidayRepository
  {
    private readonly PenaltyCalculationDbContext _dbContext;

    public SpecialHolidayRepository(PenaltyCalculationDbContext dbContext)
    {
      _dbContext = dbContext;
    }
    
    public List<SpecialHoliday> Get()
    {
        return _dbContext.SpecialHoliday.ToList();
      
    }
  }
}
