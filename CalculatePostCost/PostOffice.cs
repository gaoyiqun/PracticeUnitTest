using System;

namespace CalculatePostCost
{
    public class PostOffice : ILogistics
    {
        private double _fee;
        private readonly string _companyName = "PostOffice";

        public Product ShipProduct { get; set; }

        /**
         private void CalculateByPostOffice()
        {
            this.lblCompany.Text = "郵局";

            var weight = Convert.ToDouble(this.txtProductWeight.Text);
            var feeByWeight = 80 + weight * 10;

            var length = Convert.ToDouble(this.txtProductLength.Text);
            var width = Convert.ToDouble(this.txtProductWidth.Text);
            var height = Convert.ToDouble(this.txtProductHeight.Text);
            var size = length * width * height;
            var feeBySize = size * 0.0000353 * 1100;

            if (feeByWeight < feeBySize)
            {
                this.lblCharge.Text = feeByWeight.ToString();
            }
            else
            {
                this.lblCharge.Text = feeBySize.ToString();
            }
        }
        **/
        public void Calculate()
        {
            var weight = this.ShipProduct.Weight;
            var feeByWeight = 80 + weight * 10;

            var length = this.ShipProduct.Size.Length;
            var width = this.ShipProduct.Size.Width;
            var height = this.ShipProduct.Size.Height;
            var size = length * width * height;
            var feeBySize = size * 0.0000353 * 1100;

            if (feeByWeight < feeBySize)
            {
                this._fee = feeByWeight;
            }
            else
            {
                this._fee = feeBySize;
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