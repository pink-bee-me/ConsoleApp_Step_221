using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Step_221
{
   public class User
    {
        public string GetInfo()
        {
            Console.WriteLine(" \n\n Enter Your First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("\n Enter Your Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("What Year Were You Born? ");
            string yourDob = Console.ReadLine();

            User user = new User(firstName,lastName,yourDob);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string YourDob { get; set; }

        public User(string firstName, string lastName, string yourDob)
        {
            FirstName = firstName;
            LastName = lastName;
            YourDob = yourDob;
        }

        public static void Introduce(string firstName)
        {
            Console.WriteLine(" Hello " + firstName + " !");
        }
    }
}
