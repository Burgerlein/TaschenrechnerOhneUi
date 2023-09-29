using System.Linq.Expressions;

namespace Taschenrechner
{
    public class Program
    {
        public static void Main()
        {
            int zahl1 = 0;
            int zahl2 = 0;
            Console.Write("Zahl 1 eingeben: ");
            zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zahl 2 eingeben: ");
            zahl2 = Convert.ToInt32(Console.ReadLine());

            Muliplikator(zahl1, zahl2);

        }
        
        public static int Addition(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }
        public static int Subtraktion(int zahl1, int zahl2)
        {
            return zahl1 - zahl2;
        }
        public static int Multiplikation(int zahl1, int zahl2)
        {
            return zahl1 * zahl2;
        }
        public static int Division(int zahl1, int zahl2)
        {
            return zahl1 / zahl2;
        }

        public static void Muliplikator(int zahl1, int zahl2)
        {
            string multiplikatoren = "";
            Console.Write("Multiplikator eingeben: ");
            multiplikatoren = Console.ReadLine();

            switch (multiplikatoren)
            {
                case "+": 
                    Console.WriteLine(Addition(zahl1, zahl2));
                    break;
                case "-":
                    Console.WriteLine(Subtraktion(zahl1, zahl2));
                    break;
                case "*":
                    Console.WriteLine(Multiplikation(zahl1, zahl2));
                    break;
                case "/":
                    Console.WriteLine(Division(zahl1, zahl2));
                    break;
                default:
                    Muliplikator(zahl1, zahl2);
                    break;
            }
        }
    } 
}
