using System;
					
public class App
{
	public static void Main()
	{
		var kubg = new Kubs(10, "zala");
		var kubr = new Kubs(1, "sarkana");
		Console.WriteLine(kubg.Krasa);
		Console.WriteLine(kubg.AprekinatTilpumu());
		Console.WriteLine(kubr.MalasGarums);
		
		kubr = null;
		if (kubr == null) {
			Console.WriteLine("kubr dead");
		}
		Console.WriteLine(kubg.MalasGarums);
	}
}

public class Kubs
{
    public int MalasGarums;
    public string Krasa;
    
    public Kubs(int malasGarums, string krasa) {
        if (malasGarums >= 2 && malasGarums <= 10) {
            MalasGarums = malasGarums;
        } else {
            MalasGarums = 2;
        }
        Krasa = krasa;
    }

    ~Kubs() {
		Console.WriteLine("Objekts likvidēts. Krasa: {Krasa}");
	}
    
    public int AprekinatTilpumu() {
		return MalasGarums * MalasGarums * MalasGarums;
	}
}
public class Bloks : Kubs {
	private int _kubuSkaits;
	public string Nosaukums {
		get {
			return Krasa + _kubuSkaits.ToString();
		}
	}
	public Bloks(int malasGarums, string krasa) : base(malasGarums, krasa) {
	
	}
}