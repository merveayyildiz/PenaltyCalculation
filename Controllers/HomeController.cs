using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PenaltyCalculation.Helper;
using PenaltyCalculation.Models;
using PenaltyCalculation.Repository.CountryRepo;
using PenaltyCalculation.Repository.SpecialHolidayRepo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PenaltyCalculation.Controllers
{
  public class HomeController : Controller
  {
    private readonly ISpecialHolidayRepository _specialHolidayRepo;
    private readonly ICountryRepository _countryRepository;
    Utilities uti;


    public HomeController(ISpecialHolidayRepository specialHolidayRepo, ICountryRepository countryRepository)
    {
      _specialHolidayRepo = specialHolidayRepo;
      _countryRepository = countryRepository;
      uti = new Utilities(_countryRepository, _specialHolidayRepo); ;
    }
    public ActionResult Index()
    {

      var countries = _countryRepository.Get();
      ViewBag.countryDropDownItems = uti.GetCountryItem(countries);
      return View();
    }

    [HttpPost]
    public ActionResult Index(InputModel model)
    {
      if (model.CheckOutDate>model.ReturnDate)
      {
        ViewBag.DateError = "Checkout date must be before than returned date !!";
        return View();
      }
      var result = uti.CalculatePenalty(model);
      ViewBag.result = result;

      var countries = _countryRepository.Get();
      ViewBag.countryDropDownItems = uti.GetCountryItem(countries);
      return View();
    }

  }
}
