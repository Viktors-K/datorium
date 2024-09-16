using System;

public class MainClass
{
    public static void Main(string[] args)    {
        Console.WriteLine ("Pirmā teksta līnija");
        Console.WriteLine ("Otrā teksta līnija");
        Console.WriteLine (Add(5, 6));
        Console.WriteLine (CharacterCount("Labdien!"));
    }
    public static int Add(int a, int b){
        return a + b;
    }
    public static string CharacterCount(string text) {
        if (text.Length > 9) {
            return "long";
        } else if (text.Length > 4) {
            return "medium";
        } else {
            return "short";
        }
    }
}