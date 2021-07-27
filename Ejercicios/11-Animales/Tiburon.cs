using System;

public class Tiburon: Peces
{
    public string Ataque { get; set; }

    public void Lanzarce()
    {
        Console.WriteLine("Auxilio un tuburon");
    }

    public void Tiburonsin()
    {
        Gritos();
    }

    private void Gritos()
    {
        Console.WriteLine("Ahi viene el tiburon");
    }
}
