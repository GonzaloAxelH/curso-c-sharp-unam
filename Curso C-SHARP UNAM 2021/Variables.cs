using System;

/*--------------------------------ESTRUCTURA DE UN PROGRAMA C# -------------------------------------*/

namespace Curso_C_SHARP_UNAM_2021 {
    class Variables {
        static void Main(string[] args) {

            /*-----------------------------OPERACIONES MATEMATICAS ---------------------------------*/
            int a, b, c;
            a = 8;
            b = 7;
            // subtraction
            c = a - b;
            Console.WriteLine(c);
            // multiplication
            c = a * b;
            Console.WriteLine(c);
            // división
            c = a / b;
            Console.WriteLine(c);
            /*---------------------------------- COMENTARIOS ---------------------------------------*/

            //esto es un comentario :)
            int num1 = 5;//declarando un numero entero
            int num2 = 6;

            int suma = num1 + num2; //operacion de la suma
            Console.WriteLine(suma);//imprimiendo la suma

            //tambien los comentarios de multiples lineas 

            /*         
               Cuaquier texto ... 
            */

            /*----------------------------------TIPO DE DATOS:INTRODUCCION--------------------------------------------*/

            //Algunas observaciones de este tipo de dato entero

            int myVariableEntera = 5;//declarando tipo int
            //--> Este tipo de valor es primitivs y estos no se pueden declarar nulo
                int edad = null;//error
            //--> Este tipo solo soporta enteros desde -2.147.483.648 a 2.147.483.647
                int longNumber = 2147483649;//error 
                int longNumber2 = 2147783;// correcto 
            //--> Si quieres trabajar solo con positivos al int se le aumenta antes la u
                uint myNumberPositive  = 2147483;//correcto
        } 
    }
}
