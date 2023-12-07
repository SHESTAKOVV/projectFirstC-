namespace ConsoleApp4;

public class Program
{
    static int[] GenerateRandomArray(int start, int end)
    {
        Random random = new Random();
        int length = end - start + 1;
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(start, end + 1);
        }
        return array;
    }
    
    static void Main(string[] args)
    {
        Console.Write("Введите начало диапазона: ");
        int start = int.Parse(Console.ReadLine()); //очередной инициализатор массива 

        Console.Write("Введите конец диапазона: ");
        int end = int.Parse(Console.ReadLine());
        
        int[] randomNumbers = GenerateRandomArray(start, end);
        
        Console.WriteLine("Сгенерированный массив: ");
        foreach (int number in randomNumbers)
        {
            Console.Write(number + " ");
        }
    }
}