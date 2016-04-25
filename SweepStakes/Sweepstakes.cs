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

        public Sweepstakes()
        {
            rnd = new Random();
            lotteryNumber = rnd.Next(1, 11);
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

                string name = Console.ReadLine();
                Console.WriteLine("------------------------");
                Console.WriteLine("How old are you "+name+"?");
                Console.WriteLine("------------------------");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------");
                Console.WriteLine("Thank you "+name+" for registering!");
                Console.WriteLine("------------------------");
                
                Console.WriteLine(name+" your lottery number is "+lotteryNumber);
                Console.WriteLine("------------------------");
                contestant = new Contestant(name, age, lotteryNumber);
                contestant = Contestant;


                Console.WriteLine("|Name: "+name+" |Age: "+age+" |Lotto #: "+lotteryNumber+" |");

            }

        }

        

        //public string PickWinner()
        //{

            
        //}

        public void PrintContestantInfo(Contestant contestant)
        {

        }

    }
}
