using Microsoft.VisualBasic;

namespace stringu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            masala1();
        }

        private static void masala1()
        {
            char hr = 'g';
            int x = 0, xmax = 0;
            string a = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length ; j++)
                {
                    if ( a[i] == a[j])
                    {
                        x++;
                    }
                    else break;

                }
                if (x >= xmax)
                {
                    xmax = x;
                    hr = a[i];
                }
                x = 0;

            }
            Console.WriteLine($"{hr} harfdan {xmax} ta bor");
        }
    }
}