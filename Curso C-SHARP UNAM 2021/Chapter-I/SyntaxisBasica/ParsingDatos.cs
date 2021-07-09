using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_SHARP_UNAM_2021.Chapter_I.SyntaxisBasica {
    class ParsingDatos {
 
        public static void inicio() {

            //usando la el metodo de Parse
            //   int entero = int.Parse(null);

            //Console.WriteLine(entero);// nos saldra excpecion no controlada
            //usando la clase Convert
            int entero2 = Convert.ToInt32(null);
            Console.WriteLine(entero2);


            int numero = 90; // numero contiene el valor 90
            double n_numero; //se declara una variable de tipo double
            n_numero = numero;
            //se le asigna el valor de numero a n_numero, realizamos la conversion de int a double 

            //numero tiene como valor 90
            //n_numero tiene como valor 90.0
        }
    }
}
