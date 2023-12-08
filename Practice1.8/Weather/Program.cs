namespace Weather;

using Newtonsoft.Json;

public class Program
{

    static void PrintTemp(string city)
    {
        Console.WriteLine(city);
        HttpClient town = new HttpClient();
        string geolocation = $"http://api.openweathermap.org/geo/1.0/direct?q={city}&appid=60a5968c02730f76fceb1976af1f02aa";
        
        var response = town.GetAsync( geolocation ).Result;
        string responseString = response.Content.ReadAsStringAsync().Result;
        
        GeolocationData locate = JsonConvert.DeserializeObject<GeolocationData[]>(responseString)[0];
        
        string weather = $"https://api.openweathermap.org/data/2.5/weather?lat={locate.lat}&lon={locate.lon}&lang=ru&units=metric&appid=60a5968c02730f76fceb1976af1f02aa";
        
        var response1 = town.GetAsync( weather ).Result;
        string responseString1 = response1.Content.ReadAsStringAsync().Result;
        
        GetWeather location = JsonConvert.DeserializeObject<GetWeather>(responseString1);
        
        Console.WriteLine("Температура: " + location.main.temp);
        Console.WriteLine("Ощущается как: " + location.main.feels_like);
    }
    static void Main()
    {
        string path = @"C:\Users\hizay\OneDrive\Рабочий стол\settings.json";

        string settingsCity = File.ReadAllText(path);

        if (settingsCity != "")
        {
            inisialization cityDefault = JsonConvert.DeserializeObject<inisialization>(settingsCity);
            PrintTemp(cityDefault.cityDefault);
        }
        
        Console.WriteLine(" 1 - выбрать новый город по умолчанию \n 2 - погода любого указанного вами города планеты земля");
        
        int chose = int.Parse(Console.ReadLine());
        
        if (chose == 1)
        {
            Console.WriteLine("Ваш новый город по умолчанию: ");
            string cityDefault = Console.ReadLine();
            
            inisialization settings = new inisialization();
            settings.cityDefault = cityDefault;
            string Json = JsonConvert.SerializeObject(settings);
            
            File.WriteAllText(path, Json);
        }
        else
        {
            Console.WriteLine("Введите ваш город: ");
            string city = Console.ReadLine();
            PrintTemp(city);
        }
    }
}

class inisialization
{
    public string cityDefault;
}
class GetWeather
{
    public weatherDate main;
}

class weatherDate
{
    public float temp;
    public float feels_like;
}
class GeolocationData
{
    public float lon;
    
    public float lat;
}