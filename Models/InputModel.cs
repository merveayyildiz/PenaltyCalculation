using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PenaltyCalculation.Models
{
  public class InputModel
  {
    [Required(ErrorMessage = "Please Enter CheckOut Date")]
    public DateTime CheckOutDate { get; set; }

    [Required(ErrorMessage = "Please Enter Book Return Date")]
    public DateTime ReturnDate { get; set; }

    public int CountryId { get; set; }
  }
}
