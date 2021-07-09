using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_SHARP_UNAM_2021.Chapter_I.SyntaxisBasica {
    class Metodos {
        public static void inicio() {
            //Metodo que no devuelve nada 
            void imprimirAlgo() {
                Console.WriteLine("Algo :v");
            }
            //metodo que si entrega un tipo de dato
            DateTime getFecha() {
                return DateTime.Today;// se especifica return para devolver
            }

            //Ejecutamos los metodos
            imprimirAlgo();//de esta manera llamamos al metodo
            Console.WriteLine(getFecha());//llamamos al metodo dentro  para imprimir lo retornado

            //metodos con parametros
            int suma(int num1,int num2) {
                return num1 + num2;
            }

        }
    }

}
