using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
    {

        public string sweepstakesName;

        Random rnd;
        int lotteryNumber;

        Contestant contestant;

        Dictionary<string, int> contestantList;

        public Sweepstakes()
        {
            rnd = new Random();
            
            contestantList = new Dictionary<string, int>();
        }

       
        public void SweepstakesName(string SweepstakesName)
        {

            sweepstakesName = SweepstakesName;

            Console.WriteLine("Welcome to DevCodeCamp Sweepstakes Creator!");
            Console.WriteLine("------------------------");
            Console.WriteLine("Please enter the name of the sweepstakes you would like to create below.");
            Console.WriteLine("------------------------");
            sweepstakesName = Console.ReadLine();
            Console.WriteLine("------------------------");

            RegisterContestant(contestant);
        }

        public void RegisterContestant (Contestant Contestant)
        {
            
            Console.WriteLine("Would you like to register for "+sweepstakesName+" sweepstakes?");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Yes");
            Console.WriteLine("------------------------");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                
                Console.WriteLine("Please enter your name below.");
                Console.WriteLine("------------------------");

                string contestantName = Console.ReadLine();
                Console.WriteLine("------------------------");
                Console.WriteLine("How old are you "+contestantName+"?");
                Console.WriteLine("------------------------");
                int contestantAge = Convert.ToInt32(Console.ReadLine());

                if (contestantAge < 16)
                {
                    Console.WriteLine("I'm sorry. You have to be at least 16 to register for a sweepstakes. Thank you. Have a good day!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                Console.WriteLine("------------------------");
                Console.WriteLine("Thank you "+contestantName+" for registering!");
                Console.WriteLine("------------------------");
                lotteryNumber = rnd.Next(1, 11);
                Console.WriteLine(contestantName+" your lottery number is "+lotteryNumber);
                Console.WriteLine("------------------------");
                contestant = new Contestant(contestantName, contestantAge, lotteryNumber);
                contestant = Contestant;

                contestantList.Add(contestantName, lotteryNumber);

                PrintContestantInfo(contestant);

                Operations();

            }

        }


        public void Operations()
        {
            Console.WriteLine("Would you like to register another contestant for "+sweepstakesName+"?");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.WriteLine("------------------------");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                RegisterContestant(contestant);
            }
            else if (choice == 2)
            {
                // insert other functions
            }
            else
            {
                Console.WriteLine("Please enter the the numerical value associated with your decision!");
                Console.WriteLine("------------------------");
                Operations();
            }
        }
        

        //public string PickWinner()
        //{

            
        //}

        public void PrintContestantInfo(Contestant contestant)
        {

            Console.WriteLine(sweepstakesName+" Contestant List");
            Console.WriteLine("-----------------------");
            foreach (KeyValuePair<string, int> contestantView in contestantList)
            {
                Console.WriteLine("|Name: {0} |Lotto #: {1}", contestantView.Key, contestantView.Value);
            }
            Console.WriteLine("-----------------------");
        }

        

    }
}
