# Parse the Parcel #

At Trade Me we're looking to make selling items even easier and so we've decided to build our very own package shipping network. We've dug a tunnel between the North and South Islands that enables us to offer the same rates for parcels sent anywhere in the country, and we've just finished fueling up our fleet of courier vans; all that remains to be done is to update the website so that users can be advised how much their items will cost to send.

Our new service shipping costs are based on size and we offer different prices for small, medium, and large boxes. Unfortunately we're currently unable to move heavy packages so we've placed an upper limit of 25kg per package.

| Package Type | Length | Breadth | Height | Cost |
| --- | --- | --- | --- | --- | --- |
| Small | 200mm | 300mm | 150mm | $5.00 |
| Medium | 300mm | 400mm | 200mm| $7.50 |
| Large | 400mm | 600mm | 250mm | $8.50 |

## Coding Exercise ##

We need you to implement a component that, when supplied the dimensions (length x breadth x height) and weight of a package, can advise on the cost and type of package required. If the package exceeds these dimensions - or is over 25kg - then the service should not return a packaging solution.

### Guidelines ###

You will be expected to produce a solution that solves the above problem. While this is a simple component we would expect it demonstrate anything you’d normally require for a production ready and supportable solution - so think about standards, legibility, robustness, reuse etc. What we don’t require is a fancy user interface - a simple **command line** or **test harness** will suffice.

You are free to choose how you implement the solution though your choices should ideally align with your skills and the role you are applying for. You are welcome to make assumptions about the solution along with any improvements you think enhance or add value to the solution - though please be aware of the original scope.

### Submissions ###

We will send you an invite to our Bitbucket git repository where you can commit or upload your code. Once finished let us know via email and we’ll take a look.

Best of luck, and we look forwards to your response!

###Created by Leon Ren###
leon-ren.com | @liangren64@gmail.com


###Main Technology Stack###
MVVM Design
React
dotnet.core
dotnetify
SignalR
material-ui
nginx

See a live demo on leon-ren.com or 128.199.152.91

###Function###
Accept Length, Breadth, Height and Weight and output delivery cost if fit in.

#Development platform###
This project is build with Visual Studio 2017, with a 3rd party library dotnetfiy which required SignalR.

###Test Process###
To run the Front-end Project
1 npm install
2 webpack-dev-server
3 Left log in dispatchState to see state sent to View Model backend.


To run the entire project
1 webpack --config

2 ASP.NET Core:
PM> Install-Package DotNetify.Core -pre
PM> Install-Package DotNetify.SignalR -pre

3 Run Debug with VS2017

###To Publish to Linux server###
1 Defect exists when publishing with FTP using VS2017, no folder upload, need use vs2015
2 Need to modify Program.cs to stop running from IIS,


###Futher Improve###
1 Could add Promise to dotnetify
2 Use Redux to manage state
3 Test with Ava
4 Set rule with ESLint
5 Connect with DB(MongoDB on linux)
