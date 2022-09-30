﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


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
        double taxAmount;
        double total;
        double returned;
        string deagleItem = "Deagle";
        string tec9Item = "Tec9";
        string glockItem = "Glock";
        double money = 10000;
        double moneyOutput;
        double multiItemPrices = 0;
        int deagleCounter;
        int tec9Counter;
        int glockCounter;
        double multiTaxTotal;


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
            walletLabel.Visible = true;
            moneyCounter.Visible = true;
            moneyCounter.Text = $"{money.ToString("C")}";
        }

        private void deagleImage_Click(object sender, EventArgs e)
        {


            deagleImage.BorderStyle = BorderStyle.Fixed3D;
            itemBought = deagleItem;
            deagleCounter = deagleCounter + 1;
            multiItemPrices = multiItemPrices + deagleCost;
            multiTaxTotal = multiItemPrices * taxRate + multiItemPrices;
            totalCostDisplay.Text = $"Total: {multiTaxTotal.ToString("C")}";
            deagleFiringTypeLabel.Text = $"Deagle x{deagleCounter}";
            SoundPlayer selectPlayer = new SoundPlayer(Properties.Resources.select_Audio);
            selectPlayer.Play();


        }

        private void tec9Image_Click_1(object sender, EventArgs e)
        {
            tec9Image.BorderStyle = BorderStyle.Fixed3D;
            itemBought = tec9Item;
            tec9Counter = tec9Counter + 1;
            multiItemPrices = multiItemPrices + tec9Cost;
            multiTaxTotal = multiItemPrices * taxRate + multiItemPrices;
            totalCostDisplay.Text = $"Total: {multiTaxTotal.ToString("C")}";
            tec9FiringTypeLabel.Text = $"Tec9 x{tec9Counter}";
            SoundPlayer selectPlayer = new SoundPlayer(Properties.Resources.select_Audio);
            selectPlayer.Play();
        }

        private void glockImage_Click(object sender, EventArgs e)
        {
            glockImage.BorderStyle = BorderStyle.Fixed3D;
            itemBought = glockItem;
            glockCounter = glockCounter + 1;
            multiItemPrices = multiItemPrices + glockCost;
            multiTaxTotal = multiItemPrices * taxRate + multiItemPrices;
            totalCostDisplay.Text = $"Total: {multiTaxTotal.ToString("C")}";
            glockFiringTypeLabel.Text = $"Glock x{glockCounter}";
            SoundPlayer selectPlayer = new SoundPlayer(Properties.Resources.select_Audio);
            selectPlayer.Play();
        }
        private void tenderedTextBox_TextChanged(object sender, EventArgs e)



        {
            try
            {

                tendered = Convert.ToDouble(tenderedTextBox.Text);
                tenderedReciptOutput.Text = $"{tendered.ToString("C")}";


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
            if (tendered < multiItemPrices * taxRate + multiItemPrices)
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
                tenderedReciptOutput.Visible = true;
                newOrderButton.Visible = true;
                SoundPlayer reciptSound = new SoundPlayer(Properties.Resources.reciptPrint_Audio);
                reciptSound.Play();

                itemBoughtOutput.Text = $"Deagle x{deagleCounter}";
                itemBoughtOutput.Text += $"\nTec9 x{tec9Counter}";
                itemBoughtOutput.Text += $"\nGlock x{glockCounter}";
                subTotalOutput.Text = $"{multiItemPrices.ToString("C")}";
                taxAmount = multiItemPrices * taxRate;
                taxAmountOutput.Text = $"{taxAmount.ToString("C")}";
                total = taxAmount + multiItemPrices;
                returned = tendered - total;
                totalOutput.Text = $"{total.ToString("C")}";
                returnedAmountOutput.Text = $"{returned.ToString("C")}";
                moneyOutput = money - total;
                moneyCounter.Text = $"{moneyOutput.ToString("C")}";
                
            }
            if (tendered > 10000)
            {
                calculatePurchaseButtton.Text = $"Insufficent Funds";
                
                reciptLabel.Visible = false;
                reciptItemBoughtLabel.Visible = false;
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
                tenderedReciptOutput.Visible = false;
                newOrderButton.Visible = false;
                this.Refresh();
                Thread.Sleep(2000);
                calculatePurchaseButtton.Text = $"Purchase";

            }
            else
            {
                reciptLabel.Visible = true;
                reciptItemBoughtLabel.Visible = true;
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
                tenderedReciptOutput.Visible = true;
                newOrderButton.Visible = true;
                SoundPlayer reciptSound = new SoundPlayer(Properties.Resources.reciptPrint_Audio);
                reciptSound.Play();

                itemBoughtOutput.Text = $"Deagle x{deagleCounter}";
                itemBoughtOutput.Text += $"\nTec9 x{tec9Counter}";
                itemBoughtOutput.Text += $"\nGlock x{glockCounter}";
                subTotalOutput.Text = $"{multiItemPrices.ToString("C")}";
                taxAmount = multiItemPrices * taxRate;
                taxAmountOutput.Text = $"{taxAmount.ToString("C")}";
                total = taxAmount + multiItemPrices;
                returned = tendered - total;
                totalOutput.Text = $"{total.ToString("C")}";
                returnedAmountOutput.Text = $"{returned.ToString("C")}";
                moneyOutput = money - total;
                moneyCounter.Text = $"{moneyOutput.ToString("C")}";

            }

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            deagleCounter = 0;
            tec9Counter = 0;
            glockCounter = 0;
            reciptLabel.Visible = false;
            reciptItemBoughtLabel.Visible = false;
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
            tenderedReciptOutput.Visible = false;
            newOrderButton.Visible = false;
            deagleImage.BorderStyle = BorderStyle.FixedSingle;
            tec9Image.BorderStyle = BorderStyle.FixedSingle;
            glockImage.BorderStyle = BorderStyle.FixedSingle;
        }

       
    }
}
