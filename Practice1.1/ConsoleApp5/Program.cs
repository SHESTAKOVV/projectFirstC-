namespace ConsoleApp5;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();

        string[] words = inputString.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

        int wordCount = words.Length;

        inputString = "Start " + inputString;

        inputString += " End";
        
        Console.WriteLine($"Количество слов: {wordCount}");
        Console.WriteLine("Результат: " + inputString);
    }
}