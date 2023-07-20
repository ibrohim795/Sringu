namespace stringu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
            
            Console.WriteLine(engks(s));
        }

        static string engks(string s)
        {
            string[] str = s.Split(' ');
            return str.Max() ;
        }
    }
}