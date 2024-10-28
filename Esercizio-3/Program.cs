using System;

class Program
{

    public const string prgName  = "Arena";      // Nome del programma, viene visualizzato nel banner e nel LogBook
    public const bool v3rb0se    = true;            // Se true, oltre a scrivere nel LogBook visualizza il messaggio anche a terminale
    public const int  lineLength = 80;              // Imposta la lunghezza delle linee separatrici nei messaggi

    static void Main()
    {
//  ---------------------------------------------------------------------------
        Banner header = new Banner("=","*",prgName,lineLength);
        header.WriteLog();

        Banner inizio = new Banner(" ","-","Inizio",lineLength);
        inizio.WriteLog();
//  ---------------------------------------------------------------------------

//    CreaPersonaggi();

        string marameo = "pinco palla marameo         ";
        System.Console.WriteLine($"Marameo ..... [{marameo}]");

        string myUpper = marameo.ToUpper();
        string myTrim  = marameo.Trim();

        System.Console.WriteLine($"Upper ..... [{myUpper}]");
        System.Console.WriteLine($"Trim ...... [{myTrim}]");

//    Random rnd = new Random();
//    int hp = rnd.Next(3, 21); // creates a number between 1 and 12

//    Conan.Decrementa_HP(hp);

//    System.Console.WriteLine($"month ...... : {month}");
//    System.Console.WriteLine($"dice ....... : {dice}");
//    System.Console.WriteLine($"card ....... : {card}");

//  ---------------------------------------------------------------------------

        Banner footer = new Banner("-","*","Fine",lineLength);
        footer.WriteLog();
    }

    static void CreaPersonaggi()
    {

        Personaggio Anacleto = new Personaggio();
        Anacleto.EName = "Anacleto";
        Anacleto.HealthPoints = 100;
        Anacleto.Speed = 1;
        Anacleto.ShowCharacter();
        
        Utilities.WriteLine("-", lineLength);
        Wizard Merlino = new Wizard();
        Merlino.EName = "Merlino";
        Merlino.HealthPoints = 100;
        Merlino.Speed = 5;
        Merlino.MaximumPower = 8;
        Merlino.ShowCharacter();

        Utilities.WriteLine("-", lineLength);
        Ork Shrek = new Ork();
        Shrek.EName = "Shrek";
        Shrek.HealthPoints = 100;
        Shrek.Speed = 5;
        Shrek.Strength = 9;
        Shrek.ShowCharacter();
       
        Utilities.WriteLine("-", lineLength);
        Warrior Conan = new Warrior();
        Conan.EName = "Conan";
        Conan.HealthPoints = 100;
        Conan.Speed = 5;
        Conan.DamagePercentage = 5;
        Conan.ShowCharacter();
/*
        Utilities.WriteLine("#", lineLength);
        Warrior Clone = new Conan();
        Clone.ShowCharacter();
        Utilities.WriteLine("#", lineLength);
*/

        int dadiMerlino = Merlino.TiraDati();
        int dadiShrek   = Shrek.TiraDati();
        int dadiConan   = Conan.TiraDati();

        System.Console.WriteLine($"Merlino ..... : {dadiMerlino}");
        System.Console.WriteLine($"Shrek  ...... : {dadiShrek}");
        System.Console.WriteLine($"Conan ....... : {dadiConan}");

//      Merlino vs Shrek    M > S; M < S; M = S;
//      Shrek   vs Conan    S > C; S < C; S = C;
//      Conan   vs Merlino  C > M; C < M; C = M;

/*
        Random rnd = new Random();


        for ( int i = 1; i <= 10; i++)
        {
            Merlino.Decrementa_HP(rnd.Next(3, 6));
            Shrek.Decrementa_HP(rnd.Next(3, 6));
            Conan.Decrementa_HP(rnd.Next(3, 6));
        }
*/
        Utilities.WriteBanner("Total Health Point");

        Merlino.ShowHealtPoints();
        Shrek.ShowHealtPoints();
        Conan.ShowHealtPoints();

    }

}