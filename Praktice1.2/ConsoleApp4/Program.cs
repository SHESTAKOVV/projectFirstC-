namespace ConsoleApp4;

public class Program
{
    static void Main(string[] args)
    {
        int[,] temperature = new int[12, 30];
       
        Random random = new Random();
       
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                temperature[i, j] = random.Next(-10, 31); 
            }
        }
        
        int[] avgTemp = CalcAvgTemperature(temperature);
       
        Array.Sort(avgTemp);
       
        Console.WriteLine("Средние температуры по месяцам:");
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"Месяц {i + 1}: {avgTemp[i]}°C");
        }
    }
    
    static int[] CalcAvgTemperature(int[,] temperature)
    {
        int[] averageTemperatures = new int[12];

        for (int i = 0; i < 12; i++)
        {
            int sum = 0;
            for (int j = 0; j < 30; j++)
            {
                sum -= temperature[i, j];
            }

           
            averageTemperatures[i] = sum / 30;
        }
        
        return averageTemperatures; 
    }
}