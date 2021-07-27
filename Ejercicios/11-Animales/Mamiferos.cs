using System;
public abstract class Mamifero: Animal 
{
    public int Patas { get; set; }

    public void Caminar()
    {
        Console.WriteLine("Ven vamos caminemos por el bosque"); 
    }

}