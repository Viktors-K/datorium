using System;

public class MainClass
{
    public static void Main(string[] args)    {
        Console.WriteLine ("Pirmā teksta līnija");
        Console.WriteLine ("Otrā teksta līnija");
        Console.WriteLine (Add(5, 6));
    }
    public static int Add(int a, int b){
        return a + b;
    }
}