using System;

namespace funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno(1, "Fany", "Amaya");
            Alumno b = new Alumno(2, "Yamileth", "Amaya");

            a.inactivarAlumno();

            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());

            a.activarAlumno();

            Console.WriteLine(" ");
            
            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());


        }
    }
}