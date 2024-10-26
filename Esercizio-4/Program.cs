class Program
{
    static void Main()
    {
        // You should use keyboard input value for this 
        int objectsToCreate = 12;

        // Create an array to hold all your objects
        Personaggio[] Personaggi = new Personaggio[objectsToCreate];

//      Random rnd = new Random();
        Random rnd = new Random(Guid.NewGuid().GetHashCode());

        string someVariable = " ";
        int warrior         = 0;
        int wizard          = 0;
        int ork             = 0;
        int elf             = 0;
        int tipoPersonaggio = 0;

        for (int i = 0; i < objectsToCreate; i++)
        {
            // Instantiate a new object, set it's number and
            // some other properties

            tipoPersonaggio = rnd.Next(1, 5);

            switch (tipoPersonaggio)
            {
            case 1:
                someVariable = "Warrior";
                warrior++;
                break;
            case 2:
                someVariable = "Wizard";            
                wizard++;
                break;
            case 3:
                someVariable = "Ork";            
                ork++;
                break;
            case 4:
                someVariable = "Elf";            
                elf++;
                break;
            }

            Personaggi[i] = new Personaggio()
            {
                ObjectNumber    = i + 1,
                SomeVariable    = someVariable,
                AnotherVariable = "AnotherValue"
            };

            Personaggi[i].ShowMyClass();            

        }

        System.Console.WriteLine($"Warriors ... : {warrior}");
        System.Console.WriteLine($"Wizards..... : {wizard}");
        System.Console.WriteLine($"Orks ....... : {ork}");
        System.Console.WriteLine($"Elfs........ : {elf}");

    }

}