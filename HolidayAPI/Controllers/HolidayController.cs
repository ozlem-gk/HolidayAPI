using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace HolidayAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HolidayController : ControllerBase
    {
       

        [HttpGet]
        public IActionResult GetHolidays([FromQuery] string? country, [FromQuery] string? stateType, [FromQuery] string? holidayType, [FromQuery] int? month)
        {
            var holidays = StaticHoliday.Holidays.AsQueryable();

            if (!string.IsNullOrEmpty(country))
            {
                holidays = holidays.Where(h => h.CountryCode == country);
            }

            if (!string.IsNullOrEmpty(stateType))
            {
                holidays = holidays.Where(h => h.States != null && h.States.Any(s => s == stateType)).AsQueryable();
            }

            if (!string.IsNullOrEmpty(holidayType))
            {
                holidays = holidays.Where(h => h.Type == holidayType);
            }

            if (month.HasValue && month != 0)
            {
                holidays = holidays.Where(h => h.Date.Month == month.Value);
            }

            return Ok(holidays.AsQueryable());
        }
    }


   
}
