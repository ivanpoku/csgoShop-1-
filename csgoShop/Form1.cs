using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace csgoShop
{
    public partial class Form1 : Form
    {
        double deagleCost = 700;
        double tec9Cost = 500;
        double glockCost = 200;
        double deagleClick;
        double tec9Click;
        double glockClick;
        double taxRate = 0.13;
        double tendered;
        double subtotal;
        double itemBought;
        double taxAmount;
        double total;
        double returned;
        string deagleItem = "Deagle";

        
        public Form1()
        {
            InitializeComponent();
        }


        private void pistolShopFunction_Click(object sender, EventArgs e)
        {
            gunDisplayLabel.Visible = true;
            deagleFiringTypeLabel.Visible = true;
            deagleImage.Visible = true;
            deaglePriceLabel.Visible = true;
            tec9FiringTypeLabel.Visible=true;
            tec9Image.Visible=true;
            tec9PriceLabel.Visible=true;
            glockFiringTypeLabel.Visible = true;
            glockImage.Visible=true;
            glockPriceLabel.Visible=true;
            tenderedCashTextLabel.Visible=true;
            tenderedTextBox.Visible=true;
            calculatePurchaseButtton.Visible = true;
        }

        private void deagleImage_Click(object sender, EventArgs e)
        {
            
            reciptPriceOutput.Text = $"{deagleCost}";
            itemBoughtOutput.Text = $"{deagleItem}";
            subTotalOutput.Text = $"{deagleCost}";
            taxAmount = deagleCost * taxRate;
            taxAmountOutput.Text = $"{taxAmount}";
            total = taxAmount + deagleCost;
            totalOutput.Text = $"{total}";
            returned = tendered - total;
            returnedAmountOutput.Text = $"{returned}";




        }

        private void tenderedTextBox_TextChanged(object sender, EventArgs e)
        {
            tendered = Convert.ToDouble(tenderedTextBox.Text);
            tenderedReciptOutput.Text = $"{tendered}";
            subtotal = itemBought;

        }

        private void calculatePurchaseButtton_Click(object sender, EventArgs e)
        
        {
            if (tendered < deagleCost*taxRate+deagleCost)
            {
                calculatePurchaseButtton.Text = $"Insufficent Funds";
                this.Refresh();
                Thread.Sleep(2000);
                calculatePurchaseButtton.Text = $"Purchase";
            }
            else
            {
                reciptLabel.Visible = true;
                reciptItemBoughtLabel.Visible = true;
                reciptPriceDisplay.Visible = true;
                reciptTextLabel.Visible = true;
                csgoReciptLabel.Visible = true;
                lineLabel1.Visible = true;
                lineLabel2.Visible = true;
                tenderedDisplayLabel.Visible = true;
                subTotalLabel.Visible = true;
                taxAmountLabel.Visible = true;
                totalTextLabel.Visible = true;
                returnedAmountLabel.Visible = true;
                itemBoughtOutput.Visible = true;
                subTotalOutput.Visible = true;
                taxAmountOutput.Visible = true;
                totalOutput.Visible = true;
                returnedAmountOutput.Visible=true;
                reciptPriceOutput.Visible = true;
                tenderedReciptOutput.Visible = true;

                

            }
        }
    }
}
