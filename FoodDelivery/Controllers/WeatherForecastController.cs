using Common.EntityModels;
using FoodDeliveryService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodDelivery.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IFoodDeliveryService _foodDeliveryService;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IFoodDeliveryService foodDeliveryService)
        {
            _logger = logger;
            _foodDeliveryService = foodDeliveryService;
        } 

    [HttpGet]
        public FoodCustom Get()
        {
            return _foodDeliveryService.GetFoodItems();
        }
    }
}
