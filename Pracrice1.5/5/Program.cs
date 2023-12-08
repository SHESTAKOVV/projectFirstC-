namespace _5;

public class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\gr622_sheeal\Desktop\numsTask5.txt");
        int[] numbers = lines[0].Split(' ').Select(int.Parse).ToArray();
        int minIndex = FindMinIndex(numbers);
        int maxIndex = FindMaxIndex(numbers);
        double average = CalculateAverage(numbers, minIndex, maxIndex);

        Console.WriteLine("Среднее арифметическое элементов между минимальным и максимальным числами: " + average);
        Console.ReadLine();
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

    static int FindMaxIndex(int[] numbers)
    {
        int maxIndex = 0;
        int maxValue = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxValue)
            {
                maxIndex = i;
                maxValue = numbers[i];
            }
        }

        return maxIndex;
    }

    static double CalculateAverage(int[] numbers, int startIndex, int endIndex)
    {
        double sum = 0;
        int count = 0;

        for (int i = startIndex + 1; i < endIndex; i++)
        {
            sum += numbers[i];
            count++;
        }
        return sum / count;
    }
} 