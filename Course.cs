using System;
using System.Net.Mail;

namespace FinalProject
{
    public class Course
    {
        public string Typeofhazard = "Sandtraps";
        public string Transportation = "Golfcarts";
        public void warning()
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("WATCH OUT!");
            Console.ResetColor();   
        }
       

        public string? Name { get; set; }
        public string? Skilllevel { get; set; }
        public string? Phonenumber { get; set; }
        public string? Address { get; set; }
        public string? Website { get; set; }
        
        public Course(string rowData)
        {
            string[] data = rowData.Split(',');
            // Parse Data into properties
            this.Name = data[0];
            this.Skilllevel = data[1];
            this.Phonenumber = data[2];
            this.Address = data[3];
            this.Website = data[4];
        }
        
        public Course()
        {
        
        }
        
        public override string ToString()
        {
            string golfCourse =
                $"\nName: {Name} " +
                $"\nSkilllevel: {Skilllevel} " +
                $"\nPhonenumber: {Phonenumber} " +
                $"\nAddress: {Address} " +
                $"\nWebsite: {Website} ";
            return golfCourse;
        }
    }
}
