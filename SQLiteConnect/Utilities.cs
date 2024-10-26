using System;
using System.IO;
using System.Text;
public static class Utilities
{

    public static void WriteBanner(string message)
    {

        int messLenght = message.Length;
        string stars = "****";
        int spaces = (Program.lineLength - messLenght - (stars.Length * 2)) / 2;

 
        string innerSpaces = "";

        for ( int i = 1; i <= spaces; i++ )
        {
            innerSpaces = innerSpaces + " ";
        }

        string leftSpaces = stars + innerSpaces;
        string rightSpaces = innerSpaces + stars;
        string messBanner = leftSpaces + message + rightSpaces;

        
        WriteLine("=", messBanner.Length);
        WriteLogBook(messBanner);
        WriteLine("=", messBanner.Length);

    }

     
    public static void WriteLine(string lineChar, int numChars)
    {
        string line = "";

        for ( int i = 1; i <= numChars; i++ )
        {
            line = line + lineChar;
        }

        WriteLogBook(line);
    }

    public static void WriteError(string errMessage)
    {
        WriteLine("*", Program.lineLength);
        WriteLogBook(errMessage);
        WriteLine("*", Program.lineLength);
    }

    public static void WriteLogBook(string message)
    {



    try
    {
        StreamWriter logbook = new StreamWriter("Logbook.txt", true, Encoding.ASCII);
        string timeToPrint = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        logbook.WriteLine($"{timeToPrint} : {message}");
        logbook.Close();
       
        if (Program.v3rb0se)
        {
            System.Console.WriteLine($"{timeToPrint} : {message}");
        }

    }
    catch(Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
    //    Console.WriteLine("Executing finally block.");
    }

    }
}
