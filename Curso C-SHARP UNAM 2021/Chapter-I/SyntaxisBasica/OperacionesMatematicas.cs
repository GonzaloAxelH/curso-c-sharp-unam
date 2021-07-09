using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_SHARP_UNAM_2021.Chapter_I.SyntaxisBasica {
    class OperacionesMatematicas {
            
        public static void inicio() {
            int a, b, c;
            a = 5;
            b = 3;
            // subtraction
            c = a - b;
            Console.WriteLine($"La resta es = {c}");
            // multiplication
            c = a * b;
            Console.WriteLine($"La multiplicacion es  = {c}");
            // división
            c = a / b;
            Console.WriteLine($"La division es  = {c}");
        }
    }
}
