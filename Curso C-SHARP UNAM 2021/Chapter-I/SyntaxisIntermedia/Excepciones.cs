using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_SHARP_UNAM_2021.Chapter_I.SyntaxisIntermedia {
    class Excepciones {

        
        public static void inicio() {
    
         double divisionTwoNumbers(double x,double y) {
                if (y == 0) {
                    throw new DivideByZeroException();
                }
                return x / y;
            }

            double a = 98;
            double b = 0;
            double resutl;
            try {
                resutl = divisionTwoNumbers(a, b);
                Console.WriteLine("{0} dividido por {1} = {2} ", a, b, resutl);

            } catch (DivideByZeroException) {
                Console.WriteLine("No se puede dividir entre zero");
            }
        }
    }
}
