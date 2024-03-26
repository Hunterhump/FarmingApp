# FarmingApp David Humphries
Project Overview

This application is a prototype for a climate data based web app based for farmers only in the United States.  Its main job is to help farmers out in regards to knowing the best time to plant their crops in order to maximize output of crops and efficiency of the farmer.  The web application prototype currently has a home/index page and a search page.  Currently, the button and search bar do not work on the second page as it is still in the early stages of development.

Page Description

So far for this web application, it has two pages.  It has a home page and a search page named SearchResults.cshtml.  Both pages have css and bootstrap.  I used the yeti bootstrap theme from bootswatch.com.  There is a lot of css throughout both pages of the assignment and you can look at that under the site.css folder.  Using css we added decorations to our table and also changed the lettering and style of different headers. Both pages are written in the Courier New, monospace font.  The three colors used on both pages are forest green, saddlebrown, and ivory.  

Home Page

The home page starts with a welcome message that is a h1 header that is bolded using a <strong> command.  The h1 header has saddle brown underline underneath it.  Beneath the h1 header is a h2 header that states the goal of the web application and it is also bolded using the <strong> command. Following the h2 header with our mission/goal is our <a anchor href link to our other page "SearchResults'' and the link says "start here."  In order for the link to be centered, I used a <center> command.  The last thing on the homepage is a picture of a large farm field.  For this, I also had to use a separate <center> command for it to be in the middle as if I did the <center> command along with the link above it just placed them next to each other and it does not look good.  

SearchResults Page

The SearchResults starts off with an h2 header that directs them to use the two search bars below to solve their issue.  Between the h2 header and the search bars however there are three emojis. I added the three emojis so it did not look so robotic and lame. The emojis are a rice plant, corn cob, and a potato.  I input these emojis by using a h2 align command and placed them in the center.  
Underneath the emojis are the two search bars. One of the search bars asked "where are you located" and the other asked "what crop are you planting."  These two search bars are not functional yet for searching but you are able to type in them.  Beneath the search bars is a functional button that you can click but it does not actually gather your location yet.  Following the button we have an h2 header that is the title for the table that follows it.  The table is simple but I used css to change the color  to forest green and width to 3px to make it look more appealing.  

Research Summary

The first website I am looking into is accuweather.com.
https://www.accuweather.com/en/us/morgantown/26505/weather-forecast/331473?city=morgantown is the url when I search Morgantown as the location.  There is a question mark in it and after is the query searched which was Morgantown.  There is a lot of bootstrap usage as to build the intricate website it must have it to customize the site and help make it responsive for the user. Another thing I noticed on this page is a large amount of CSS to create borders and words fonts that look good for the user.  I also noticed that the website has advertisements on it as well. One thing I like about this website is their header and how they have it so I will probably use something similar to this <div class="basic-header has-alerts  " style="visibility: hidden;">. I also liked the way they have their banner set up so I will probably use something similar <div class="alert-banner-container  "> <div id="banner-wrap" class="banner-wrap">. 

The second website I am looking into is https://www.farmersalmanac.com.
https://www.farmersalmanac.com/long-range-weather-forecast/northeast-us is the url for the website when I search up the northeastern part of the United States. There is no # or ? but there is / which indicates the path that is taken to get to a certain section of the website which in this case is the northeast.  This website does use a good amount of bootstrap and css to design and develop the page to their liking.  One element of this I liked was their search bar which I will definitely use something close to on my website <input type="search" class="search-field" placeholder="Search …" value="" name="s" title="Search for:">.  Another thing I like was that they have a drop down menu underneath the header for certain things and I like that <a class="fas fa-cloud-sun-rain mega-menu-link" href="https://www.farmersalmanac.com/weather" aria-haspopup="true" aria-expanded="false" tabindex="0">Weather<span class="mega-indicator" data-has-click-event="true"></span></a>.  

The third website I am looking into is weather.gov.
https://www.weather.gov/gld/AgricultureAndClimate is the url for the third website I will be researching.  This url also doesn't have any # or ? but it has a path to the agriculture and climate page as indicated by the /.  This site uses css to design and help make it look more appealing to the user as well as bootstrap to help the styling and customization of it.  One thing that I really like about this page is its hyperlinks to other parts of the site have pictures connected to them <img alt="WWA" src="/images/gld/ClimateAgPage/Capture(11).PNG" style="border-width: 2px; border-style: solid; width: 180px; height: 160px;" width:160px="">.  That is about all that I really like about their page cosmetics wise as it is a little bland.

https://github.com/heyitsdsp/Smart_Farming.git
The first GitHub resource I have found is Smart_Farming it is a cool app that he made to help make farmers' lives easier.  Some cool features of the app are natural disaster alerts and soil quality monitoring updates.  This application uses python and C++ for most of its coding but it has given me some cool ideas of different things to implement. One thing they have that I also want to add is the location detection feature where you click a button and it pings your location to tell you about the weather and how that could affect you as a farmer.

https://github.com/Alidante254/farmai
The second GitHub resource I have found is Farm-AI.  This app was created to help make farmers' lives easier and to help them optimize their production.  This application shows weather forecasts, rain prediction, crop recommendation, and farming techniques to use in certain weather. I would like to implement some of these as well for my app as well.  It has a wide variety of locations and crops as indicated by its data files, however for my app I believe I would like to focus more on the United States and the primary crops that are being planted here.

Future Improvements

In the future, I would like to make both search bars functional in order to take the users straight to what they search and provide them with the information they need regarding the input of them.  I also would like to make my button operational so that I can ping the precise location of the user so it can streamline the process and make it easier.  

Citations

https://chat.openai.com/
https://www.w3schools.com/
https://www.accuweather.com/
https://www.weather.gov 
https://www.farmersalmanac.com
https://github.com/Alidante254/farmai
https://github.com/Deshan555/IOT-Smart_Farming
Class lecture videos

Chat GPT Prompts used

How do you resize a picture on html
how to center align an image in html
how to design headers in html to look better

Reflection on References

All of my citations helped me greatly.  Being able to ask chat gpt a specific question about something I wanted to do really helped my ability to do this project with not too much difficulty.  My two most used resources were actually w3 schools and the lectures videos.  These helped me really set up the foundation of what I wanted to use on my app. The resources I used the least were the GitHub repositories.  They were good for coming up with ideas but I didn’t use them too much for the actual code.  


