using System;
using System.IO;
using System.Text;
public static class Utilities
{

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
