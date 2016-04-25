using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {

            Sweepstakes runApp = new Sweepstakes();
            runApp.Introduction();

            Console.ReadKey();

        }
    }
}
