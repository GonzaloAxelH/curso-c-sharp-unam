using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_SHARP_UNAM_2021.Chapter_I.SyntaxisIntermedia {
    class Excepciones_II {
       
        public static  void inicio() {
            int numerador = 10;
            int denominador =0;
            Console.WriteLine("Numerador ={0}",numerador);
            Console.WriteLine("Denominador ={0}",denominador);



            try {
                Console.WriteLine("--> ejecutando en try");
                Console.WriteLine("Cociente = {0}", numerador/denominador);
           }catch(ArithmeticException e) {
                Console.WriteLine("-->ejecutando el catch");
                Console.WriteLine("Exepcion aritemetica");
                Console.WriteLine("AritmeticException Handler : {0}", e.ToString());
           }catch(ArgumentNullException e) {

                Console.WriteLine("-->ejecutando el catch");
                Console.WriteLine("Excepcion de argumento nulo");
                Console.WriteLine("ArgumentException Handler : {0}", e.ToString());
           }catch(Exception e) {
                Console.WriteLine("Generic Handler : {0}", e.ToString());
           } finally {
                Console.WriteLine("'--->finaly");

            }
            Console.ReadLine();
        }


    }


}
