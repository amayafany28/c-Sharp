using System;

public abstract class Peces: Animal
{
    public int NumeroAletas { get; set; }
    public string Color { get; set; }

    public void Nadar()
    {
        Console.WriteLine("Eres Increible Nadando");
    }
}