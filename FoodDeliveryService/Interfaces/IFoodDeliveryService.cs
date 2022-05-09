using Common.EntityModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodDeliveryService.Interfaces
{
    public interface IFoodDeliveryService
    {
        public FoodCustom GetFoodItems();
        public IEnumerable<FoodCustom> GetFoodItemsIenumerable();
    }
}
