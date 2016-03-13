using System;

namespace CalculatePostCost
{
    public class Hsinchu : ILogistics
    {
        private double _fee;
        private readonly string _companyName = "Hsinchu";

        public Product ShipProduct { get; set; }

        /**
        private void CalculateByHsinchu()
        {
            this.lblCompany.Text = "新竹貨運";
            var length = Convert.ToDouble(this.txtProductLength.Text);
            var width = Convert.ToDouble(this.txtProductWidth.Text);
            var height = Convert.ToDouble(this.txtProductHeight.Text);

            var size = length * width * height;

            //長 x 寬 x 高（公分）x 0.0000353
            if (length > 100 || width > 100 || height > 100)
            {
                this.lblCharge.Text = (size * 0.0000353 * 1100 + 500).ToString();
            }
            else
            {
                this.lblCharge.Text = (size * 0.0000353 * 1200).ToString();
            }
        }

    */
        public void Calculate()
        {
            var length = this.ShipProduct.Size.Length;
            var width = this.ShipProduct.Size.Width;
            var height = this.ShipProduct.Size.Height;

            var size = length * width * height;

            //長 x 寬 x 高（公分）x 0.0000353
            if (length > 100 || width > 100 || height > 100)
            {
                this._fee = size * 0.0000353 * 1100 + 500;
            }
            else
            {
                this._fee = size * 0.0000353 * 1200;
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