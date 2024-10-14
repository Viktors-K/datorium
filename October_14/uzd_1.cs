using System;

public class App
{
    public static void Main(string[] args)
    {
        var audi = new Transportlidzeklis(
            zimols: "Audi",
            modelis: "A4",
            regDatums: "22.10.2019",
            pilnaMasa: 1800,
            degVeids: "BG"
        );
    }
}

public class Transportlidzeklis
{
    public string Zimols;
    public string Modelis;
    public string RegistracijasDatums;
    public int PilnaMasa;
    public string DegvielasVeids;
    
    public Transportlidzeklis(string zimols, string modelis, string regDatums,
                             int pilnaMasa, string degVeids)
    {
        Zimols = zimols;
        Modelis = modelis;
        RegistracijasDatums = regDatums;
        PilnaMasa = pilnaMasa;
        DegvielasVeids = degVeids;
    }
	public string Info() {
		return ($"Automašīna {Zimols} {Modelis}, registreta {RegistracijasDatums}, izmanto {DegvielasVeids} un sver {PilnaMasa} kg.");
	}
}