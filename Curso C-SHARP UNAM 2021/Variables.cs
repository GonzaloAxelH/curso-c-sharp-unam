using System;

namespace Curso_C_SHARP_UNAM_2021 {
    class Variables {
        static void Main(string[] args) {
            /*-------------------------Declaracion Implicita -----------------------------*/
            var myNombre ="Diego";//correcto
            myNombre = "gonzalo";//correcto
            myNombre = 5;//error


            //obligados a inicializar

            var myVar;//error
            myVar = 5;

            var myVar2 = 8;

            Console.WriteLine(myNombre);
    

        }
    }
}
