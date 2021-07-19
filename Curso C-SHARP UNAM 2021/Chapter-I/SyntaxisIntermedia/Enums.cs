using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_SHARP_UNAM_2021.Chapter_I.SyntaxisIntermedia {
    class Enums {
        public static void inicio() {
            Season a = Season.Autumn;
            Console.WriteLine($"Integral value of {a} is {(int)a}");

            var b = (Season)1;
            Console.WriteLine(b);///salida :Summer

            var c = (Season)4;
            Console.WriteLine(c);//salida 4
        }
    }

    public enum Season {
        Spring,//0
        Summer,//1
        Autumn,//2
        Winter//3
        //empty -> 4
    }

}
