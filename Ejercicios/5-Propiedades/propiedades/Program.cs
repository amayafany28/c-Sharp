using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.Id = 1;
            a.PrimerNombre = "Fany";
            a.SegundoNombre = "Amaya";
            
            Alumno b = new Alumno();
            b.Id = 2;
            b.PrimerNombre = "Yamileth";
            b.SegundoNombre = "Amaya";
            
            Alumno c = new Alumno(3);
            c.PrimerNombre = "Maria";

            Alumno d = new Alumno("Patricia", "Vasquez");
            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);
        }
    }
}
