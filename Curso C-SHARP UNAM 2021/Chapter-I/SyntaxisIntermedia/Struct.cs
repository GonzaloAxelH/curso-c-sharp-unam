using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_SHARP_UNAM_2021.Chapter_I.SyntaxisIntermedia {
    class Struct {
        public static void inicio() {
           //ejemplo 1
            Customer c1 = new Customer();
       
            Console.WriteLine(c1.ID);

            //ejemplo 2
            Coords coord1;
            coord1.x = 10;
            coord1.y = 12;
            Console.WriteLine("Coords 1:");
            Console.WriteLine("x = {0}, y = {1}", coord1.x, coord1.y);


        }   

        public struct Customer { 
            public int ID;
            public string Name;
            public Customer(int customerID,string customerName) {
                ID = customerID;
                Name = customerName;
            }
        }
        public struct Coords {
            public int x, y;
            public Coords(int p1,int p2) {
                x = p1;
                y = p2;
            }

        }

    }
}
