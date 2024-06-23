using System;


namespace BlazorApp.Shared
{
    public class WeatherForecast
    {
        public Properties Properties { get; set; }
    }
    public class Properties
    {
        public Timeseries[] Timeseries { get; set; }
    }
    public class Timeseries
    {
        public DateTime Time { get; set; }
        public Data Data { get; set; }
    }
    public class Data
    {
        public Instant Instant { get; set; }
    }
    public class Instant
    {
        public Details Details { get; set; }
    }

    public class Details
    {
        public double air_temperature { get; set; }
    }
}
