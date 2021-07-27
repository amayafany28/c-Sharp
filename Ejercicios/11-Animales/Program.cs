using System;

namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro l = new Perro();
            Console.WriteLine("- Leon -");
            l.Nombre = "Drako";
            l.Patas = 4;
            l.Pelo = "Gris Con Blanco y partes Negras";
            l.Raza = "Husky Siberanio";
            l.Comer();
            l.Caminar();
            l.Maullar();
            l.Ladrar = true;

            Console.WriteLine(l.Nombre);
            Console.WriteLine(l.Patas);
            Console.WriteLine(l.Pelo);
            Console.WriteLine(l.Raza);         

            Console.WriteLine();

            Mono v = new Mono();
            Console.WriteLine("Mono");
            v.Nombre = "Marcos";
            v.Patas = 4;
            v.Comer();
            v.GritaUAAUU = true;
            v.Caminar();

            Console.WriteLine(v.Nombre);
            Console.WriteLine(v.Patas);

            Console.WriteLine();

            Aguila c = new Aguila();
            Console.WriteLine("Aguila");
            c.Nombre = "Patricia";
            c.Patas = 2;
            c.Picotear = 10;
            c.ColorPlumaje = "Alas color negro con puntas blancas";
            c.Volar();
            c.Comer();
            c.Picar();

            Console.WriteLine(c.Nombre);
            Console.WriteLine(c.Picotear);
            Console.WriteLine(c.Patas);
            Console.WriteLine(c.ColorPlumaje);

            Console.WriteLine();

            Loro P = new Loro();
            Console.WriteLine("Loro");
        
            Console.WriteLine();

            Pezglobo d = new Pezglobo();
            Console.WriteLine("- Pez Globo -");
            d.Nombre = "Ester";
            d.NumeroAletas = 2;
            d.Comer();
            d.Nadar();
            d.Color = "Rojo con rayas blancas";
            d.InhalarAire();
            d.PerderAire();

            Console.WriteLine(d.Nombre);
            Console.WriteLine(d.NumeroAletas);
            Console.WriteLine(d.Color);

            Tiburon t = new Tiburon();
            Console.WriteLine("- Tiburon -");
            t.Nombre = "BabyShark";
            t.NumeroAletas = 2;
            t.Comer();
            t.Nadar();
            t.Color = "Gris con Blanco";
 
            Console.WriteLine(t.Nombre);
            Console.WriteLine(t.NumeroAletas);
            Console.WriteLine(t.Color);

            }
        }
}
