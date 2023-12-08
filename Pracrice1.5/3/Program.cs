namespace _3;

public class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\gr622_sheeal\Desktop\numsTask3.txt");
        int[] numbers = lines[0].Split(' ').Select(int.Parse).ToArray();
        int minIndex = FindMinNum(numbers);
        double average = AvgCalc(numbers, minIndex);
        Console.WriteLine($"Среднее арифметическое элементов до минимального числа: {average} ");
    }
    static double AvgCalc(int[] numbers, int endIndex)
    {
        double sum = 0;
        for (int i = 0; i < endIndex; i++)
        {
            sum += numbers[i];
        }
        return sum / endIndex;
    }
    
    static int FindMinNum(int[] numbers)
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
}