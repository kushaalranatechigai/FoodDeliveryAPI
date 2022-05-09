using Common.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IFoodDeliveryRepository
    {
        public FoodCustom GetFoodItems();
        public IEnumerable<FoodCustom> GetFoodItemsIenumerable();
    }
}

