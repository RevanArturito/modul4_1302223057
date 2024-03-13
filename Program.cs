// See https://aka.ms/new-console-template for more information


using System.Net.Mail;


// membuat class kodeBuah
public class KodeBuah
{

    // membuat enum yang berisikan daftar nama buah
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

    // membuat fungsi getKodeBuah untuk mengembalikan nilai dari nama buah
    // tertentu
    public static String getEnumKodeBuah(enumKodeBuah kodeBuah)
    {
        String[] KodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
        return KodeBuah[(int)kodeBuah];
    }

    // fungsi main yang akan memanggil fungsi getKodeBuah
    public static void Main(String[] args)
    {
        enumKodeBuah kodeBuah = enumKodeBuah.Durian;
        Console.WriteLine($"{kodeBuah} = {getEnumKodeBuah(kodeBuah)}");
    }

}

/*using static PosisiKarakterGame;

public class PosisiKarakterGame
{
    //deklarasi enum poisis karakter
    public enum CharState {BERDIRI, JONGKOK, TENGKURAP, TERBANG};


    // deklarasi enum tombol trigger
    public enum Trigger {TOMBOLS, TOMBOLW, TOMBOLX};


    // inisialisasi posisi awal karakter
    public CharState currentCharState = CharState.JONGKOK;

    public class Transition
    {
        public CharState StateAwal;
        public CharState StateAkhir;
        public Trigger Trigger;


        // membuat konstruktor
        public Transition(CharState stateAwal, CharState stateAkhir, Trigger trigger)
        {
            this.StateAwal = stateAwal;
            this.StateAwal = stateAkhir;
            this.Trigger = trigger;
        }
    }


    // membuat skenario yang mungkin terjadi pada posisi karakter
    Transition[] trasisi =
    {
        new Transition(CharState.BERDIRI, CharState.JONGKOK, Trigger.TOMBOLS),
        new Transition(CharState.BERDIRI, CharState.TERBANG, Trigger.TOMBOLW),
        new Transition(CharState.TERBANG, CharState.BERDIRI, Trigger.TOMBOLS),
        new Transition(CharState.TERBANG, CharState.JONGKOK, Trigger.TOMBOLX),
        new Transition(CharState.JONGKOK, CharState.TENGKURAP, Trigger.TOMBOLS),
        new Transition(CharState.JONGKOK, CharState.BERDIRI, Trigger.TOMBOLW),
        new Transition(CharState.TENGKURAP, CharState.JONGKOK, Trigger.TOMBOLW),
    };


    // fungsi unutk melakukan perubahan posisi karakter menggunajkan trigger yang diinput
    public CharState getNextState(CharState stateAwal, Trigger trigger) 
    { 
        CharState stateAkhir = stateAwal;

        for (int i = 0;i < trasisi.Length; i++)
        {
            Transition perubahan = trasisi[i];
            if (stateAwal == perubahan.StateAwal && trigger == perubahan.Trigger) 
            {
                stateAkhir = perubahan.StateAkhir; 
            }
        }
        return stateAkhir;
    }


    // procedure untuk mengaktifkan fungsi utk perubahan posisi karakter
    public void ActivateTrigger(Trigger trigger)
    {
        currentCharState = getNextState(currentCharState, trigger);
        Console.WriteLine($"State character sekarang adalah : {currentCharState}");

        // jika posisi akhir karakter berdiri, akan menampilkan "posisi stanby"
        if (currentCharState == CharState.BERDIRI)
        {
            Console.WriteLine("Posisi Standby");
        }
        // jika posisi akhir karakter tengkurap, akan menampilkan "posisi istirahat"
        else if (currentCharState == CharState.TENGKURAP)
        {
            Console.WriteLine("Posisi Istirahat");
        }
    }

    // memanggil kembali fungsi activateTrigger dengan parameter yang berisikan trigger 
    // tertentu untuk melakukan perubahan posisi karakter dengan fungsi getNextState
    public static void Main(string[] args) 
    {
        PosisiKarakterGame objChar = new PosisiKarakterGame();
        Console.WriteLine(objChar.currentCharState);
        //Console.WriteLine(objChar.getNextState(objChar.currentCharState, PosisiKarakterGame.Trigger.TOMBOLS));
        objChar.ActivateTrigger(Trigger.TOMBOLW);
    }
}*/
