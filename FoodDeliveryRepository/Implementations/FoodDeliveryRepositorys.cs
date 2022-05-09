using Common;
using Common.EntityModels;
using System;
using System.Collections.Generic;

namespace FoodDeliveryRepository.Implementations
{
    public class FoodDeliveryRepositorys : IFoodDeliveryRepository
    {
        
        public FoodCustom GetFoodItems()
        {
            FoodCustom food = new FoodCustom
            {
                Id = 1,
                Name = "Briyani"
            };
            return food;
        }

        public IEnumerable<FoodCustom> GetFoodItemsIenumerable()
        {
            throw new NotImplementedException();
        }

    }
}
