# Assignment 4

## Table of Contents

1. [Overview](#overview)
2. [User Experience](#user-experience)
3. [Stored Procedures](#stored-procedures)
4. [APIs](#apis)
5. [External API](#external-api)
6. [ChatGPT Prompts](#chatgpt-prompts)

## Overview
For this assignment, our main focus was to enhance our application by creating APIs based on stored procedures. We updated existing stored procedures and created new APIs to improve the user interaction and experience.

## User Experience
The user experience of this application includes 6 pages – 3 dynamic, which integrate APIs, and 3 static. The dynamic pages are ClimatePrediction, CropTempLimit, and FarmingPlanbyComp.

## Stored Procedures
### We changed 3 of our stored procedures from the previous assignment in order to add dynamics. We used the following stored procedures for this assignment:

1. ClimatePredictionByState: Retrieves climate predictions based on the user's state input. (David Humphries)

2. ClimatePredictionsNew: Retrieves general climate predictions. (Porter Martin)

3. CropService: Retrieves the details of all crops in the database. (David Humphries)

4. GetClimatePredicitions: Retrieves all climate predictions in the database. (Porter Martin)

5. CropCompatibility: Retrieves crop compatibility available in the database. (Olivia Staud)

6. FarmingPlansByCompatibility: Retrieves farming plans based on compatibility data. (Olivia Staud) 

## APIs
1. CropService: Retrieves details of all crops in the database. Users can access information like CropID, CropName, CropType, and PredictionID.
2. ClimatePrediction: Retrieves climate predictions based on the user’s state, which they input. Users will be able to get predictions for their chosen state including things like Temperature and Rainfall. 
3. CropCompatibility: Users can view compatibility details between different crops. (CompID, CropID1, CropID2)
4. FarmingPlanByComp: Retrieves farming plans based on compatibility (‘Good’, ‘Fair’, ‘Poor’)
5. CropTempLimit: Temperature limits for crops. When users input a crop name, they can receive temperature limit information.
6. WeatherForecast: Provides weather forecast data for demonstration purposes until the external API is implemented.


## External API
To enhance the Climate Prediction Table, our plan is to integrate an external API to provide real-time temperature data. Once this is done, it will improve the accuracy of the climate predictions given to users.

## Citations
A major source that helped us get through this assignment is the lecture recordings, specifically the recording from 2/27. Being able to go through the process step-by-step, pausing and rewinding, let us have a better understanding of the content.

ChatGpt Prompts:

1. On visual studio it gave me this error code, what does it mean and how do I fix it? Cannot implicitly convert type 'System.Collections.Generic.List<FarmFamAPI.Entities.Crop>' to 'Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.List<FarmFamAPI.Repositories.CropTempLimit>>'

2. How do you code a static api from a stored procedure in visual studio?

3. How do you incorporate an external API for climate or weather forecasting
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FarmFamAPI.Entities;
using FarmFamAPI.Repositories;
namespace FarmFamAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimatePredictionByStateController : ControllerBase
    {
        private readonly IClimatePredictionServiceByState climatePredictionService;

        public ClimatePredictionByStateController(IClimatePredictionServiceByState climatePredictionService)
        {
            this.climatePredictionService = climatePredictionService;
        }

        [HttpGet("{state}")]
        public async Task<ActionResult<List<ClimatePrediction>>> GetClimatePredictionsByState(char state)
        {
            var climatePredictionsByState = await climatePredictionService.GetClimatePredictionsByState(state);
            if (climatePredictionsByState == null)
            {
                return NotFound();
            }
            return climatePredictionsByState;
        }
    }
} 

4. Can you tell me what is wrong with this code in visual studio?
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FarmFamAPI.Entities;
using FarmFamAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FarmFamAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CropCompatibilityController : Controller
    {
        private readonly ICropCompatibilityService cropCompatibilityService;

        public CropCompatibilityController(ICropCompatibilityService cropCompatibilityService)
        {
            this.cropCompatibilityService = cropCompatibilityService;
                }

        
    }
    [HttpGet]
    public async Task<List<CropCompatibilityService>> GetCropCompatibility();
     {
            var cropCompatibilityService = await cropCompatibilityService.GetCropCompatibility();
            if (cropCompatibilityService == null)
            {
                return NotFound();
}
return CropCompatibilityService;
        }
}
}

5. What is wrong with this code?
   EXEC sp_executesql @SQL, N'@CompData NVARCHAR(10)', @CompData
END
Msg 156, Level 15, State 1, Procedure GetClimatePredictionsByState, Line 15 [Batch Start Line 0]
Incorrect syntax near the keyword 'PROC'.
Msg 134, Level 15, State 1, Procedure GetClimatePredictionsByState, Line 20 [Batch Start Line 0]
The variable name '@SQL' has already been declared. Variable names must be unique within a query batch or stored procedure.
Msg 137, Level 15, State 2, Procedure GetClimatePredictionsByState, Line 25 [Batch Start Line 0]
Must declare the scalar variable "@CompData".

6. Can you explain to me what these error codes mean and provide a solution to fix them?




