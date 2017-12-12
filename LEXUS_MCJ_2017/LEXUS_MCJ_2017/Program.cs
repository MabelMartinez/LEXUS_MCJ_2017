using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEXUS_MCJ_2017
{
    //NOMBRE :
    // 1 ) MABEL MARTINEZ   16-SIIT-1-033
    // 2 ) CAROLIN BAUTISTA 16-SIIT-1-063
    // 2 ) JOSMAR MOREL     16-SIIT-1-057


    //                                       UNIVERSIDAD DOMINICA O&M 
    //MATERIA:                          PROGRAMACION ESTRUCTURADA 
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, sum, promedio, cantidad;
            string linea;
            cantidad = 3;
            Console.Write("Ingrese primer valor; ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese segundo valor; ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingrese tercero valor; ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            Console.Write("Ingrese cuerto valor; ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);
            sum = num1 + num2 + num3 + num4;
            if(sum > 0)
            {
                promedio = sum / 4;
                Console.Write("La suma de los cuatros valores es: ");
                Console.Write(sum);
                linea = Console.ReadLine();
                if (promedio > 1)
                {
                    Console.Write("El promedio es : ");
                    Console.Write(promedio);
                    Console.ReadLine();
                
                }
            }

            for (int i = 0; i<= cantidad; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.Write("MABEL MARTINEZ   16-SIIT-1-033");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("CAROLIN BAUTISTA 16-SIIT-1-063");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("JOSMAR MOREL     16-SIIT-1-057");
                        Console.WriteLine();
                        break;

                }
            }
            Console.ReadKey();

        }
    }
}
