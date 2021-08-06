using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PenaltyCalculation.Models.Concrete
{
  public class SpecialHoliday
  {
    [Key]
    public int Id { get; set; }

    
    public int CountryId { get; set; }

    
    public DateTime SpecialHolidayDate { get; set; }
  }
}
