using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_SHARP_UNAM_2021.Chapter_I.SyntaxisBasica {
    class DeclaracionVariables {

        public static void inicio() {
            var myNombre = "Diego";//correcto
            myNombre = "gonzalo";//correcto
           //myNombre = 5;//error
            //obligados a inicializar
         
            //var myVar;
            //myVar = 5;

            var myVar2 = 8;//correcto

            Console.WriteLine(myNombre);
            Console.WriteLine(myVar2);
        }
    }
}
