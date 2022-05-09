using Common;
using Common.EntityModels;
using FoodDeliveryService.Interfaces;
using System.Collections.Generic;

namespace FoodDeliveryService.Implementations
{
    public class FoodDeliveryServices : IFoodDeliveryService
    {
        private IFoodDeliveryRepository _foodDeliveryRepository;

        public FoodDeliveryServices(IFoodDeliveryRepository foodDeliveryRepository)
        {
            _foodDeliveryRepository = foodDeliveryRepository;
        }

        public FoodCustom GetFoodItems()
        {
            return _foodDeliveryRepository.GetFoodItems();
        }

        public IEnumerable<FoodCustom> GetFoodItemsIenumerable()
        {
            return _foodDeliveryRepository.GetFoodItemsIenumerable();

        }
    }
}
