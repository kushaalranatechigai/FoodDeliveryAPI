using Common;
using Common.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryRepository.Implementations
{
   public  class FoodDeliveryRepositorys: IFoodDeliveryRepository
    {

        public FoodCustom GetFoodItems()
        {
            FoodCustom food = new FoodCustom
            {
                Id = 2,
                Name = "Paneer"
            };
            return food;
        }

        public IEnumerable<FoodCustom> GetFoodItemsIenumerable()
        {
            throw new NotImplementedException();
        }

    }
}
