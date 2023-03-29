using System;
using System.Collections.Generic;




namespace FinalProject 
{
    // Main Class
    public class Program 
    {
       

        // Start program
        static void Main(string[] args) 
        {
            GetAppInfo(); //Run GetAppInfo function 
          
            while(true) 
            {
                //Get skill level
                Console.WriteLine("=============================================================================");
                Console.WriteLine("\t\tEast KY Golf Course Finder");
                Console.WriteLine("=============================================================================");
                
                Console.WriteLine("\nHello Golfer!");
                Console.WriteLine("\nIn order to find the right course for you we'll need a little info. \nPlease enter the number that corresponds to your skill level in the space below.");
              
                Console.WriteLine("\n\t1 Begginer: Just started, I don't know what par is." + "\n\t2 Intermediate: I play frequently, I can get close to par on a good day." + "\n\t3 Professional: I play alot, I'm usally under par.");
                

                //Get input from user
                string skilllevel = Console.ReadLine(); 


                List<BegginerCourse> BegginerCourseList = new List<BegginerCourse>();
                BegginerCourseList.Add(new BegginerCourse("Beaver Valley Golf Course", "Professional", 1234, "123 Lane", "www.website.com"));

                List<IntermediateCourse> IntermediateCourseList = new List<IntermediateCourse>();
                IntermediateCourseList.Add(new IntermediateCourse("StoneCrest", "Professional", 1234, "123 Lane", "www.website.com"));

                List<ProfessionalCourse> ProfessionalCourseList = new List<ProfessionalCourse>();
                IntermediateCourseList.Add(new IntermediateCourse("RavenRock", "Professional", 1234, "123 Lane", "www.website.com"));


                if (skilllevel == "1")
                {
                    foreach (var golfcourse in BegginerCourseList)
                    {
                        Console.WriteLine("\nThe best Course for you would be:");
                        Console.WriteLine("{0} \nSkill Level:{1} \nPhone:{2} \nAddress:{3} \nWebsite:{4}", golfcourse.Name, golfcourse.Skilllevel, golfcourse.Phonenumber, golfcourse.Address, golfcourse.Website);

                    }
                    

                }
                else if (skilllevel == "2")
                {
                    foreach (var golfcourse in IntermediateCourseList)
                    {
                        Console.WriteLine("\nThe best Course for you would be:");
                        Console.WriteLine("{0} \nSkill Level:{1} \nPhone:{2} \nAddress:{3} \nWebsite:{4}", golfcourse.Name, golfcourse.Skilllevel, golfcourse.Phonenumber, golfcourse.Address, golfcourse.Website);

                    }


                }
                else if (skilllevel == "3")
                {
                    foreach (var golfcourse in ProfessionalCourseList)
                    {
                        Console.WriteLine("\nThe best Course for you would be:");
                        Console.WriteLine("{0} \nSkill Level:{1} \nPhone:{2} \nAddress:{3} \nWebsite:{4}", golfcourse.Name, golfcourse.Skilllevel, golfcourse.Phonenumber, golfcourse.Address, golfcourse.Website);

                    }

                }
                else 
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Invalid Entry");
                    Console.ResetColor();
                
                }

                // Ask if ready to exit or restart
                
                Console.WriteLine("\nWould you like to find another course? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;

                }
                else if (answer == "N")
                {
                    return;
                }
                else { }

            }






            // Get and display app info
            static void GetAppInfo()
            {
                // Set app vars
                string appName = "Final Project";
                string appVersion = "1.0";
                string appAuthor = "Andrew Francis";

                // Change text color
                Console.ForegroundColor = ConsoleColor.Cyan;

                // Write out app info
                Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

                // Reset Color
                Console.ResetColor();

            }
          

        }


    }


}
