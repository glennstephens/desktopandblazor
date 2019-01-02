using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.CoreLogic
{
    public class WeatherForecastViewModel : ViewModel
    {
        WeatherForecast[] _forecasts;
        private readonly IDataLoader loader;

        public WeatherForecast[] forecasts
        {
            get
            {
                return _forecasts;
            }
            set
            {
                ChangePropertyValue(ref _forecasts, value);
            }
        }

        public WeatherForecastViewModel(IDataLoader loader)
        {
            this.loader = loader;
        }

        public async Task LoadInitialData()
        {
            forecasts = await this.loader.GetForecasts();
        }
    }
}
