using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace FarmingApp.Pages
{
    public class UpcomingWeatherEventsModel : PageModel
    {
        public List<string> WeatherEvents { get; set; }
        
        public void OnGet()
        {
            WeatherEvents = new List<string>();

            WeatherEvents.Add("April 8, 2024: Witness a rare celestial event as the moon passes between the Earth and the sun, creating a stunning solar eclipse.");
            WeatherEvents.Add("Record-Breaking Heat in February 2024: February 2024 set new records as the hottest February in recorded history, dating back to 1940.");
            WeatherEvents.Add("Above-Average Temperatures Forecasted for April-June 2024: According to the US National Oceanic and Atmospheric Administration, most of the " +
                "continental US and Alaska will experience above-average temperatures, setting the stage for a potentially record-setting hot year.");
            WeatherEvents.Add("End of El Nino Climate Pattern: The El Nino climate pattern, which has influenced global weather since June 2023, is expected to end in 2024, potentially leading to changes in weather patterns worldwide.");
            WeatherEvents.Add("Mixed Summer Temperature Outlook: While the upper Midwest may experience close-to-average temperatures, the rest of the country is forecasted to see above-average temperatures, continuing the trend from the winter season.");
            WeatherEvents.Add("Summer Precipitation Outlook: Expect drier-than-average conditions for most states west of the Mississippi River, while the Northeast is likely to experience substantially more rainfall than usual. This pattern mirrors last year's outcome, with a rainy northeast and a dry pacific northwest.");
            WeatherEvents.Add("Fire Risk Warning: The North American Seasonal Fire Assessment and Outlook warns of potential fire resurgence in 2024, with some fires from the record 45.7-million-acre season still smoldering. This could lead to more smoke-filled skies downwind of the flames.");
        }
    }
}
