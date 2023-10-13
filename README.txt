2023-10-12
1635
Created project
testing it... forgot ssl port
comment out //"sslPort": 44380
it works

1712 
um thinking....
Changing the names in layout to the company name

1729
Going to add the 'About Us' page and put it in the nav bar
need a new Razor page in the home views folder

1751
accidently used the defualt name "Index1.cshtml" and can't change it so I'll re make it
I actually realized it was because I had the page running was able to change it to "About.cshtml"
[9:09 AM]
1753
The page is currently empty just so i can set it up
adding to to nav bar using the layout page

1800
About us is in the nav but error "This localhost page can’t be found"....

1806 
Got the About us page to load needed to add a method to call it in the HomeController
taking break

1917
Coming up with company name I havent done that and just put "purseCompany" going back to layout to update it

1925
making a new css file and linking it in layout page
testing css...
it works! now gotta figure out how to style the page

2246
need a images and font folder making those now also comminting to github because i havent done that yet 
git repo created in github!

2251
Going to test adding an image within privacy page
trying to get this image to work but is not
why!!!

2326 
I figured out how to get the image to work, it just needed to be in the wwwroot
moving the fonts fold in wwwroot
grabbing a font to use for the website

2350
okay i downloaded a font i like, then converted it to a webfont and it works..
but it doesnt seem to be changing size 
i found a new font i like but it doesnt scale in font size either although this one is an ok size and it scales with screen size

2023-10-13

0015
continuing css

0127
pushing code

0131
creating the purse model
commiting before the initial create imigration incase something goes wrong

0246
need to install Microsoft.EntityFrameworkCore.SqlServer 3.1.5
it installed with 8 errors though and 4 warnings
Im just going to continute and see what happens
Just made data folder with MvcPurseContext.cs and i looked back and now the errors/warings are gone

0323 
can scaffold the pages now 
error with connectionStrings value currently is null
i cant figure out whats wrong going to clone from last push
[9:09 AM]
okay now need to re add the purse class
readd the  Microsoft.EntityFrameworkCore.SqlServer
ima be honest i dont know if it downloaded or not
i  put Install-Package Microsoft.EntityFrameworkCore.SqlServer in the NuGet package manager didnt do that before
re added data folder and MvcPurseConext class


0430 
getting really annoyed and its almost 5

0500 
Eurka I figured it out I dont need a data file in models one was made 
with the Asp.n
add this code in NuGet package manager
Add-Migration InitialCreate
Update-Database

Error beacuse there are two DbContext's
removed the data folder i made and initial migrate worked
testing....
relsized I never changed the path so doing that now

0517
The Purses page works

0633
Finished adding to seed data

0655
it wasnt addeing the data i had to change instances of MvcPurseContext with ApplicationDbContext but 
now im not authorized going to update database and see if that works 

0900 it wont seed the data

1200 
still wont seed the data re starting assignment PurseWeb
