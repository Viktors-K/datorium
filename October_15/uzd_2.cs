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
    	var bloks1 = new Bloks(
			malasGarums:5,
			krasa:"oranžs",
			kubuSkaits:3,
			forma:13
		);
		Console.WriteLine(bloks1.Nosaukums);
		Console.WriteLine(bloks1.Tilpums());
		var bloks2 = new Bloks(
			malasGarums:7,
			krasa:"zils",
			kubuSkaits:5,
			forma:23
		);
		Console.WriteLine(bloks2.Nosaukums);
		Console.WriteLine(bloks2.Tilpums());
		bloks2.Forma = 12;
		Console.WriteLine(bloks2.Nosaukums);
		Console.WriteLine(bloks2.Tilpums());
	}
}

public class Kubs
{
    public int MalasGarums;
    public string Krasa;
    
    public Kubs(int malasGarums, string krasa) {
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
    public int Derigums => _allowedForms.Contains(Forma) ? 1 : 0;
    public Bloks(int malasGarums, string krasa, int kubuSkaits, int forma) : base(malasGarums, krasa) {
        _kubuSkaits = kubuSkaits;
        if (kubuSkaits < 1 || kubuSkaits > 4) {
            Console.WriteLine("Kubu skaits neatbilst nosacījumiem");
        }
        Forma = forma;
        if (Derigums == 0) {
            Console.WriteLine("Forma neatbilst nosacījumiem");
        }
    }
    
    public int Tilpums() => _kubuSkaits * AprekinatTilpumu();
}