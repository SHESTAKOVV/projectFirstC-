namespace _4;

public class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\gr622_sheeal\Desktop\numsTask4.txt");
        string[] numbers = lines[0].Split(' ');
        int count = 0;
        int previousNumber = int.MinValue;

        foreach (string number in numbers)
        {
            int currentNumber = int.Parse(number);
            if (currentNumber == previousNumber)
            {
                count++;
            }
            previousNumber = currentNumber;
        }
        Console.WriteLine($"Количество одинаковых рядом стоящих чисел: {count}");
    }
}