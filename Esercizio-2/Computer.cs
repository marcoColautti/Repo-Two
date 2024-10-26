class Computer
{
    public string brand                 { get; set; }
    public string model                 { get; set; }
    public string procSpeed             { get; set; }
    public int memory                   { get; set; }
    public int weight                   { set; get; }

    public void ShowComputer()
    {
        System.Console.WriteLine($"Brand ....... : {brand}");
        System.Console.WriteLine($"Model ....... : {model}");
        System.Console.WriteLine($"ProcSpeed ... : {procSpeed}");
        System.Console.WriteLine($"Memory ...... : {memory}");
        System.Console.WriteLine($"Weight ...... : {weight}");
    }

}