using System;
using SkillLevel;

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
                Console.WriteLine("***** East KY Golf Course Finder *****");
                Console.WriteLine("Hello Golfer! \nIn order to find the right course for you we'll need a little info. \nPlease enter the number that corresponds to your skill level in the space below.");
                Console.WriteLine("\t1 Begginer: Just started, I don't know what par is." + "\n\t2 Intermediate: I play frequently, I can get close to par on a good day." + "\n\t3 Professional: I play alot, I'm usally under par.");
                
                string skilllevel = Console.ReadLine(); //Get input from user


                if (skilllevel == "1")
                {
                    Console.WriteLine("correct");

                }
                else if (skilllevel == "Intermediate")
                {
                    Console.WriteLine("getting better");

                }
                else if (skilllevel == "Professional")
                {
                    Console.WriteLine("Hello Tiger Woods");

                }
                else 
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Invalid Entry");
                    Console.ResetColor();
                
                }

                // Ask if ready to exit or restart
                Console.WriteLine("Would you like to select another course? [Y or N]");

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
