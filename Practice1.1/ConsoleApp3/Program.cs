namespace ConsoleApp3;

public class Program
{
    static void Main()
    {
        List<string> myList = new List<string>();

        while (true)
        {
            Console.Write("Введите элемент списка (или оставьте пустую строку для завершения): ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                break;

            myList.Add(input);
        }

        if (myList.Count > 0)
        {
            string shortest = FindShortest(myList);
            string longest = FindLongest(myList);

            Console.WriteLine($"Самый короткий элемент: {shortest}");
            Console.WriteLine($"Самый длинный элемент: {longest}");
        }
        else
        {
            Console.WriteLine("Список пуст.");
        }
    }

    static string FindShortest(List<string> list)
    {
        string shortest = list[0];
        foreach (string item in list)
        {
            if (item.Length < shortest.Length)
            {
                shortest = item;
            }
        }

        return shortest;
    }

    static string FindLongest(List<string> list)
    {
        string longest = list[0];
        foreach (string item in list)
        {
            if (item.Length > longest.Length)
            {
                longest = item;
            }
        }

        return longest;
    }
}



