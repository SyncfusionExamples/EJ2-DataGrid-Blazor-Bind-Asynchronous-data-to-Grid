using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class WeatherForecastService
    {
        public Task<WeatherForecast[]> GetForecastAsync()
        {
            Task.Delay(500);
            return Task.FromResult(WeatherForecast.GetAllRecords().ToArray());
        }
    }
}
