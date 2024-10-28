// See https://aka.ms/new-console-template for more information
string path = "/Users/marco/Desktop/";
FileStream fs = File.Create(path + "testo2.txt");
fs.Close();

string content = System.IO.File.ReadAllText(path + "testo2.txt");
System.Console.WriteLine(content);
