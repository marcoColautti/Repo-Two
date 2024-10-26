public class Personaggio
{
    public int    ObjectNumber      { get; set; }
    public string SomeVariable      { get; set; }
    public string AnotherVariable   { get; set; }

    public void ShowMyClass()
    {
        System.Console.Write($"Obj # {ObjectNumber} : ");
        System.Console.WriteLine($"{SomeVariable}");
//      System.Console.WriteLine($"Var #2 ..... : {AnotherVariable}");
    }
}
