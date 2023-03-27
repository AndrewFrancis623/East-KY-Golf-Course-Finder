using System;

namespace FinalProject 
{
    // Main Class
    public class Program 
    {
        // Start program
        static void Main(string[] args) 
        {
            GetAppInfo(); //Run GetAppInfo function 

            












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
