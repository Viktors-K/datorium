using System;
					
public class App
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}
}

public class Kubs
{
    public int MalasGarums;
    public string Krasa;
    
    public Kubs(int malasGarums, string krasa)
    {
        MalasGarums = malasGarums;
        Krasa = krasa;
    }

    ~Kubs() {
		Console.WriteLine("Objekts likvidēts. Krasa: {Krasa}");
	}
    
    public int AprekinatTilpumu() {
		return MalasGarums * MalasGarums * MalasGarums;
	}
}