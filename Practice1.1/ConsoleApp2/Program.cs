namespace ConsoleApp2;

public class Program
{
    static void Main()
    {
        List <int> numbers = new List<int>();
        
        int input;
        do
        {
            Console.Write("Введите число (для завершения введите 0): ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);
        
        int sum = 0;
        int op = 1;

        foreach (int number in numbers)
        {
            sum += number;
            op *= number;
        }
        
        Console.WriteLine($"Сумма элементов списка: {sum}");
        Console.WriteLine($"Произведение элементов списка: {op}");
        
        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"Ср.значение элементов списка: {average}");
        }
        else
        {
            Console.WriteLine("Список пуст, невозможно вычислить среднее значение.");
        }
    }
}