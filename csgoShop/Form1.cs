using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void deagleImage_Click(object sender, EventArgs e)
        {
            reciptLabel.Visible = true;
            reciptPriceOutput.Text = $"{deagleCost}";
            itemBoughtOutput.Text = $"{deagleItem}";
            itemBought = deagleCost;
            subTotalOutput.Text = $"{itemBought}";


            
        }

        private void tenderedTextBox_TextChanged(object sender, EventArgs e)
        {
            tendered = Convert.ToDouble(tenderedTextBox.Text);
            tenderedReciptOutput.Text = $"{tendered}";
            subtotal = itemBought;

        }
    }
}
