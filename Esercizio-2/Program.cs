using System;

// using System.Runtime.Intrinsics.Arm;

//  Marco Colautti
//  

class Program
{
    public const bool v3rb0se = true;
    static void Main()
    {
        // Ex_1();
        // Ex_2();
        // Ex_3();
        // Ex_14();
        Utilities.WriteLogBook("Inizio programma.");
        Ex_5();
        Utilities.WriteLogBook("Fine programma.");

    }
    
    static void Persona()
    {
        Person Marco = new Person("Alice Green", 64)
        {
            Address = new()
            {
                Street = "Rooswelt str.",
                StrNumber = "12345",
                City = "Geensboro"
            },

            BankAccount = new()
            {
                AccountNumber = "IT09X094230988248",
                Amount = 189386.32,
            }
        };
 
       Person Matteo = new Person("Walter Bigsbee", 33)
        {
            Address = new()
            {
                Street = "Main Str.",
                StrNumber = "22",
                City = "Charlotte"
            },

            BankAccount = new()
            {
                AccountNumber = "IT09X097678634848",
                Amount = 1245.32,
            }
        };

        Marco.PrintPerson();
        Matteo.PrintPerson();

    }
    static void Computers()
    {
        string mioComputer = "";

        Computer AppleOne = new Computer();
        AppleOne.brand = "Apple";
        AppleOne.model = "MacBook Pro 2015";
        AppleOne.memory  = 8192;
        AppleOne.procSpeed = "2,3 GHz";
        AppleOne.weight = 1500;

        Computer AppleTwo = new Computer();
        AppleTwo.brand = "Dell";
        AppleTwo.model = "Stratocaster";
        AppleTwo.memory  = 4096;
        AppleTwo.procSpeed = "3,0 GHz";
        AppleTwo.weight = 1600;

        System.Console.WriteLine("Computer 1");
        AppleOne.ShowComputer();
        System.Console.WriteLine();
        System.Console.WriteLine("Computer 2");
        AppleTwo.ShowComputer();


        AppleOne.procSpeed = "2,8 Ghz";

        int pesoComp2 = AppleTwo.weight;

    }

  
    static void Ex_1()
    //
    //  ## 1
    // 
    // The answer to all the questions is "42".
    // Generate a string with this truthy sentence, concatenating the sentence and the number, and print it on the console.
    // 
    {
         string testo = "The answer to all the questions is ";
         int quarantadue = 42;

        System.Console.WriteLine(testo + '"' + quarantadue + '"');
        System.Console.WriteLine(testo + "\"" + quarantadue + "\"");
        System.Console.WriteLine($"{testo}\"{quarantadue}\"" );

    }

    static void Ex_2()
    //
    // ## 2
    // 
    // Create a variable with a number of your choice.
    // Print the double and the triple of the number.
    // The numbers must be printed with a reasonable messages, concatenating strings and numbers.
    //
    {
        int numero = 8;
        int doppio = numero * 2;
        int triplo = numero * 3;

        System.Console.WriteLine("Numero base .... : " + numero);
        System.Console.WriteLine("Doppio ......... : " + doppio);
        System.Console.WriteLine("Triplo ......... : " + triplo);
    }

    static void Ex_3()
    // 
    //  ## 3
    // 
    // Create 2 strings, then print their concatenations forward and backward.
    // For example, if `string1` is `"Hello"` and `string2` is `"World"`, print `"HelloWorld"` and `"WorldHello"`.
    // 
    {
        string testo1 = "oggi piove";
        string testo2 = "governo ladro";

        System.Console.WriteLine(testo1 + ", " + testo2 + "!");
        System.Console.WriteLine(testo2 + ", " + testo1 + "!");
    }

    static void Ex_4()
    //
    // ## 4
    // 
    // Read 2 numbers from the Console, then print on the Console all the 5 integer operations (+, -, *, /, %).
    // Assume the user inputs valid data.
    // 
    {
        System.Console.WriteLine("Inserisci il primo numero");
        string string1 = System.Console.ReadLine();
        int numero1 = int.Parse(string1);
 
        System.Console.WriteLine("Inserisci il secondo numero");
        string string2 = System.Console.ReadLine();
        int numero2 = int.Parse(string2);

        int somma = numero1 + numero2;
        int sottrai = numero1 - numero2;
        int moltiplica = numero1 * numero2;
        int dividi = numero1 / numero2;

        System.Console.WriteLine("Numero #1 .. : " + numero1);
        System.Console.WriteLine("Numero #2 .. : " + numero2);
        System.Console.WriteLine("Somma ...... : " + somma);
        System.Console.WriteLine("Sottrai .... : " + sottrai);
        System.Console.WriteLine("Moltiplica . : " + moltiplica);
        System.Console.WriteLine("Dividi ..... : " + dividi);
    }

    static void Ex_5()
    //
    // ## 5
    // 
    // Create enough variables to contain the following information about a person:
    // 
    // * first name
    // * last name
    // * age
    // * profession.
    // 
    // Initialize them reading from the console.
    // Then print them in a user friendly manner.
    // 
    {

        System.Console.WriteLine("Please insert the follow informations.");
        System.Console.Write("First Name : ");
        string? firstName = System.Console.ReadLine();

        System.Console.Write("Last Name  : ");
        string? lastName = System.Console.ReadLine();

        System.Console.Write("Your age   : ");
        string? ageString = System.Console.ReadLine();

        int age = int.Parse(ageString);

        System.Console.Write("Your profession : ");
        string? profession = System.Console.ReadLine();

        System.Console.WriteLine("Your full name is " + firstName + " " + lastName);
        System.Console.WriteLine("Your age is " + age);
        System.Console.WriteLine("Your profession is " + profession); 

        //
        // ## 6
        // 
        // Just as the previous exercise, but displaying the inserted data with the JSON notation. The output on the console must be:
        // 
        //     {
        //       firstName: "Alice",
        //       lastName: "Green",
        //       age: 23,
        //       profession: "Software developer"
        //     }
        // 
        // Assume the user inputs a valid age.
        // Escape double quotation marks in `firstName`, `lastName`, `profession`. For example, if the user entered `Ali"ce` as first name, the output should be:
        // 
        //     {
        //       firstName: "Ali\"ce",
        //       lastName: "Green",
        //       age: 23,
        //       profession: "Software developer"
        //     }
        // 
        // This is not easy for a beginner, do not feel discouraged if you cannot do it.
        // 

        System.Console.WriteLine();
        System.Console.WriteLine("----- json format ----");

        System.Console.WriteLine("{");
        System.Console.WriteLine("   firstName: " + '"' + firstName + '"' + ',');
        System.Console.WriteLine("   lastName: " + '"' + lastName + '"' + ',');

        System.Console.WriteLine("   age: " + age + ',');
        System.Console.WriteLine("   profession: " + '"'+ profession + '"');
        System.Console.WriteLine("}"); 

    }

    static void Ex_7()
    //
    // ## 1
    // 
    // Again, as we all know, 42 is the answer to every question.
    // Read a number from the Console, and print on the Console if it is a multiple of 42 or not.
    // 
    {

        bool ritenta = true;

        while ( ritenta )
        {
            System.Console.Write("Enter a number : ");
            string numStringa = System.Console.ReadLine();

            int numero = int.Parse(numStringa);

            if ( numero % 42 == 0 )
            {
                System.Console.WriteLine("Complimenti! " + numero + " è multiplo di 42.");
                ritenta = false;
            } else {
                System.Console.WriteLine("Peccato.. riprova!");
            }
        }
    }

    static void Ex_8()
    // 
    // ## 2
    // 
    // Print all the integers divisible by 5 and 7, from 1 to 100.
    // 
    {

        for (int i = 1; i <= 100; i++)
        {

            if ( i % 5 == 0 && i % 7 == 0 )
            {
                System.Console.WriteLine(i + " è divisibile per 5 e per 7");
   
            }
        }

    }

    static void Ex_9()
    //
    // ## 3
    // 
    // Print all the integers multiple of 5 or 7, from 1 to 50.
    // 
    {
        System.Console.WriteLine("Multipli di 5");
        for ( int i = 5; i <= 50; i = i + 5)
        {
            System.Console.WriteLine(i);
        }

        System.Console.WriteLine("Multipli di 7");
        for ( int i = 7; i <= 50; i = i + 7)
        {
            System.Console.WriteLine(i);
        }
    }

    static void Ex_10()
    //
    // ## 4
    // 
    // Print the first 10 integers greater than 0 that are divisible by 5 or 7.
    // 
    {
            int conta = 0;
            int i = 1;

            while ( conta <= 10)
            {
                if ( i % 5 == 0 || i % 7 == 0 )
                {
                    System.Console.WriteLine(i + " è divisibile per 5 o 7");
                    conta++;
                }

                i++;

            }
    }

    static void Ex_11()
    //
    // ## 5
    // 
    // Print all the integers between -4 (excluded) and 19 (included), in backward order.
    // 
    {
        for ( int i = 19; i > -4; i--)
        {
            System.Console.WriteLine(i);
        }

    }

    static void Ex_12()
    //
    // ## 6
    // 
    // Print all the integers between -4 and 19 with a step of 3 (i.e. -4, -1, 2, ...)
    // 
    {
        for ( int i = -4; i <= 19; i = i+3)
        {
            System.Console.WriteLine(i);
        }
    }

    static void Ex_13()
    // ## 7
    // 
    // Write some code that prints any integer number like this:
    // 
    //     =====================
    //     = the number is: 42 =
    //     =====================
    // 
    //     ========================
    //     = the number is: 12345 =
    //     ========================
    // 
    {
        System.Console.Write("Insert number : ");
        string? numString = System.Console.ReadLine();


        string myString = "= the number is: " + numString + " =";
        int strLength = myString.Length;
        string myDash = "";

        for ( int i = 1; i <= strLength; i++)
        {
            myDash = myDash + "=";
        }

        System.Console.WriteLine(myDash);
        System.Console.WriteLine(myString);
        System.Console.WriteLine(myDash);
    }

    static void Ex_14()
    //
    // ## 8
    // 
    // Print a numeric triangle, with values up to 10. A numeric triangle is something like this:
    // 
    //     1
    //     1 2
    //     1 2 3
    //     1 2 3 4
    // 
    {
        string myString = "";
        int conta = 1;

        do
        {
            myString = myString + " " + conta;
            System.Console.WriteLine(myString);
            conta++;
        } while (conta < 1) ;



        // for ( int i =1; i <= 10; i++)
        // {
        //     myString = myString + " " + i;
        //     System.Console.WriteLine(myString);
        // }
    }

}