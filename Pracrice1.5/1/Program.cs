namespace _1;

public class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\gr622_sheeal\Desktop\numsTask1.txt");
        int[] numbers = Array.ConvertAll(lines[0].Split(' '), int.Parse);
        int minIndex = FindMinIndex(numbers);
        int product = (int)CalculateProduct(numbers, minIndex + 1);

        Console.WriteLine("Произведение элементов после минимального числа: " + product);
    }
    
    static int FindMinIndex(int[] numbers)
    {
        int minIndex = 0;
        int minValue = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < minValue)
            {
                minIndex = i;
                minValue = numbers[i];
            }
        }
        return minIndex;
    }
    
    static long CalculateProduct(int[] numbers, int startIndex)
    {
        long product = 1;
        for (int i = startIndex; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    } 
}