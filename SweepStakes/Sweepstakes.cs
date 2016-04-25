using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes : Contestant
    {

        public string sweepstakesName;

        Random rnd;

        int winningLottoNumber;

        Contestant contestant;

        Dictionary<string, int> contestantDictionary;

        List<Contestant> contestantList;

        public Sweepstakes()
        {
            rnd = new Random();
            
            

            contestant = new Contestant();

            contestantList = new List<Contestant>();
            
        }


        public void Introduction()
        {
            Console.WriteLine("Welcome to DevCodeCamp Sweepstakes Creator!");
            Console.WriteLine("------------------------");
            SweepstakesName(sweepstakesName);
        }

        public void SweepstakesName(string SweepstakesName)
        {

            sweepstakesName = SweepstakesName;

            PreregisteredContestants();

            Console.WriteLine("Please enter the name of the sweepstakes you would like to create below.");
            Console.WriteLine("------------------------");
            sweepstakesName = Console.ReadLine();
            Console.WriteLine("------------------------");

            RegisterContestant(contestant);
        }

        public void PreregisteredContestants()
        {
            contestantDictionary = new Dictionary<string, int>();

            Contestant khiera = new Contestant("Khiera", 21, 3);
            Contestant gwen = new Contestant("Gwen", 49, 4);
            Contestant sam = new Contestant("Sam", 52, 5);
            Contestant jasmine = new Contestant("Jasmine", 23, 6);

            contestantDictionary.Add("Khiera", 3);
            contestantDictionary.Add("Gwen",4);
            contestantDictionary.Add("Sam",5);
            contestantDictionary.Add("Jasmine",6);

            contestantList.Add(khiera);
            contestantList.Add(gwen);
            contestantList.Add(sam);
            contestantList.Add(jasmine);

        }

        public void RegisterContestant (Contestant contestant)
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

                contestant.name = Console.ReadLine();
                Console.WriteLine("------------------------");
                Console.WriteLine("How old are you "+contestant.name+"?");
                Console.WriteLine("------------------------");
                contestant.age = Convert.ToInt32(Console.ReadLine());

                if (contestant.age < 16)
                {
                    Console.WriteLine("I'm sorry. You have to be at least 16 to register for a sweepstakes. Thank you. Have a good day!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                Console.WriteLine("------------------------");
                Console.WriteLine("Thank you "+contestant.name+" for registering!");
                Console.WriteLine("------------------------");
                contestant.lotteryNumber = rnd.Next(1, 11);
                Console.WriteLine(contestant.name+" your lottery number is "+contestant.lotteryNumber);
                Console.WriteLine("------------------------");

                contestant = new Contestant(contestant.name, contestant.age, contestant.lotteryNumber);


                contestantDictionary.Add(contestant.name, contestant.lotteryNumber);
                contestantList.Add(contestant);

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
                Console.WriteLine("Do you want to create a new sweepstake or get a winner for "+sweepstakesName+ " sweepstake?");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Create new sweepstake");
                Console.WriteLine("2. Get winner");
                Console.WriteLine("------------------------");

                int choice2 = Convert.ToInt32(Console.ReadLine());

                if (choice2 == 1)
                {
                    SweepstakesName(sweepstakesName);
                }
                else if (choice2 == 2)
                {
                    PickWinner();
                }
                
            }
            else
            {
                Console.WriteLine("Please enter the the numerical value associated with your decision!");
                Console.WriteLine("------------------------");
                Operations();
            }
        }


        public string PickWinner()
        {
            winningLottoNumber = rnd.Next(1, 11);
           
                Console.WriteLine("The winning lottery number is " + winningLottoNumber);
                Console.WriteLine("-----------------------------");

            foreach (Contestant winner in contestantList)
            {
                if (winningLottoNumber == 1 && winner.lotteryNumber == 1)
                {

                    Console.WriteLine("The winner(s): " + winner.name);

                    contestantDictionary.Remove(winner.name);
                    contestantList.Remove(winner);
                    break;
                }
                else if (winningLottoNumber == 2 && winner.lotteryNumber == 2)
                {
                    Console.WriteLine("The winner(s): " + winner.name);

                    contestantDictionary.Remove(winner.name);
                    contestantList.Remove(winner);
                    break;
                }
                else if (winningLottoNumber == 3 && winner.lotteryNumber == 3)
                {
                    Console.WriteLine("The winner(s): " + winner.name);

                    contestantDictionary.Remove(winner.name);
                    contestantList.Remove(winner);
                    break;
                }
                else if (winningLottoNumber == 4 && winner.lotteryNumber == 4)
                {
                    Console.WriteLine("The winner(s): " + winner.name);

                    contestantDictionary.Remove(winner.name);
                    contestantList.Remove(winner);
                    break;
                }
                else if (winningLottoNumber == 5 && winner.lotteryNumber == 5)
                {
                    Console.WriteLine("The winner(s): " + winner.name);

                    contestantDictionary.Remove(winner.name);
                    contestantList.Remove(winner);
                    break;
                }
                else if (winningLottoNumber == 6 && winner.lotteryNumber == 6)
                {
                    Console.WriteLine("The winner(s): " + winner.name);

                    contestantDictionary.Remove(winner.name);
                    contestantList.Remove(winner);
                    break;
                }
                else if (winningLottoNumber == 7 && winner.lotteryNumber == 7)
                {
                    Console.WriteLine("The winner(s): " + winner.name);

                    contestantDictionary.Remove(winner.name);
                    contestantList.Remove(winner);
                    break;
                }
                else if (winningLottoNumber == 8 && winner.lotteryNumber == 8)
                {
                    Console.WriteLine("The winner(s): " + winner.name);

                    contestantDictionary.Remove(winner.name);
                    contestantList.Remove(winner);
                    break;
                }
                else if (winningLottoNumber == 9 && winner.lotteryNumber == 9)
                {
                    Console.WriteLine("The winner(s): " + winner.name);

                    contestantDictionary.Remove(winner.name);
                    contestantList.Remove(winner);
                    break;
                }
                else if (winningLottoNumber == 10 && winner.lotteryNumber == 10)
                {
                    Console.WriteLine("The winner(s): " + winner.name);

                    contestantDictionary.Remove(winner.name);
                    contestantList.Remove(winner);
                    break;
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Congratulations if you won! If you did not win, try again later to see if you win.");
            Console.WriteLine("------------------------------");

            Console.WriteLine("What would you like to do now?");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Create new sweepstake");
            Console.WriteLine("2. Get another winner");
            Console.WriteLine("3. Exit");
            Console.WriteLine("------------------------");

            int choice2 = Convert.ToInt32(Console.ReadLine());

            if (choice2 == 1)
            {
                SweepstakesName(sweepstakesName);
            }
            else if (choice2 == 2)
            {
                PickWinner();
            }
            else if (choice2 == 3)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Thank you for taking part in our Sweepstake application. Have a good day!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            return contestant.name;
        }



        public void PrintContestantInfo(Contestant contestant)
        {

            Console.WriteLine(sweepstakesName+" Contestant List");
            Console.WriteLine("-----------------------");
            foreach (KeyValuePair<string, int> contestantView in contestantDictionary)
            {
                Console.WriteLine("|Lotto #: {0} |Name : {1}", contestantView.Value,contestantView.Key );
            }
            Console.WriteLine("-----------------------");
        }

        

    }
}
