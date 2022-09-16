using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles


{
    internal class Program
    {
        static void Subprogram_1(string[] args)
        {

            Console.WriteLine("1- Mostrar los numeros del uno al 100");
            Console.WriteLine("2- Que pida un número y muestre la tabla del 1 al 12 de dicho número ");
            Console.WriteLine("3- Que pregunte la cantidad de montos, pida dichos montos y calcule la sumatorio y el promedio ");
            Console.WriteLine("4- La opción ingresada no se encuntra en el menú");
            Console.ReadKey();

        }


        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Ingrese una opción");
            num = Convert.ToDouble( Console.ReadLine());
            switch (num)

            {
                case 1:
                    Console.WriteLine("Mostrar los numeros del uno al 100");
                    break;

                case 2:
                    Console.WriteLine("Que pida un número y muestre la tabla del 1 al 12 de dicho número ");
                    break;

                case 3:
                    Console.WriteLine("Que pregunte la cantidad de montos, pida dichos montos y calcule la sumatorio y el promedio ");
                    break;

                case 4:
                    Console.WriteLine("Que pida un nombre y se repita mientras no sea (jose) o la cantidad de nombre ingresado sea menor 7");
                    break;

                default: 
                    Console.WriteLine("La opción ingresada no se encuntra en el menú");
                    break ;

                   

            }

        }

    }
}
