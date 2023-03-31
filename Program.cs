using System;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace FinalProject;

// Main Class
public class Program
{
    
    // Start program
    static void Main(string[]args)
    {
        GetAppInfo(); //Run GetAppInfo function 

        while (true)
        {
            //Main Menu
            Console.BackgroundColor = ConsoleColor.Green;   
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                      East KY Golf Course Finder                                ");
            Console.WriteLine("________________________________________________________________________________");
            Console.ResetColor();


            Console.WriteLine("\nHello Golfer!");
            Console.WriteLine("\nIn order to find the right course for you we'll need a little info. \nPlease enter the number that corresponds to your skill level in the space below.");
            //ask skill level
            Console.WriteLine("\n\t1 Beginner: Just started, I don't know what par is." + "\n\t2 Intermediate: I play frequently, I can get close to par on a good day." + "\n\t3 Professional: I play alot, I'm usally under par.");

            //Get input from user
            string skilllevel = Console.ReadLine()!;

        

            List<Course> courses = new List<Course>()
            {
                new Course(){Name="Beaver Valley Golf Course", Skilllevel="Beginner", Phonenumber="(606) 874-2837", Address="49 Golf Course Rd, Allen, KY  41601-9433", Website="https://www.golflink.com/golf-courses/ky/allen/paul-hunt-thompson-golf-course" },
                new Course(){Name="Raven Rock Golf Course", Skilllevel="Intermediate", Phonenumber="(606) 219-4499", Address="586 Golf Course Lane, Jenkins, KY 41537", Website="https://www.ravenrockgolfcourse.com/" },
                new Course(){Name= "Stone Crest Golf Course", Skilllevel="Professional", Phonenumber="(606) 886-1006", Address="918 Clubhouse Dr, Prestonsburg, KY", Website= "https://www.stonecrestgolfcourse.com" },
            };
            
            if (skilllevel == "1")
            {
               
                foreach (var golfcourse in from golfcourse in courses where golfcourse.Skilllevel == "Beginner" select golfcourse)
                {
                    Console.WriteLine("\nThe best course for you would be:");
                    Console.WriteLine("{0} \nSkill Level:{1} \nPhone:{2} \nAddress:{3} \nWebsite:{4}", golfcourse.Name, golfcourse.Skilllevel, golfcourse.Phonenumber, golfcourse.Address, golfcourse.Website);
                    Console.WriteLine();
                    
                    //  object
                    BeginnerCourse sandTraps = new BeginnerCourse();


                    // Call warning method 
                    sandTraps.warning();

                    
                    Console.WriteLine("\nThere's " + sandTraps.Numberofsandtraps + " " + sandTraps.Typeofhazard);

                }
            }
            else if (skilllevel == "2")
            {
                foreach (var golfcourse in from golfcourse in courses where golfcourse.Skilllevel == "Intermediate" select golfcourse)
                {
                   
                    Console.WriteLine("\nThe best course for you would be:");
                    Console.WriteLine("{0} \nSkill Level:{1} \nPhone:{2} \nAddress:{3} \nWebsite:{4}", golfcourse.Name, golfcourse.Skilllevel, golfcourse.Phonenumber, golfcourse.Address, golfcourse.Website);
                    Console.WriteLine();

                    //  object
                    IntermediateCourse sandTraps = new IntermediateCourse();

                    // Call warning method 
                    sandTraps.warning();


                    Console.WriteLine("\nThere's " + sandTraps.Numberofsandtraps + " " + sandTraps.Typeofhazard);
                }
            }
            else if (skilllevel == "3")
            {
                foreach (var golfcourse in from golfcourse in courses where golfcourse.Skilllevel == "Professional" select golfcourse)
                {
                    Console.WriteLine("\nThe best course for you would be:");
                    Console.WriteLine("{0} \nSkill Level:{1} \nPhone:{2} \nAddress:{3} \nWebsite:{4}", golfcourse.Name, golfcourse.Skilllevel, golfcourse.Phonenumber, golfcourse.Address, golfcourse.Website);
                    Console.WriteLine();

                    //  object
                    ProfessionalCourse sandTraps = new ProfessionalCourse();

                    // Call warning method 
                    sandTraps.warning();


                    Console.WriteLine("\nThere's " + sandTraps.Numberofsandtraps + " " + sandTraps.Typeofhazard);
                }
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Entry!");
                Console.ResetColor();

            }
            
            // Ask if ready to exit or restart
            
            Console.WriteLine("\nWould you like to find another course? [Y or N]");
            
            // Get answer
            string answer = Console.ReadLine()!.ToUpper();

            if (answer == "Y")
            {
                continue;

            }
            else if (answer == "N")
            {
                return;
            }
            else 
            {
              
            }
            
        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Final Project";
            string appVersion = "1.6";
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