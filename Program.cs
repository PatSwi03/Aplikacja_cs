using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq.Expressions;

internal class Program
{


    static int a = 0, b = 0;
    static string pobrana;

    /// <summary>
    /// Procedura główna aplikacji
    /// </summary>
    /// <param name="args">Parametry wejsciowe w postacji tablicy tekstowej</param>

    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Podaj liczbę a: ");
            a = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Podaj liczbę b: ");
            b = int.Parse(Console.ReadLine()!);

            Console.WriteLine(a + b);

            Console.ReadLine();

        }
        catch (Exception)
        {
            Console.WriteLine("Stary podałeś coś nie tak. ");
        }
        }
   // private static void Kielbasa()
    //{
     //   Console.WriteLine($"Kielbasa");
        //TextReader tr = File.OpenText("D:\\Kodzik2\\ConsoleApp1\\README.md");
        //Console.WriteLine(tr.ReadToEnd());
   // }


}