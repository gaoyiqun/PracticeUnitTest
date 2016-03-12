using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatePostCost
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                //get the Product information from the webpages
                var product = this.GetProduct();

                var companyName = "";
                double fee = 0;

                if (this.drpCompany.SelectedValue == "1")
                {

                    BlackCat blackCat = new BlackCat() { ShipProduct = product };
                    blackCat.Calculate();
                    companyName = blackCat.GetsCompanyName();
                    fee = blackCat.GetsFee();
                }
                else if (this.drpCompany.SelectedValue == "2")
                {
                    Hsinchu hsinchu = new Hsinchu() { ShipProduct = product };
                    hsinchu.Calculate();
                    companyName = hsinchu.GetsCompanyName();
                    fee = hsinchu.GetsFee();
                }
                else if (this.drpCompany.SelectedValue == "3")
                {
                    PostOffice postOffice = new PostOffice() { ShipProduct = product };
                    postOffice.Calculate();
                    companyName = postOffice.GetsCompanyName();
                    fee = postOffice.GetsFee();
                }
                else
                {
                    var js = "alert('發生不預期錯誤，請洽系統管理者');location.href='http://tw.yahoo.com/';";
                    this.ClientScript.RegisterStartupScript(this.GetType(), "back", js, true);
                }

                this.SetResult(companyName, fee);
            }
        }

        private Product GetProduct()
        {
            var result = new Product
            {
                Name = this.txtProductName.Text.Trim(),
                Weight = Convert.ToDouble(this.txtProductWeight.Text),
                Size = new getSize()
                {
                    Length = Convert.ToDouble(this.txtProductLength.Text),
                    Width = Convert.ToDouble(this.txtProductWidth.Text),
                    Height = Convert.ToDouble(this.txtProductHeight.Text)
                },
                IsNeedCool = this.rdoNeedCool.SelectedValue == "1"
            };

            return result;
        }
        private void SetResult(string companyName, double fee)
        {
            this.lblCompany.Text = companyName;
            this.lblCharge.Text = fee.ToString();
        }

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

        
        private void CalculateByBlackCat()
        {
            this.lblCompany.Text = "黑貓";
            var weight = Convert.ToDouble(this.txtProductWeight.Text);
            if (weight > 20)
            {
                this.lblCharge.Text = "500";
            }
            else
            {
                var fee = 100 + weight * 10;
                this.lblCharge.Text = fee.ToString();
            }
        }
    **/
    }
}