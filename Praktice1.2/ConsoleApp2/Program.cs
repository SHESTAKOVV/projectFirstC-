namespace ConsoleApp2;

public class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[n];
        int number = 1;
       
        int n = int.Parse(Console.ReadLine()); //Я назову тебя инициализатор массива

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = number;
            number += 2;
            Console.WriteLine(array[i]);
        }
    }
}