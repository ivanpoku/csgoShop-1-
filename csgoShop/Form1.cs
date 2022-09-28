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
        double deagleCost;
        double tec9Cost;
        double glockCost;
        double deagleClick;
        double tec9Click;
        double glockClick;
        double taxRate = 0.13;
        
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
        }

        private void deagleImage_Click(object sender, EventArgs e)
        {

        }
    }
}
