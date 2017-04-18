using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterManager.Extentions
{
    public static class CalculatorHelper
    {
        public static int CaculatorWaterPrice(this int waterUsed)
        {
            int price = 0;
            if (waterUsed <= 50)
            {
                price = waterUsed * 10000;
            }
            else if (waterUsed <= 100 && waterUsed > 50)
            {
                price = (50 * 10000) + (waterUsed - 50) * 12000;
            }
            else
            {
                price = (50 * 10000) + (50 * 12000) + (waterUsed - 100) * 15000;
            }
            return price;
        }
        public static int CaculatorWaterPriceWithTax(this int price, int taxPercen)
        {
            return price + (price * taxPercen / 100);
        }
    }
}
