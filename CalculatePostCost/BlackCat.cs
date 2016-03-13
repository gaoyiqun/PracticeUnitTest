using System;

namespace CalculatePostCost
{
    public class BlackCat:ILogistics
    {
        private double _fee;
        private readonly string _companyName = "BlackCat";

        public Product ShipProduct { get; set; }

        public void Calculate()
        {
            var weight = this.ShipProduct.Weight;
    
            if (weight > 20)
            {
                this._fee = 500;
            }
            else
            {            
                var fee = 100 + weight * 10;
                this._fee = fee;
            }
        }

        public string GetsCompanyName()
        {
            return this._companyName;
        }

        public double GetsFee()
        {
            return this._fee;
        }
    }
}