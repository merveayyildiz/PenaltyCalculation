using Microsoft.AspNetCore.Mvc.Rendering;
using PenaltyCalculation.Models;
using PenaltyCalculation.Models.Concrete;
using PenaltyCalculation.Repository.CountryRepo;
using PenaltyCalculation.Repository.SpecialHolidayRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PenaltyCalculation.Helper
{


  public class Utilities
  {
    private  readonly ICountryRepository _countryRepository;
    private  readonly ISpecialHolidayRepository _specialHolidayRepository;
    public Utilities(ICountryRepository countryRepository, ISpecialHolidayRepository specialHolidayRepository)
    {
      _countryRepository = countryRepository;
      _specialHolidayRepository = specialHolidayRepository;
    }
    public  List<SelectListItem> GetCountryItem(List<Country> countries)
    {
      var countryDropDownItems = new List<SelectListItem>();
      foreach (var countryItem in countries)
      {
        countryDropDownItems.Add(new SelectListItem
        {
          Text = countryItem.Name,
          Value = countryItem.Id.ToString()
        });
      }
      return countryDropDownItems;
    }

    public  string CalculatePenalty(InputModel model)
    {
      
      decimal penalty = 0;

      Country country = _countryRepository.Get().FirstOrDefault(p => p.Id == model.CountryId);

      List<SpecialHoliday> specialDays = _specialHolidayRepository.Get().Where(p => p.CountryId == model.CountryId).ToList();

      for (DateTime date = model.CheckOutDate; model.ReturnDate.CompareTo(date) > 0; date = date.AddDays(1.0))
      {
        List<SpecialHoliday> specialHolidays = specialDays.Where(p => p.SpecialHolidayDate.Month == date.Month && p.SpecialHolidayDate.Day == date.Day).ToList();

        if (specialHolidays.Any() || date.DayOfWeek.ToString() == country.OffDay1 || date.DayOfWeek.ToString() == country.OffDay2) //
        {
          continue;
        }
        penalty += country.PenaltyAmount;
      }
      string output = $"Your Penalty Amount: {penalty} {country.CurrencyCode}";
      return output;
    }
  }
}
