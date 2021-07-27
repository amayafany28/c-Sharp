using System;

public class Pezglobo: Peces
{
    public string Inflarse { get; set; }

    public void InhalarAire()
    {
        Console.WriteLine("Te estas Inflando");
    }

    public void PerderAire()
    {
        FaltadeAire();
    }

    private void FaltadeAire()
    {
        Console.WriteLine("Recuperate Inhala bastante Aire");
    }
}
