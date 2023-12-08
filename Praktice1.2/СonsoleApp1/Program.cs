namespace Praktice;

public class Program
{
    static void Main(string[] args)
    {
        int[] collection = new int[100];
        int number = 0;

        for (int i = 0; i < collection.Length; i++)
        {
            collection[i] = number;
            number -= 3;
        }

        foreach (var num in collection)
        {
            Console.WriteLine(num + "");
        }
    }
}