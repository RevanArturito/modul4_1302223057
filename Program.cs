// See https://aka.ms/new-console-template for more information


using System.Net.Mail;

public class kodeBuah
{
    public enum enumKodeBuah 
    { 
        Apel,
        Aprikot,
        Alpukat,
        Pisang,
        Paprika,
        Blackberry,
        Ceri,
        Kelapa,
        Jagung,
        Kurma,
        Durian,
        Anggur,
        Melon,
        Semangka,
    }

    public  static String getEnumKodeBuah(enumKodeBuah kodeBuah)
    {
        String[] KodeBuah = {"A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00"};
        return KodeBuah[(int)kodeBuah];
    }

    public static void Main(String[] args)
    {
        enumKodeBuah kodeBuah = enumKodeBuah.Durian;
        Console.WriteLine($"{kodeBuah} = {getEnumKodeBuah(kodeBuah)}");
    }

}
