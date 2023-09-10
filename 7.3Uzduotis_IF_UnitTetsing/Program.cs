using System;
namespace _7._3Uzduotis_IF_UnitTetsing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float[] products = { 3.99f, 0.99f, 5.99f, 2.99f, 7.99f, 1.99f, 9.99f };

            Console.WriteLine("0) preke1: " + products[0]);
            Console.WriteLine("1) preke2: " + products[1]);
            Console.WriteLine("2) preke3: " + products[2]);
            Console.WriteLine("3) preke4: " + products[3]);
            Console.WriteLine("4) preke5: " + products[4]);
            Console.WriteLine("5) preke6: " + products[5]);
            Console.WriteLine("6) preke7: " + products[6]);

            Console.WriteLine("Issirinkite 3 prekes: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            int userInput3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ar turite lojalumo kortele?");
            string answer = Console.ReadLine();

            int discount = 0;
            bool discountCard = (answer == "Taip");

            if (userInput == userInput2 && userInput2 == userInput3 && userInput == userInput3)
            {
                Console.WriteLine("Issirinkote 3 vienodas prekes, todel Jums bus taikoma -15% nuolaida");
                discount += 15;
            }
            else if (userInput == userInput2 || userInput2 == userInput3 || userInput == userInput3)
            {
                Console.WriteLine("Issirinkote 2 vienodas prekes, todel Jums bus taikoma -10% nuolaida");
                discount += 10;
            }
            if (discountCard)
            {
                Console.WriteLine("Jusu prekiu krepseliui taikoma papildoma -10% nuolaida");
                discount += 10;
            }
            float result = products[userInput] + products[userInput2] + products[userInput3];
            Console.WriteLine("Suma be nuolaidos: " + result);
            Console.WriteLine("Suma su nuolaida: " + ApplyDiscount(result,discount));
        }

        public static float ApplyDiscount(float result, float discount)
        {
            return result - (result * discount / 100);
        }
     }
}