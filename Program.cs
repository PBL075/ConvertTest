using System;

namespace test_convert
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introdu numarul de cai putere (HP): ");
            int hpStock = Convert.ToInt32 (Console.ReadLine());
            int hpCuTuning = hpStock + 50 ; 

            Console.WriteLine("Daca mai punem o turbina , vei avea: " + hpCuTuning + "HP");

        }
    }
}
