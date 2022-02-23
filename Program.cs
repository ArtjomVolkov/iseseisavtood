using System;

namespace iseseisavtood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage suvalise pikkusega string:");
            string str = Console.ReadLine();
            Console.WriteLine("Sisestage märk, et leida selle esinemise protsent stringis:");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int length = str.Length;
            char[] strs = str.ToCharArray();
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                if (strs[i] == symbol)
                {
                    counter++;
                }
            }
            double lengthDouble = Convert.ToDouble(length);
            double counterDouble = Convert.ToDouble(counter);
            double prosent = (counterDouble / lengthDouble) * 100;
            Console.WriteLine($"Tegelaste esinemise protsent {symbol} võrdub {prosent}%");
        }
    }
}
