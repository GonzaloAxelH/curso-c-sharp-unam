using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Curso_C_SHARP_UNAM_2021.Chapter_I.SyntaxisIntermedia {
    public class Properties {
        public static void inicio() {
                
            Persona2 estudiante = new Persona2();
            estudiante.FirstName=" Gonzalo ";
            //Console.WriteLine(estudiante.FirstName);


            Persona trabajador = new Persona();
            trabajador.FirstName = "sergio";
            trabajador.LastName = "ramirez";
            Console.WriteLine(trabajador.FullName);


        }
    }

    public class Persona{
        public string FirstName {
            get => firstName;
            set => firstName = value;
        }
        private string firstName;
         public string LastName {
            get => lastName;
            set => lastName = value;
        }
        private string lastName;
        //interpolacion
        public string FullName {
            get {
                return $"{FirstName} {LastName}";
            }
        }

    }

    public class Persona1{
        //solo lectura para last name
        public string FirstName { get; set;}
        public string LastName { get; private set;}

        public ICollection<Persona> points { get; } = new List<Persona>();



    }

    public class Persona2 {
        public string FirstName {
            get => firstName;
            set => firstName = (!string.IsNullOrWhiteSpace(value)) ? value : throw new ArgumentException("No permitido valores en blanco");

        }
        private string firstName;
    }

    public class Persona3 : INotifyPropertyChanged{
        public string FirstName {
            get => firstName;
            set {
                if (string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentException("No valores en blanco");
                }
                if(value != firstName) {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
                }
                firstName = value;
            }
        }
        private string firstName;

        public event PropertyChangedEventHandler PropertyChanged;

    }





}
