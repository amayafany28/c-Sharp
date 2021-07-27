using System;
public class Mono: Mamifero
{
    public string Bailan { get; set; }
    public bool GritaUAAUU { get; set; }

    public Mono() // Polimorfismo
    {
        GritaUAAUU = true;
    }

    public Mono(bool gritaUAAUU) // Polimorfismo
    {
        GritaUAAUU = gritaUAAUU;
    }
    public void Jaja()
    {
        Console.WriteLine("El mono se golpea el pecho y hace uauauu...");

    }

}