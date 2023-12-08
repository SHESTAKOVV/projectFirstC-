namespace _1;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Доброго времени суток. Введите ваше целое положительное число ");
        int n = int.Parse(Console.ReadLine());

        int product = 1;
        int currentNumber = 3;

        while (currentNumber <= n)
        {
            product *= currentNumber;
            currentNumber += 3;
        }
        Console.WriteLine($"Произведение натуральных чисел, кратных трём и не превышающих заданное ваши число {n}: {product}" );
    }
}