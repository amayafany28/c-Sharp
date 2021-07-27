using System;

public class Loro: Aves
{
    public string orden  { get; set; }
    public string Familia { get; set; }

    public void Hablar()
    {
        Console.WriteLine("Repite las Palabras");
    }

    public void Plumaje()
    {
        DescribirPlumaje();
    }

    private void DescribirPlumaje()
    {
        Console.WriteLine("Colorido en Verde, Rojo, Amarillo algunos Alvinos");
    }

}