namespace ConsoleApp5;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int[]> temperate = new Dictionary<string, int[]>()
        {
            {"January", new int[]{ -13, -12, -11, -10, -9, -8, -7, -6, -5}},
            {"February", new int[]{ -10, -9, -8, -7, -6, -5, -4}},
            {"March", new int[]{ -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, }},
            {"April", new int[]{ 6, 7, 8, 9, 10, 11}},
            {"May", new int[]{ 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30}},
            {"June", new int[]{ 19, 20, 21, 22, 23, 24, 25, 26, 27}} ,
            {"July", new int[]{ 22, 23, 24, 25, 26, 27, 28, 29, 30}},
            {"August", new int[]{ 20, 21, 22, 23, 24, 25, 26, 27, 28}},
            {"September", new int[]{ 13, 14, 15, 16, 17, 18, 19, 20, 21 }},
            {"October", new int[]{ 7, 8, 9, 10, 11, 12, 13, 14, 15 }},
            {"November", new int[]{ -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}},
            {"December", new int[]{-11, -10, -9, -8, -7, -6, -5, -4}}
        };

        Dictionary<string, double> avgTemperature = CalcAvgTemperat(temperate);

        foreach (var kvp in avgTemperature)
        {
            Console.WriteLine($"Average temperat in {kvp.Key}: {kvp.Value}");
        }
    }

    static Dictionary<string, double> CalcAvgTemperat(Dictionary<string, int[]> temperate)
    {
        Dictionary<string, double> avgTemperat = new Dictionary<string, double>();

        foreach (var kvp in temperate)
        {
            string month = kvp.Key;
            int[] temps = kvp.Value;

            double average = CalcAvg(temps);
            avgTemperat.Add(month, average);
        }
        return avgTemperat;
    }

    static double CalcAvg(int[] temperatures)
    {
        int sum = 0;
        foreach (int temp in temperatures)
        {
            sum += temp;
        }
        double average = (double)sum / temperatures.Length;
        return average;
    }
}