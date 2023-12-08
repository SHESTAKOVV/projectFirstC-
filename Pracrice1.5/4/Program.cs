namespace _4;

public class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\gr622_sheeal\Desktop\numsTask4.txt");
        int[] numbers = lines[0].Split(' ').Select(int.Parse).ToArray();
        int maxNumber = numbers.Max();
        int sum = CalculateSum(numbers, maxNumber);

        Console.WriteLine("Сумма элементов, отличающихся от максимального на 1: " + sum);
        Console.ReadLine();
    }

    static int CalculateSum(int[] numbers, int maxNumber)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            if (Math.Abs(number - maxNumber) == 1)
            {
                sum += number;
            }
        }
        return sum;
    }
}