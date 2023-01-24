using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    //{
    //// Zadanie 1Napisać program służący do konwersji wartości temperatury podanej w stopniach Celsjusza na stopnie w skali Fahrenheita(stopnie Fahrenheita = 1.8 * stopnie Celsjusza + 32.0)

    //        Console.WriteLine("Podaj temperaturę w stopniach Celsjusza, a otrzymasz temperaturę podaną w skali Fahrenheita");

    //         try
    //         {
    //             int TempC = int.Parse(Console.ReadLine());
    //             Console.WriteLine((1.8 * TempC + 32.0) + " to temperatura w skali Fahrenheita");
    //         }
    //         catch {

    //             Console.WriteLine("Nie podałeś liczby!");
    //         }
    //}

    {
        //Zadanie 2 Wczytać od użytkownika 3 liczby całkowite i wypisać na ekran największą oraz najmniejszą z nich
        int[] tablica = new int[3];
        Console.WriteLine("Podaj pierwszą liczbę");
        tablica[0]= int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj drugą liczbę");
        tablica[1] = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj trzecią liczbę");
        tablica[2] = int.Parse(Console.ReadLine());
        Console.WriteLine("Najmniejsza liczba to: " + tablica.Min());
        Console.WriteLine("Najmwiększa liczba to: " + tablica.Max());

    }
}