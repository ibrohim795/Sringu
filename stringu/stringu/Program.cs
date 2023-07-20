using System.Threading.Channels;

namespace stringu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
             unliundosh(s);
        }

        private static string unliundosh(string s)
        {
            int unli = 0, undosh = 0;
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'o' || s[i] == 'u' || s[i] == 'i' || s[i] == 'e')
                {
                    unli++;
                }
                else if (char.IsLetter(s[i]) && !(s[i] == 'a' || s[i] == 'o' || s[i] == 'u' || s[i] == 'i' || s[i] == 'e')) 
                {
                    undosh++;
                }
            }
            Console.WriteLine($"{undosh} undosh harflar");
            Console.WriteLine($"{unli} unli harflar");
            return s;
        }
    }
}