using System;
namespace Uppgift5_3
{
    class program
    {
        static void Main(string[] args)
        {
            string[] frågor = new string[4];
            frågor[0] = ("Vilket är världens minsta land?");
            frågor[1] = ("Vad är 20 - 10 * 80?");
            frågor[2] = ("När började andra världskriget?");
            frågor[3] = ("Vem skrev Harry Potter böckerna?");
            string[] Svar=new string[4];
            Svar[0] = ("Vatikanstaten");
            Svar[1] = ("-780");
            Svar[2] = ("1939");
            Svar[3] = ("J.K Rowling");
            Console.WriteLine("Välj vilken typ av fråga du vill ha");
            Console.WriteLine(" ");
            Console.WriteLine("1. Geografi");
            Console.WriteLine("2. Matte");
            Console.WriteLine("3. Historia");
            Console.WriteLine("4. Literatur");
            Console.WriteLine(" ");
            string b =Console.ReadLine();
            int c =int.Parse(b);
          
                Console.WriteLine(frågor[c - 1]);
            string d =Console.ReadLine();
            Console.WriteLine(" ");
            if (d == Svar[c - 1])
            {
                Console.WriteLine("Du har rätt!");
            }
            else
            {
                Console.WriteLine("Du har fel");
            }

            
        }
    }
}