namespace _3;

public class Program
{
    static public void Main()
    {
        Console.WriteLine("Прошу введи число");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Определяем будет ли число чётным и кратным 10");
        if (number % 2 == 0 && number % 10 == 0)
        {
            Console.WriteLine($"Ваше число {number} чётно и кратно на 10 ");
        }
        else
        {
            Console.WriteLine($"Ваше число не чётно и не кратно 10");
        }
    }
}