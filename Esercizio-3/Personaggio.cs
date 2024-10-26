public class Personaggio
{
    public string EName        { get; set; }
    public int    HealthPoints { get; set; }
    public int    Speed        { get; set; }

    public virtual void ShowCharacter()
    {
//      Utilities.WriteLogBook($"Sono {EName} e sono un Personaggio Standard!");
        Utilities.WriteLogBook($"Epic Name .... : {EName}");
        Utilities.WriteLogBook($"Health Points  : {HealthPoints}");
        Utilities.WriteLogBook($"Speed ........ : {Speed}");
    }

    public virtual void ShowHealtPoints()
    {
        Utilities.WriteLogBook($"{EName} : {HealthPoints}");
    }
    public virtual void Decrementa_HP(int hP)
    {
        HealthPoints = HealthPoints - hP;
    }

    public virtual int TiraDati()
    {
        Random rnd = new Random();

        int dado1 = rnd.Next(1, 7);
        int dado2 = rnd.Next(1, 7);

        return dado1 + dado2;

    }
}

public class Warrior : Personaggio
{
    public int DamagePercentage { get; set; }
    public override void ShowCharacter()
    {
        base.ShowCharacter();

        Utilities.WriteLogBook($"Sono {EName} e sono un Warrior!");
/*    
        Utilities.WriteLogBook($"Epic Name .... : {EName}");
        Utilities.WriteLogBook($"Health Points  : {HealthPoints}");
        Utilities.WriteLogBook($"Speed ........ : {Speed}");
*/        
        Utilities.WriteLogBook($"Damage ....... : {DamagePercentage}");
    }

}

public class Wizard : Personaggio
{
    public int MaximumPower     { get; set; }
    public override void ShowCharacter()
    {
        base.ShowCharacter();
        Utilities.WriteLogBook($"Sono {EName} e sono un Wizard!");
/*
        Utilities.WriteLogBook($"Epic Name .... : {EName}");
        Utilities.WriteLogBook($"Health Points  : {HealthPoints}");
        Utilities.WriteLogBook($"Speed ........ : {Speed}");
*/        
        Utilities.WriteLogBook($"MaximumPower . : {MaximumPower}");
    }

}

public class Ork : Personaggio
{
    public int Strength         { get; set; }

   public override void ShowCharacter()
    {
        base.ShowCharacter();
        Utilities.WriteLogBook($"Sono {EName} e sono un Ork!");
/*        
        Utilities.WriteLogBook($"Epic Name .... : {EName}");
        Utilities.WriteLogBook($"Health Points  : {HealthPoints}");
        Utilities.WriteLogBook($"Speed ........ : {Speed}");
*/        
        Utilities.WriteLogBook($"Strength ..... : {Strength}");
    }

}