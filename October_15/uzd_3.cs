using System;

public class App
{
    public static void Main(string[] args)
    {
		var doktorats = new Doktorats("Augstkalne",325);
		doktorats.IzdrukatDatus();
	}
}

public class Doktorats
{
    public string Nosaukums;
	public int PacientuSkaits;
    
    public Doktorats(string nosaukums, int pacientuSkaits) {
        Nosaukums = nosaukums;
		PacientuSkaits = pacientuSkaits;
    }
	
    public void IestatitDatus(string nosaukums, int pacientuSkaits) {
		Nosaukums = nosaukums;
		PacientuSkaits = pacientuSkaits;
	}
	
	public void IzdrukatDatus() {
		Console.WriteLine($"Doktorāts {Nosaukums} apkalpo {PacientuSkaits} pacientus.");
	}
}
