using System;
using System.Collections.Generic;

public class App
{
    public static void Main(string[] args)
    {
        var kubg = new Kubs(10, "zala");
        var kubr = new Kubs(1, "sarkana");
        
        Console.WriteLine(kubg.Krasa);
        Console.WriteLine(kubg.AprekinatTilpumu());
        Console.WriteLine(kubr.MalasGarums);
        
        kubr = null;
        if (kubr == null) {
            Console.WriteLine("kubr nav pieejams");
        }
        
        Console.WriteLine(kubg.MalasGarums);
    }
}

public class Kubs
{
    public int MalasGarums;
    public string Krasa;
    
    public Kubs(int malasGarums, string krasa)
    {
        MalasGarums = (malasGarums >= 2 && malasGarums <= 10) ? malasGarums : 2;
        Krasa = krasa;
    }

    ~Kubs() => Console.WriteLine($"Objekts likvidēts. Krasa: {Krasa}");
    
    public int AprekinatTilpumu() => MalasGarums * MalasGarums * MalasGarums;
}

public class Bloks : Kubs
{
    private int _kubuSkaits;
    private readonly List<int> _allowedForms = new List<int> {11, 12, 13, 14, 22};
    
    public string Nosaukums => Krasa + _kubuSkaits.ToString();
    public int Forma;
    public int Derigums;

    public Bloks(int malasGarums, string krasa,
    int kubuSkaits, int forma) : base(malasGarums, krasa)
    {
        _kubuSkaits = kubuSkaits;
        if (kubuSkaits < 1 || kubuSkaits > 4)
        {
            Console.WriteLine("Kubu skaits neatbilst nosacījumiem");
        }
        
        Forma = forma;
        if (!_allowedForms.Contains(forma))
        {
            Console.WriteLine("Forma neatbilst nosacījumiem");
            Derigums = 0;
        } else
        {
            Derigums = 1;
        }
    }
    
    public int Tilpums() => _kubuSkaits * AprekinatTilpumu();
}