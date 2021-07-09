using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_SHARP_UNAM_2021.Chapter_I.SyntaxisBasica {
    class Arrays {
    
        public static void inicio() {
            //declaración de matriz
            int[] evenNums;  // integer array
            string[] cities; // string array

            //declaración e inicialización de matriz
            int[] evenNumss = new int[5] { 2, 4, 6, 8, 10 };
            string[] cities1 = new string[3] { "Mumbai", "London", "New York" };

            //Ejemplo: Declaración de matriz usando var
            var evenNums3 = new int[] { 2, 4, 6, 8, 10 };
            var cities3 = new string[] { "Mumbai", "London", "New York" };

            //Ejemplo: sintaxis corta de la declaración de matriz
            int[] evenNums4 = { 2, 4, 6, 8, 10 };
            string[] cities4 = { "Mumbai", "London", "New York" };
        }
    }
}
