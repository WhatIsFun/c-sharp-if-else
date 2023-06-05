namespace If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student marks:");
            int M = Convert.ToInt32(Console.ReadLine());
            

            if (M >= 80)
            {
                Console.WriteLine("A");
            }
            else if ( M<= 79 && M >= 75)
            {
                Console.WriteLine("B+");
            }
            else if (M <= 74 && M>= 70)
            {
                Console.WriteLine("B");
            }
            else if (M <= 69 && M >= 60)
            {
                Console.WriteLine("C");
            }

            else
            {
                Console.WriteLine("D");
            }
            Console.WriteLine("");
        }
    }
}