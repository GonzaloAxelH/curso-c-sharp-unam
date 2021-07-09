using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_SHARP_UNAM_2021.Chapter_I.SyntaxisBasica {
    class Condicionales {

        public static void inicio() {
            //ejemplo de if else if 
            var tamano = decimal.Parse(Console.ReadLine());
            if (tamano < 0)
                Console.WriteLine($"Tamano Negativo: {tamano}");
            else if (tamano > 1000)
                Console.WriteLine($"Tamano grande: {tamano}");
            else {
                Console.WriteLine($"Tamano aceptado: {tamano}");
                Console.WriteLine($"Area: {tamano * tamano}");
            }

        }
    }
}
