# User manual

You can find the app on: http://currencyapp20160821015124.azurewebsites.net/   
Just select a date in the date picker and you will get currency differences between selected date and the date day before.   
Note that the app only works with the dates till the end of 2014.  
There is small depoyment bug, that you wont be able to see arrows for month changing in the calendar picker, just click on the upper corners of the picker to navigate :)   

# App choices

##Frontend: ##
**AngularJS** framework chosen for easy data retrieving, keeping losing structure of javascript files and future sctipts reusability and easier data visualization in the DOM   
**jQuery** chosen for the datepicker and some common functionality  
**bootstrap** chosen for easier app styling  

##Backend: ##  
.NET 4.5 framework as used for ability to access webApi
MVC architectural pattern was used for concept segregation.
**WebApi** is used for easier communication with the clinet side.    
Service refence was added for the communication with LB service.   

