using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PenaltyCalculation.Models.Concrete;

namespace PenaltyCalculation.Repository.SpecialHolidayRepo
{
  public interface ISpecialHolidayRepository
  {
    List<SpecialHoliday> Get();

  }
}
