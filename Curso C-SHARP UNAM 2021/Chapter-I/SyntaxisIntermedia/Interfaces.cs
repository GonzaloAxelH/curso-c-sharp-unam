using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_SHARP_UNAM_2021.Chapter_I.SyntaxisIntermedia {
    class Interfaces {
        public static void inicio() {
            //ecutando ejemplo
            SampleClass miobj = new SampleClass();
            miobj.Paint();

            //ejecutando ejemplo2 
            SampleClase2 miobj2 = new SampleClase2();
            IControl2 control = miobj2;
            ISurface surface = miobj2;
            //llamando a metodo DE CADA INTERFAZ
            control.Paint();
            surface.Paint();
            miobj2.Paint();
            //salida
            //Implementando interfaz
            //Implementando interfaz
            //Implementando interfaz

            // ejecutando ejemplo 3
            Box box1 = new Box(30.0f, 20.0f);
            // Declare an interface instance dimensions:
            IDimensions dimensions = box1;
            //System.Console.WriteLine("Length: {0}", dimensions.GetLength());
            //System.Console.WriteLine("Width: {0}", dimensions.GetWidth());
            /*Salida:
                Length: 30
                Width: 20
            */


            //ejecutamos el ejemplo 4
            //instanciamos
            Box2 box2 = new Box2(30.0f, 20.0f);

            //delcarando la instancia con le interfaz seleccionada
            IEnglishDimensions eDimensions = box2;
           //delcarando la instancia con le interfaz seleccionada

            IMetricDimensions mDimensions = box2;
            //imprimimos 
            System.Console.WriteLine("Length(in): {0}", eDimensions.Length());
            System.Console.WriteLine("Width (in): {0}", eDimensions.Width());
            //imprimimos
            System.Console.WriteLine("Length(cm): {0}", mDimensions.Length());
            System.Console.WriteLine("Width (cm): {0}", mDimensions.Width());


        }

    }
    //ejemplo 1
    public interface IControl {
        void Paint();
    }

    public class SampleClass : IControl {
        public void Paint() {
            Console.WriteLine("Implementando interfaz");
        }
    }

    //ejemplo2
    public interface IControl2 {
        void Paint();

    }
    public interface ISurface {
        void Paint();
    }

    public class SampleClase2 : ISurface, IControl2 {
        public void Paint() {
            Console.WriteLine("Implementado interfaces con metodo iguales");
        }
    }

    //tercer ejmplo de intefaz
    interface IDimensions {
        float GetLength();
        float GetWidth();
    }

    public class Box : IDimensions {
        public float lengthInches;
        public float widthInches;
        public Box(float length, float width) {
            lengthInches = length;
            widthInches = width;
        }
         float IDimensions.GetLength() {
            return lengthInches;
        }
         float IDimensions.GetWidth() {
            return widthInches;
        }

    }
    
    //ejemplo 4


    //declarando interfaces
    interface IEnglishDimensions {
        float Length();
        float Width();
    }

    interface IMetricDimensions {
        float Length();
        float Width();
    }
        //declarando la clase box2
 
    class Box2 : IEnglishDimensions, IMetricDimensions {
        float lengthInches;
        float widthInches;
        public Box2(float lengthInches, float widthInches) {
            this.lengthInches = lengthInches;
            this.widthInches = widthInches;
        }
        //con la interfaz de EnglishDimensions
        float IEnglishDimensions.Length() => lengthInches;
        float IEnglishDimensions.Width() => widthInches;
        // com las interfaz de MetricDimensions
        float IMetricDimensions.Length() => lengthInches * 2.54f;
        float IMetricDimensions.Width() => widthInches * 2.54f;

    }

}
