using System;

namespace Tema_Project1_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex2
               Scrieti un program care va calcula media aritmetica a trei numere citite de la
               tastatura*/

            int firstnumber = 8;
            int secondnumber = 4;
            int thirdnumber = 6;

            Console.WriteLine("Acest program calculeaza media aritmetica");

            Console.WriteLine("Introduceti firstnumber");
            firstnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti secondnumber");
            secondnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti thirdnumber");
            thirdnumber = int.Parse(Console.ReadLine());

            int mediaAritmetica = (firstnumber+secondnumber+thirdnumber)/3;
            Console.WriteLine(mediaAritmetica);
            
        }
    }
}
