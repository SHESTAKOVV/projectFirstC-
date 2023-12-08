namespace _4;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите положительное число a:");
        
        int a = int.Parse(Console.ReadLine());
        int sum = 0;
        
        while (true)
        {
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
                break;

            if (number % a == 0)
                sum += number;
        }
        Console.WriteLine("Сумма чисел, делящихся на число a нацело: " + sum);
    }
}