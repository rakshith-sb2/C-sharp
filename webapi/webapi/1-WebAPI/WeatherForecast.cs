namespace _1_WebAPI
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
        public string Message { get; set; } // New property for the message

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

}