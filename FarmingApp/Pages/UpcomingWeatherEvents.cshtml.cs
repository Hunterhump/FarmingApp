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

            WeatherEvents.Add("April 8, 2024: Witness a rare event where the moves moves between the Earth and the sun, creating a beautiful solar eclipse.");
            WeatherEvents.Add("Record-Breaking Heat in February 2024: February 2024 was the hottest February since 1940.");
            WeatherEvents.Add("Above-Average Temperatures Forecasted for April-June 2024: The US National Oceanic and Atmospheric Administration predicts that most of the US" +
                "and Alaska will be hotter than usual from April to June, possibly making this year one of the hottest on record.");
            WeatherEvents.Add("End of El Nino Climate Pattern: The El Nino climate pattern, which has affected global weather since June 2023, is expected to end in 2024," +
                "possibly leading to changes in weather worldwide.");
            WeatherEvents.Add("Mixed Summer Temperature Outlook: While the upper Midwest might have normal temperatures," +
                " the rest of the country is expected to be hotter than usual this summer.");
            WeatherEvents.Add("Summer Precipitation Outlook: Expect drier-than-average conditions for most states west of the Mississippi River," +
                " while the Northeast is likely to experience substantially more rainfall than usual. This is similar to last year's weather patterns.");
            WeatherEvents.Add("Fire Risk Warning: The North American Seasonal Fire Assessment and Outlook warns of a possible increase in fires in 2024," +
                " with some fires from the record-breaking 45.7-million-acre season still burning. This could lead to more smoky skies in areas downwind of the fires.");
        }
    }
}
