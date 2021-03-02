# kataBabySitter-2021-repo

This kata simulates a babysitter working and getting paid for one night. The rules are pretty straight forward.

The babysitter:

starts no earlier than 5:00PM
leaves no later than 4:00AM
gets paid $12/hour from start-time to bedtime
gets paid $8/hour from bedtime to midnight
gets paid $16/hour from midnight to end of job
gets paid for full hours (no fractional hours)


This consists of two projects working together. One is .net core 5.0 web api back-end, and the other is Angular 11 front-end.
To run these projects:

- After cloning OR downloading, Open the projects in two different Visual Studio Sulutions. (I used Visual Studio 2019)
- Build the solutions.

- Run the back-end application. (It should give you a welcoming message on the browser which is; "Welcome to Kata Baby-Sitter Daily Pay Calculator BackEnd!").
    - The backend application consists of 4 projects (Api, BOL, BLL, and Test).

- To run the front-end application, first you need to have node.js. and Angular CLI installed on your machine. 
    - Right-click the project on the solution and "Open Folder in File Explorer" and copy the file path
    - Run Developer Command Prompt for Visual Studio 2019 as Administrator
    - Change director -- cd. And paste the copied file path of the front-end project you copied. Hit Enter. 
    - Build the Angular Application by typing "ng build" in the command prompt
    - Type "ng serve" to serve the application on the browser.
    - When "Compiled Successfully" on the Developer Command Prompt, run the application in Visual studio
    - Change the browser address to "http://localhost:4200".
    - For the KataBabySitter_UI application to work, you need to have the KataBabySitter_BackEnd application running.


I have developed this application using 
