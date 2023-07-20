namespace stringu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ismingizni kiriting: ");
            string ism = Console.ReadLine();
            string natija = AylandirilganIsm(ism);
            Console.WriteLine("Chiqish: " + natija);
        }

        static string AylandirilganIsm(string ism)
        {
            string[] ismList = ism.Split(' ');
            for (int i = 0; i < ismList.Length; i++)
            {
                string currentIsm = ismList[i];
                if (currentIsm.Length > 0)
                {
                    ismList[i] = char.ToUpper(currentIsm[0]) + ".";
                }
            }

            return string.Join(" ", ismList);
        }
    }
}