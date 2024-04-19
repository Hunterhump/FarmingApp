###Farm Fam

##Project Overview
-This application is a prototype for a climate data-based web app for farmers only in the United States. The web application plans to assist farmers by creating farming plans, offering climate and weather prediction services, and giving farmers information on their crops. 

##Project Overview

This application is a prototype for a climate data-based web app for farmers only in the United States. The web application plans to assist farmers by creating farming plans, offering climate and weather prediction services, and giving farmers information on their crops. 

##Deployment Guide

#Step-by-Step Deployment
Clone the Repository: Clone the application repository from GitHub.
	-Use this link:
 
			https://github.com/Hunterhump/FarmingApp.git

Creating the Database: On our GitHub copy these SQL tables and stored procedures and execute them.

		-Using this link:
  
			https://github.com/Hunterhump/MIST-353-Project
   
Start with executing these files to initialize the database and create the tables.

  -FarmFamDB.sql
  
  -ClimatePredictionTable.sql
  
  -CropCompatibilityTable.sql
  
  -CropTable.sql
  
  -FarmingPlanTable.sql
  
Next, you will need to execute the following file in SQL to fill the databases with mock data:

  -DataEntry.sql
  
Lastly, you will need to add our stored procedures linked below:

  -DavidHumprhiesSP.sql
  
  -OliviaStaudSP.sql
  
  -PorterMartinSP.SQL
  
Configuring the Project: Running this project requires you to modify the database connection string in the “appsettings.json” file, found in:

  -FarmFamAPI/appsettings.json 
  
  -FarmingApp/appsettings.json
  
Running the Project: When starting the project make sure that the website launches along with the API services to analyze both the APIs and web app. This is done by opening the (Configure Start-Up Projects) drop-down menu. 

#Pitfalls

To avoid any errors make sure that the SQL database is running without errors before you try running the web application.
Make sure the database strings are connected additionally as our group encountered many errors before fixing the issue.

#Where to Find Help

For most of our issues, we relied on our professor's recorded lectures, W3 Schools, and ChatGPT.
You can find the prompts in the other (Readme.md) files in the repositories.

##APIs
CropDetails: Retrieves details of all crops in the database. Users can access information like CropID, CropName, CropType, and PredictionID. The inputs for this API would require typing in the crop you seek more information on in the search bar and then the outputs would give you information such as the crops id on our page, and the type of crop it is.

ClimatePrediction: Retrieves climate predictions based on the user’s address, which they input. Users can get predictions for their chosen state including things like Temperature and Rainfall.  The inputs for this API are either typing in your address or a state into the search bar.  Then the outputs would come out and give you the prediction ID, temperature, and rainfall for that area. 

ClimatePredictionByState: Retrieves climate predictions for the entire state in which the user searches.  The input for this API will be a state in the United States, and then the output will give you the temperatures throughout the state and rainfall numbers.  

CropCompatibility: Users can view compatibility details between different crops. (CompID, CropID1, CropID2)  For this API you will need to provide the CropId’s of two different crops and type them into the search bar provided and then it will return an output telling you whether or not it will work planting them next to each other.  The terms it will reply with for the output are good, fair, and poor. 

FarmingPlanByComp: Retrieves farming plans based on compatibility (‘Good’, ‘Fair’, ‘Poor’).  This API will compare the farming plan of the farmer and tell them whether or not it will work. The inputs will be the compId’s then it will output with whether the plan is good, fair, or poor.

CropTempLimit: Temperature limits for crops. When users input a crop name, they can receive temperature limit information.  For this API, all you need to do is input your crop name or cropID and then the output will come out and give you the low-temperature point and the high-temperature point for the crop.  This will give the farmer the optimal temperatures in between for planting and maintaining the crops. 

##Razor Pages 

Homepage-David
This is the first page you see when you open the webpage.  All you see on this page is a welcome message, a picture, and a link to our search results page. 

SearchResults-David 
This is the second page you will see after clicking the link on the homepage.  This page is where you will decide what you need to search or know.  There are hyperlinks to each of our APIs to search such as climate prediction, crop details, farming plan, and crop compatibility as well as our about us and privacy page.  Another thing on this page is a table listing the most popular crops planted in the USA and the month they are planted.  Lastly, on the page is an API where you can search crop limits.

AboutUs-David
This page details our authors and what our page is about.  Also, describes why we decided to make this page.  All of the creator's headshots are on this page as well. 

Privacy-David
This just contains our company's privacy statement.

FarmingPlan-David
This is where you would input your comp IDs into the search bar to get your farming plan.

CropDetails (CropDetails API) - Porter
The crop details page uses the CropDetails API created by our group. It features a search bar where the user inserts the name of the crop they wish to see described. The program then displays information like CropID, CropName, CropType, and PredictionID. This information can be used in the CropComp API as well.

CropComp (CropComp API) - Porter 
The crop compatibility page of our web application prompts the user to enter their desired crop and then gives the user a list of other crops that are compatible with the crop the user entered. The list will also rate which crops work best with the user-inserted crop, rating the compatibility from poor, fair, and good.




