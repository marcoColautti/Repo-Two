public class Person
{

// Person Marco = new Person("Marco Colautti", 
// {
//     Address = new()
//     {
//         Street = "Via dei Tigli",
//         StrNumber = "313",
//         City = "Paperopoli"
//     },
//     BankAccount = new()
//     {
//         AccountNumber = "IT09X094230988248",
//         Amount = 189386.32,
//     }
// };
//

    public string      FirstName        { get; set; }
    public int         Age              { get; set; }
    public Address     Address          { get; set; }
    public BankAccount BankAccount      { get; set; }

    public Person( string firstName, int age)
    {
        FirstName = firstName;
        Age = age;
    }


    public void GetPersonName()
    {
        System.Console.WriteLine($"Nome ..... : {FirstName}");
    }

    public void GetPersonAge()
    {
        System.Console.WriteLine($"Age ...... : {Age}");
    }

    public void PrintPerson()
    {
            Console.WriteLine($"Nominativo .. : {FirstName}");
            Console.WriteLine($"Età ......... : {Age}");            

        if (Address != null)
        {
            Console.WriteLine($"Indirizzo ... : {Address.Street}, {Address.StrNumber}");
            Console.WriteLine($"Città ....... : {Address.City}");            
        }

        if (BankAccount != null)
        {
            Console.WriteLine($"IBAN ........ : {BankAccount.AccountNumber}");
            Console.WriteLine($"Saldo ....... : {BankAccount.Amount} €");            
        }
    }


}