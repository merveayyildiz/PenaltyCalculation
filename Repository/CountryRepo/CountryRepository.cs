using PenaltyCalculation.Models;
using PenaltyCalculation.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PenaltyCalculation.Repository.CountryRepo
{
  public class CountryRepository : ICountryRepository
  {
    private readonly PenaltyCalculationDbContext _dbContext;

    public CountryRepository(PenaltyCalculationDbContext dbContext)
    {
      _dbContext = dbContext;
    }
    
    public List<Country> Get()
    {
      return _dbContext.Country.ToList();
    }
  }
}
