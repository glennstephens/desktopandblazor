using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.CoreLogic
{
    public interface IDataLoader
    {
        Task<WeatherForecast[]> GetForecasts();
    }
}
