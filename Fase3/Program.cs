using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double turn = 4; //cada cuatro años hay un año bisiesto
            double a = 0.0, b = 0.0, c = 0.0; //Inicializamos las variables donde guardaremos los valores que definen si un año es bisiesto
            bool x=false;
            string nameSurname = "Joaquina Ruano Medina";
            string birthdate = "10/02/1972";
            string anyNote = " El año en que nací es bisiesto";


            Console.WriteLine("Mi nombre es: " + nameSurname);
            Console.WriteLine("Naci el : " + birthdate);
            Console.WriteLine(anyNote +"\n");
                
            for (double leapYear = 1948; leapYear <= 1972; leapYear++) //Al ejecutar el bucle mostrará que años son bisiestos y cuales no entre 1948 y 1972
            {
                a = leapYear % 4;
                b = leapYear % 100;
                c = leapYear % 400;


                if (a == 0 && b != 0 || c == 0)
                {
                    
                    x = true;
                    string f = "La variable booleana es verdadera";
                    Console.WriteLine(leapYear + " " + "Es bisiesto: " );
                    Console.WriteLine(f + "\n");
                }
                else
                {
                    x = false;
                    string l = "La variable booleana es false";
                    Console.WriteLine(leapYear + " "+ "No es bisiesto" );
                    Console.WriteLine(l + "\n");
                }

            }

        }
    }
}
