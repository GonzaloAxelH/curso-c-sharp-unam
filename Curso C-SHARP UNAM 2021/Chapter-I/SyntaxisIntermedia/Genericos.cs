using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_SHARP_UNAM_2021.Chapter_I.SyntaxisIntermedia {
    class Genericos {
        public static void inicio() {
            AlamacenaObjetos archivo = new AlamacenaObjetos(4);
            archivo.agregar("Gonzalo");
            archivo.agregar("Juan");
            archivo.agregar("Gorge");
            archivo.agregar("Antonio");
            String nombrePersona = (String)archivo.getElemento(2);//necesidad de castear 
            //alacenamos objetos de tipo empleados
            AlamacenaObjetos empleados = new AlamacenaObjetos(3);
            empleados.agregar(new Empleado(122));
            empleados.agregar(new Empleado(1222));
            String nombreEmpleado = (String)empleados.getElemento(1);
            Console.WriteLine(nombreEmpleado);
        }
    }


    public class AlamacenaObjetos {
        private Object[] datosElemento;
        private int i = 0;
        public AlamacenaObjetos(int z) {
            datosElemento = new Object[z];
        }
            public void agregar(Object obj) {
                datosElemento[i] = obj;
                i++;
            }
        public Object getElemento(int position) {
            return datosElemento[position];
        }

    }

    class Empleado {
        private double salario;
        public Empleado(double sal) {
            salario = sal;
        }
        public double getSalario() {
            return salario;
        }
    }
}






