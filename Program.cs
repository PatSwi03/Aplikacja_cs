using System.IO;
internal class Program
{


    /// <summary>
    /// Procedura główna aplikacji
    /// </summary>
    /// <param name="args">Parametry wejsciowe w postacji tablicy tekstowej</param>

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Kielbasa();
        Console.ReadLine();
        
    }


    /// <summary>
    /// 
    /// </summary>
    private static void Kielbasa()
    {
        Console.WriteLine($"Kielbasa");
        //TextReader tr = File.OpenText("D:\\Kodzik2\\ConsoleApp1\\README.md");
        //Console.WriteLine(tr.ReadToEnd());
    }


}