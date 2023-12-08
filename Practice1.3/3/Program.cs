namespace _3;

public class Program
{
    static void Main(string[] args)
    {
        int[] dot = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        int maxZona = 0;
        int left = 0;
        int right = dot.Length - 1;

        while (left < right)
        {
            int zone = Math.Min(dot[left], dot[right]) * (right - left);
            maxZona = Math.Max(maxZona, zone);

            if (dot[left] < dot[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        Console.WriteLine($"Наибольший объем: {maxZona}");
    }
}
