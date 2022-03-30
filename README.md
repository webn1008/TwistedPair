# TwistedPair
This app will tell you which colored pair to use in your phone installation. For reference, when an installer is at the pole or the pedastal where the house line connects to the main line, they have to find which pair to connect to the house's line. Typically this is a 25 pair line. 
- The app was created in VS2019 with .NET 5.0.
- This project includes a "master loop" that asks the user for a numerical input betweeen 1 and 25. 
- Once they input their selection, it will read from a JSON file with 2 color arrays and uses a list for each to find the correct combination, then outputs to the console which colored pair is associated to their selection using a switch statement. I used Newtonsoft.Json for working with the file.
- It also logs the user input and any associated output to a text file, adding the current date and time to the log. 
