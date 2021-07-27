using System;
public class Perro: Mamifero
{
    public string Pelo { get; set; }
    public string Raza { get; set; }
    public bool Ladrar { get; set; }

    public Perro() // Polimorfismo
    {
        Ladrar = true;
    }

    public Perro(bool ladrar) // Polimorfismo
    {
        Ladrar = ladrar;
    }
    public void Maullar()
    {
        Console.WriteLine("Hermoso Gato");

    }

}