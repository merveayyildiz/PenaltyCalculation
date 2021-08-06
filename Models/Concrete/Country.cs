using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PenaltyCalculation.Models.Concrete
{
  public class Country
  {
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public string CurrencyCode { get; set; }

    public decimal PenaltyAmount { get; set; }

    public string OffDay1 { get; set; }

    public string OffDay2 { get; set; }
  }
}
