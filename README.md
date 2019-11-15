# Twitter App
Simple project that uses the Twitter API to load tweets from a user and displays it on an application.

# Running the C# API
Open the `TwitterProject.sln` solution file in [Visual Studio](https://visualstudio.microsoft.com/downloads/). Right-click the `Web` project, and hit "Set as StartUp Project". Then hit the green run button in the toolbar. 
> If you don't have the .NET Framework 4.7.1 SDK installed, you can download the developer pack from [here](https://dotnet.microsoft.com/download/visual-studio-sdks?utm_source=getdotnetsdk&utm_medium=referral) 

# Running the Angular UI
Make sure you have Node installed on your computer. You should have at least version 8.9.x installed.

Ensure you have npm installed.

Navigate to the project using the terminal, and then go to `app > tda-project-ui`.

Install the necessary packages to run the project from that directory with `npm install`.

Install the Angular command line interface with `npm install -g @angular/cli`. You may need to restart your terminal to use the `ng` command.

Run the UI project by typing `ng serve`. Navigate to `http://localhost:4200/` to see the running front-end

# Using the project

Enter the secret API keys. Make sure there is no space appended to the beginning or end. Pick a User, tweet number, and "Load Tweets".
