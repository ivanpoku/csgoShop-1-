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
        double taxRate = 0.13;
        double tendered;
        string itemBought;
        double itemCost;
        double taxAmount;
        double total;
        double returned;
        string deagleItem = "Deagle";
        string tec9Item = "Tec9";
        string glockItem = "Glock";
        double money = 10000;
        double moneyOutput;

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
            tec9FiringTypeLabel.Visible = true;
            tec9Image.Visible = true;
            tec9PriceLabel.Visible = true;
            glockFiringTypeLabel.Visible = true;
            glockImage.Visible = true;
            glockPriceLabel.Visible = true;
            tenderedCashTextLabel.Visible = true;
            tenderedTextBox.Visible = true;
            calculatePurchaseButtton.Visible = true;
            totalCostDisplay.Visible = true;
        }

        private void deagleImage_Click(object sender, EventArgs e)
        {

            deagleImage.BorderStyle = BorderStyle.Fixed3D;
            tec9Image.BorderStyle = BorderStyle.FixedSingle;
            glockImage.BorderStyle = BorderStyle.FixedSingle;
            itemBought = deagleItem;
            itemCost = deagleCost;
            totalCostDisplay.Text = $"Total: {(itemCost * taxRate + itemCost).ToString("C")}";
        }

        private void tec9Image_Click_1(object sender, EventArgs e)
        {
            tec9Image.BorderStyle = BorderStyle.Fixed3D;
            glockImage.BorderStyle = BorderStyle.FixedSingle;
            deagleImage.BorderStyle = BorderStyle.FixedSingle;
            itemBought = tec9Item;
            itemCost = tec9Cost;
            totalCostDisplay.Text = $"Total: {(itemCost * taxRate + itemCost).ToString("C")}";
        }

        private void glockImage_Click(object sender, EventArgs e)
        {
            glockImage.BorderStyle = BorderStyle.Fixed3D;
            deagleImage.BorderStyle = BorderStyle.FixedSingle;
            tec9Image.BorderStyle = BorderStyle.FixedSingle;
            itemBought = glockItem;
            itemCost = glockCost;
            totalCostDisplay.Text = $"Total: {(itemCost * taxRate + itemCost).ToString("C")}";
        }
        private void tenderedTextBox_TextChanged(object sender, EventArgs e)



        {
            try
            {

                tendered = Convert.ToDouble(tenderedTextBox.Text);
                tenderedReciptOutput.Text = $"{tendered}";


            }
            catch
            {
                calculatePurchaseButtton.Text = $"Error";
                Thread.Sleep(2000);
                calculatePurchaseButtton.Text = $"Purchase";
            }
        }


        private void calculatePurchaseButtton_Click(object sender, EventArgs e)

        {
            if (tendered < deagleCost * taxRate + deagleCost)
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
                returnedAmountOutput.Visible = true;
                reciptPriceOutput.Visible = true;
                tenderedReciptOutput.Visible = true;
                newOrderButton.Visible = true;

                reciptPriceOutput.Text = $"{itemCost}";
                itemBoughtOutput.Text = $"{itemBought}";
                subTotalOutput.Text = $"{itemCost}";
                taxAmount = itemCost * taxRate;
                taxAmountOutput.Text = $"{taxAmount}";
                total = taxAmount + itemCost;
                returned = tendered - total;
                totalOutput.Text = $"{total}";
                returnedAmountOutput.Text = $"{returned}";
                moneyOutput = money - total;
                moneyCounter.Text = $"{moneyOutput.ToString("C")}";
            }
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            reciptLabel.Visible = false;
            reciptItemBoughtLabel.Visible = false;
            reciptPriceDisplay.Visible = false;
            reciptTextLabel.Visible = false;
            csgoReciptLabel.Visible = false;
            lineLabel1.Visible = false;
            lineLabel2.Visible = false;
            tenderedDisplayLabel.Visible = false;
            subTotalLabel.Visible = false;
            taxAmountLabel.Visible = false;
            totalTextLabel.Visible = false;
            returnedAmountLabel.Visible = false;
            itemBoughtOutput.Visible = false;
            subTotalOutput.Visible = false;
            taxAmountOutput.Visible = false;
            totalOutput.Visible = false;
            returnedAmountOutput.Visible = false;
            reciptPriceOutput.Visible = false;
            tenderedReciptOutput.Visible = false;
            newOrderButton.Visible = false;
            deagleImage.BorderStyle = BorderStyle.FixedSingle;
            tec9Image.BorderStyle = BorderStyle.FixedSingle;
            glockImage.BorderStyle = BorderStyle.FixedSingle;
        }


    }
}
