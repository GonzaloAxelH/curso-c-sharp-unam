using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_SHARP_UNAM_2021.Chapter_I.SyntaxisBasica {
    class Variables {
        public static void inicio() {
            //Algunas observaciones de este tipo de dato entero
            int myVariableEntera = 5;//declarando tipo int
            //--> Este tipo de valor es primitivo y no se pueden declarar nulo
            
            //int edad = null;//error

            
            //int longNumber = 2147483649;//error 
            
            int longNumber2 = 2147783;// correcto 
            
            
            //--> Si quieres trabajar solo con positivos colocar la antes
           
            uint myNumberPositive = 2147483;//correcto  
            
            


            Console.WriteLine(myNumberPositive);
            Console.WriteLine(myVariableEntera);
        }

    }
}
