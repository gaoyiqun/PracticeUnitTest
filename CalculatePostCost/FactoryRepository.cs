using System;

namespace CalculatePostCost
{
    public class FactoryRepository
    {
        public static ILogistics GetILogistics(string company, Product product)
        {

            if (company == "1")
            {
                return new BlackCat() { ShipProduct = product };
            }
            else if (company == "2")
            {
                return new Hsinchu() { ShipProduct = product };
            }
            else if (company == "3")
            {
                return new PostOffice() { ShipProduct = product };
            }
            else
            {
                return null;
            }
        }
    }
}