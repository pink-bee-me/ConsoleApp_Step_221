using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Step_221
{
    class US_StateSide_Terrorism
    {
        public void GetInfo()
        {
            Console.WriteLine(" \n\n Enter Your First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("\n Enter Your Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("\n Enter The Year You Were Born: ");
            string yourDob = Console.ReadLine();

        }



        public void TerroristEvent()
        {
            Console.WriteLine(
                "Choose An Event... \n Press 1 : Oklahoma City Bombing / Alfred P. Murrah Federal Building \n" +
                " Perpetrators: Timothy McVeigh, Terry Nichols \n" +
                "  Motives: Ruby Ridge, Waco Siege \n\n" +
                " Press 2 : Waco Siege / David Koresh and the Branch Davidians vs. American Federal, State and Military forces, including the FBi and ATF \n\n" +
                " Press 3 : President Reagan Assassination Attempt / Failed Assassination Attempt from would-be assassin John Hinckley ( who was trying to win the affection of movie star Jodi Foster) \n\n" +
                " Press 4 : Assassination of President John F. Kennedy / Died in Parkland Hospital Dallas, Texas.\n " +
                " Perpetrator: Lee Harvey Oswald was the assassin, and then... Jack Ruby (a night club owner) killed Lee Harvey Oswald. \n " +
                " Motive: Plenty of Conspiracy Theories involving any number of parties that could possibly have wanted President Kennedy dead. These speculations include a wide range of suspects from the Mafia  to the FBI and CIA and all the way back around to The Cuban President, Fidel Castro and /or the Russian KGB !!!\n\n ");

            int EventPick = Convert.ToInt32(Console.ReadLine());

            YourAge(User.yourDob,EventPick);

        }

        public int YourAge(int YourDOB, int EventPick)
        {
            EventPick = 0;
            switch (EventPick)
            {
                case 1:
                    EventYear = 1995;
                    break;
                case 2:
                    EventYear = 1993;
                    break;
                case 3:
                    EventYear = 1981;
                    break;
                case 4:
                    EventYear = 1963;
                    break;
                default:
                    Console.WriteLine("You did not choose a value,...You snooze , you lose! Sorry. The End.");
                    break;
            }
            int YourAge = EventYear - YourDOB;
            Console.WriteLine(" The Year Was: " + EventYear + "\n The Event Was: " + EventPick + "\n What Birthday Would You Be Celebrating this year? " YourAge +"\n");

        }






        public int Pick { get; set; }
        public int YourDOB { get; set; }
        public int EventYear { get; set; }


        {
        }

    }
