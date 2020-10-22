using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Step_221
{
   public class User
    {

        public User()
        {
            GetInfo();
            Introduce(firstName);
        }

        public User(string firstName, string lastName, string yourDob)
        {
            FirstName = firstName;
            LastName = lastName;
            YourDob = yourDob;
            }

        public string GetInfo()
        {
            Console.WriteLine(" \n\n Enter Your First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("\n Enter Your Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("\n Enter The Year You Were Born: ");
            string yourDob = Console.ReadLine();
            
            Console.WriteLine(" You Entered: " + firstName + " " + lastName + " " + yourDob);

        }

      

        public void Introduce(string firstName)
        {
            Console.WriteLine(" Hello " + firstName + " !");
        }

        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string YourDob { get; set; }

      

        
    }
}
