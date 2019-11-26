						**********   Thank You  **********
Thank you for taking the time to look at my application. 
The following ReadMe file is aimed at detailing the steps required to Build, Run 
and Test the source code. 

The application was writing using VS19, C# and .Net framework 4.7.2

The test where writing using both the MSUnit and NUnit framworks. 
Although the tests are the same in principal it was unsure as to the 
available testing framework at Iceland. 

						********** How To Build **********
Once the github has been cloned please ensure that the Nuget package for 
NUnit have been installed to the IcelandProductTest.NunitTest. 

The NUnit framework that was used in development was NUnit3 version number 3.12.0
also required with the NUnit3TestAdaptor version 3.15.1

After both of these Nuget packages have been installed within the application 
then the application should be able to build without any errors.

If you are unsure on building an application and are using Visual Studio 
please select build from within the top menu and then build solution. 

						**********  How To Run  **********
After the build has been successful, please ensure that the
IcelandProductTest.Console has been selected as the startup project. 

The quickest way to check is to the look at the solution explorer and 
check if the IcelandProductTest.Console has a bold look to the text. 

If this is not the case then there is a number of ways which that can be 
set as the startup project. 

1.	Using Solution Explorer highlight the IcelandProductTest.Console and right click
	about half way down (just after Manage Nuget Packages) you will see 
	Set as Start up Project. Go Ahead and select this.

2.	Again using Solution Explorer highlight the solution at the top and again 
	right click. Half way down, again, after Manage Nuget Package you should be 
	able to see Set startup projects. This will open a new window which will detail
	all of the projects within the solution. Selecting the first dropdown list find 
	IcelandProductTest.Console and select this to be set as the startup project.

3.	Another way which to set the startup project is to highlight the solution from
	the solution explorer and go to the project option in the top menu. Around half
	way down you will see Set StartUp Projects, this will option the same popup
	windows as option 2. Following the same steps go ahead and select 
	IcelandProductTest.Console to be set as the StartUp Project.

Even if you were not required to follow in the 3 steps above 
you can now go ahead and push the play button or start and 
the console application will appear. 

						********** How To Test  **********

I have developed the application with a number of way to test. Firstly you could 
use the console applcation to manually and visually check the results against the 
expected results giving in the test. 

While this test will only allow for the main method and information to be tested
I have also included extra test with the MSUnit and NUnit tests. The NUnit test
require the NUnit Nuget packages install as previously mentioned. 

Both the MSUnit and NUnit test have tests to ensure the IncreaseQuality and 
DecreaseQuality methods have been tested. 

In order to perform both the MSUnit and NUnit test you will need to go to the 
Test option in Visual Studio and open the test explorer. 
This will then check the solution and locate all the tests with 
the appropriate data annotations. 

This should locate both the IcelandProductTest.MSUnitTest and
IcelandProductTest.NUnitTest. Should both of these tests be located you can simply
select the required individual test or select all and run the tests. 