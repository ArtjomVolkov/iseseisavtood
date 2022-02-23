using System;
using System.Collections.Generic;
using System.Text;

namespace iseseisavtood
{
    class Task3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sinu palga => ");
            double pohod = 0.2;
            int zarplata = int.Parse(Console.ReadLine());
            int arv;
            int netopalk;
            if (zarplata < 500)
            {
                Console.WriteLine("Tulumaks puudub Tulumaks alates 500 ja üle selle.");
            }
            else if (zarplata > 500)
            {
                arv = (int)(zarplata * pohod);
                Console.WriteLine($"Tulemaks = {arv}");
                netopalk = (zarplata - arv);
                Console.WriteLine($"Netopalk = {netopalk}");
            }
            else
            {
                Console.WriteLine("Vale palga!");
            }
        }
    }
}
