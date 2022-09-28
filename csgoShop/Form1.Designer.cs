namespace csgoShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.shopBase = new System.Windows.Forms.PictureBox();
            this.pistolShopFunction = new System.Windows.Forms.Label();
            this.gunDisplayLabel = new System.Windows.Forms.Label();
            this.deagleImage = new System.Windows.Forms.PictureBox();
            this.deaglePriceLabel = new System.Windows.Forms.Label();
            this.deagleFiringTypeLabel = new System.Windows.Forms.Label();
            this.tec9FiringTypeLabel = new System.Windows.Forms.Label();
            this.tec9PriceLabel = new System.Windows.Forms.Label();
            this.tec9Image = new System.Windows.Forms.PictureBox();
            this.glockFiringTypeLabel = new System.Windows.Forms.Label();
            this.glockPriceLabel = new System.Windows.Forms.Label();
            this.glockImage = new System.Windows.Forms.PictureBox();
            this.reciptLabel = new System.Windows.Forms.Label();
            this.csgoReciptLabel = new System.Windows.Forms.Label();
            this.ReciptTextLabel = new System.Windows.Forms.Label();
            this.lineText = new System.Windows.Forms.Label();
            this.tenderedTextBox = new System.Windows.Forms.TextBox();
            this.tenderedCashTextLabel = new System.Windows.Forms.Label();
            this.reciptPriceDisplay = new System.Windows.Forms.Label();
            this.tenderedDisplayLabel = new System.Windows.Forms.Label();
            this.reciptPriceOutput = new System.Windows.Forms.Label();
            this.tenderedReciptOutput = new System.Windows.Forms.Label();
            this.reciptItemBoughtLabel = new System.Windows.Forms.Label();
            this.itemBoughtOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deagleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tec9Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glockImage)).BeginInit();
            this.SuspendLayout();
            // 
            // shopBase
            // 
            this.shopBase.BackColor = System.Drawing.Color.Transparent;
            this.shopBase.Image = ((System.Drawing.Image)(resources.GetObject("shopBase.Image")));
            this.shopBase.Location = new System.Drawing.Point(24, 32);
            this.shopBase.Name = "shopBase";
            this.shopBase.Size = new System.Drawing.Size(392, 392);
            this.shopBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shopBase.TabIndex = 0;
            this.shopBase.TabStop = false;
            // 
            // pistolShopFunction
            // 
            this.pistolShopFunction.BackColor = System.Drawing.Color.Black;
            this.pistolShopFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pistolShopFunction.ForeColor = System.Drawing.Color.White;
            this.pistolShopFunction.Location = new System.Drawing.Point(280, 168);
            this.pistolShopFunction.Name = "pistolShopFunction";
            this.pistolShopFunction.Size = new System.Drawing.Size(105, 40);
            this.pistolShopFunction.TabIndex = 1;
            this.pistolShopFunction.Text = "Pistol";
            this.pistolShopFunction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pistolShopFunction.Click += new System.EventHandler(this.pistolShopFunction_Click);
            // 
            // gunDisplayLabel
            // 
            this.gunDisplayLabel.BackColor = System.Drawing.Color.DimGray;
            this.gunDisplayLabel.ForeColor = System.Drawing.Color.Gray;
            this.gunDisplayLabel.Location = new System.Drawing.Point(432, 24);
            this.gunDisplayLabel.Name = "gunDisplayLabel";
            this.gunDisplayLabel.Size = new System.Drawing.Size(244, 408);
            this.gunDisplayLabel.TabIndex = 2;
            this.gunDisplayLabel.Visible = false;
            // 
            // deagleImage
            // 
            this.deagleImage.BackColor = System.Drawing.Color.DimGray;
            this.deagleImage.Image = ((System.Drawing.Image)(resources.GetObject("deagleImage.Image")));
            this.deagleImage.Location = new System.Drawing.Point(568, 40);
            this.deagleImage.Name = "deagleImage";
            this.deagleImage.Size = new System.Drawing.Size(100, 50);
            this.deagleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deagleImage.TabIndex = 3;
            this.deagleImage.TabStop = false;
            this.deagleImage.Visible = false;
            this.deagleImage.Click += new System.EventHandler(this.deagleImage_Click);
            // 
            // deaglePriceLabel
            // 
            this.deaglePriceLabel.AutoSize = true;
            this.deaglePriceLabel.BackColor = System.Drawing.Color.DimGray;
            this.deaglePriceLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deaglePriceLabel.Location = new System.Drawing.Point(448, 40);
            this.deaglePriceLabel.Name = "deaglePriceLabel";
            this.deaglePriceLabel.Size = new System.Drawing.Size(102, 25);
            this.deaglePriceLabel.TabIndex = 4;
            this.deaglePriceLabel.Text = "Price: $700";
            this.deaglePriceLabel.Visible = false;
            // 
            // deagleFiringTypeLabel
            // 
            this.deagleFiringTypeLabel.AutoSize = true;
            this.deagleFiringTypeLabel.BackColor = System.Drawing.Color.DimGray;
            this.deagleFiringTypeLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deagleFiringTypeLabel.Location = new System.Drawing.Point(440, 72);
            this.deagleFiringTypeLabel.Name = "deagleFiringTypeLabel";
            this.deagleFiringTypeLabel.Size = new System.Drawing.Size(134, 25);
            this.deagleFiringTypeLabel.TabIndex = 5;
            this.deagleFiringTypeLabel.Text = "Semi Automatic";
            this.deagleFiringTypeLabel.Visible = false;
            // 
            // tec9FiringTypeLabel
            // 
            this.tec9FiringTypeLabel.AutoSize = true;
            this.tec9FiringTypeLabel.BackColor = System.Drawing.Color.DimGray;
            this.tec9FiringTypeLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tec9FiringTypeLabel.Location = new System.Drawing.Point(440, 152);
            this.tec9FiringTypeLabel.Name = "tec9FiringTypeLabel";
            this.tec9FiringTypeLabel.Size = new System.Drawing.Size(134, 25);
            this.tec9FiringTypeLabel.TabIndex = 8;
            this.tec9FiringTypeLabel.Text = "Semi Automatic";
            this.tec9FiringTypeLabel.Visible = false;
            // 
            // tec9PriceLabel
            // 
            this.tec9PriceLabel.AutoSize = true;
            this.tec9PriceLabel.BackColor = System.Drawing.Color.DimGray;
            this.tec9PriceLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tec9PriceLabel.Location = new System.Drawing.Point(448, 120);
            this.tec9PriceLabel.Name = "tec9PriceLabel";
            this.tec9PriceLabel.Size = new System.Drawing.Size(102, 25);
            this.tec9PriceLabel.TabIndex = 7;
            this.tec9PriceLabel.Text = "Price: $500";
            this.tec9PriceLabel.Visible = false;
            // 
            // tec9Image
            // 
            this.tec9Image.BackColor = System.Drawing.Color.DimGray;
            this.tec9Image.Image = ((System.Drawing.Image)(resources.GetObject("tec9Image.Image")));
            this.tec9Image.Location = new System.Drawing.Point(568, 120);
            this.tec9Image.Name = "tec9Image";
            this.tec9Image.Size = new System.Drawing.Size(100, 50);
            this.tec9Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tec9Image.TabIndex = 6;
            this.tec9Image.TabStop = false;
            this.tec9Image.Visible = false;
            // 
            // glockFiringTypeLabel
            // 
            this.glockFiringTypeLabel.AutoSize = true;
            this.glockFiringTypeLabel.BackColor = System.Drawing.Color.DimGray;
            this.glockFiringTypeLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glockFiringTypeLabel.Location = new System.Drawing.Point(440, 240);
            this.glockFiringTypeLabel.Name = "glockFiringTypeLabel";
            this.glockFiringTypeLabel.Size = new System.Drawing.Size(144, 50);
            this.glockFiringTypeLabel.TabIndex = 11;
            this.glockFiringTypeLabel.Text = "Semi Automatic /\r\n Burst Fire";
            this.glockFiringTypeLabel.Visible = false;
            // 
            // glockPriceLabel
            // 
            this.glockPriceLabel.AutoSize = true;
            this.glockPriceLabel.BackColor = System.Drawing.Color.DimGray;
            this.glockPriceLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glockPriceLabel.Location = new System.Drawing.Point(448, 208);
            this.glockPriceLabel.Name = "glockPriceLabel";
            this.glockPriceLabel.Size = new System.Drawing.Size(102, 25);
            this.glockPriceLabel.TabIndex = 10;
            this.glockPriceLabel.Text = "Price: $200";
            this.glockPriceLabel.Visible = false;
            // 
            // glockImage
            // 
            this.glockImage.BackColor = System.Drawing.Color.DimGray;
            this.glockImage.Image = ((System.Drawing.Image)(resources.GetObject("glockImage.Image")));
            this.glockImage.Location = new System.Drawing.Point(568, 208);
            this.glockImage.Name = "glockImage";
            this.glockImage.Size = new System.Drawing.Size(100, 50);
            this.glockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.glockImage.TabIndex = 9;
            this.glockImage.TabStop = false;
            this.glockImage.Visible = false;
            // 
            // reciptLabel
            // 
            this.reciptLabel.BackColor = System.Drawing.Color.White;
            this.reciptLabel.ForeColor = System.Drawing.Color.Gray;
            this.reciptLabel.Location = new System.Drawing.Point(696, 24);
            this.reciptLabel.Name = "reciptLabel";
            this.reciptLabel.Size = new System.Drawing.Size(244, 408);
            this.reciptLabel.TabIndex = 12;
            this.reciptLabel.Visible = false;
            // 
            // csgoReciptLabel
            // 
            this.csgoReciptLabel.AutoSize = true;
            this.csgoReciptLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csgoReciptLabel.Location = new System.Drawing.Point(720, 40);
            this.csgoReciptLabel.Name = "csgoReciptLabel";
            this.csgoReciptLabel.Size = new System.Drawing.Size(202, 20);
            this.csgoReciptLabel.TabIndex = 13;
            this.csgoReciptLabel.Text = "Counter Strike - Global Offence";
            // 
            // ReciptTextLabel
            // 
            this.ReciptTextLabel.AutoSize = true;
            this.ReciptTextLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReciptTextLabel.Location = new System.Drawing.Point(776, 72);
            this.ReciptTextLabel.Name = "ReciptTextLabel";
            this.ReciptTextLabel.Size = new System.Drawing.Size(98, 32);
            this.ReciptTextLabel.TabIndex = 14;
            this.ReciptTextLabel.Text = "Recipt";
            // 
            // lineText
            // 
            this.lineText.AutoSize = true;
            this.lineText.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineText.Location = new System.Drawing.Point(712, 104);
            this.lineText.Name = "lineText";
            this.lineText.Size = new System.Drawing.Size(224, 32);
            this.lineText.TabIndex = 15;
            this.lineText.Text = "______________";
            // 
            // tenderedTextBox
            // 
            this.tenderedTextBox.Location = new System.Drawing.Point(456, 360);
            this.tenderedTextBox.Name = "tenderedTextBox";
            this.tenderedTextBox.Size = new System.Drawing.Size(200, 20);
            this.tenderedTextBox.TabIndex = 16;
            this.tenderedTextBox.TextChanged += new System.EventHandler(this.tenderedTextBox_TextChanged);
            // 
            // tenderedCashTextLabel
            // 
            this.tenderedCashTextLabel.AutoSize = true;
            this.tenderedCashTextLabel.BackColor = System.Drawing.Color.DimGray;
            this.tenderedCashTextLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedCashTextLabel.Location = new System.Drawing.Point(448, 328);
            this.tenderedCashTextLabel.Name = "tenderedCashTextLabel";
            this.tenderedCashTextLabel.Size = new System.Drawing.Size(222, 24);
            this.tenderedCashTextLabel.TabIndex = 17;
            this.tenderedCashTextLabel.Text = "Enter Tendered Cash";
            // 
            // reciptPriceDisplay
            // 
            this.reciptPriceDisplay.AutoSize = true;
            this.reciptPriceDisplay.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptPriceDisplay.Location = new System.Drawing.Point(752, 184);
            this.reciptPriceDisplay.Name = "reciptPriceDisplay";
            this.reciptPriceDisplay.Size = new System.Drawing.Size(74, 24);
            this.reciptPriceDisplay.TabIndex = 18;
            this.reciptPriceDisplay.Text = "Price: ";
            // 
            // tenderedDisplayLabel
            // 
            this.tenderedDisplayLabel.AutoSize = true;
            this.tenderedDisplayLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedDisplayLabel.Location = new System.Drawing.Point(712, 224);
            this.tenderedDisplayLabel.Name = "tenderedDisplayLabel";
            this.tenderedDisplayLabel.Size = new System.Drawing.Size(111, 24);
            this.tenderedDisplayLabel.TabIndex = 19;
            this.tenderedDisplayLabel.Text = "Tendered:";
            // 
            // reciptPriceOutput
            // 
            this.reciptPriceOutput.AutoSize = true;
            this.reciptPriceOutput.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptPriceOutput.Location = new System.Drawing.Point(824, 184);
            this.reciptPriceOutput.Name = "reciptPriceOutput";
            this.reciptPriceOutput.Size = new System.Drawing.Size(34, 24);
            this.reciptPriceOutput.TabIndex = 20;
            this.reciptPriceOutput.Text = "Nil";
            // 
            // tenderedReciptOutput
            // 
            this.tenderedReciptOutput.AutoSize = true;
            this.tenderedReciptOutput.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedReciptOutput.Location = new System.Drawing.Point(824, 224);
            this.tenderedReciptOutput.Name = "tenderedReciptOutput";
            this.tenderedReciptOutput.Size = new System.Drawing.Size(34, 24);
            this.tenderedReciptOutput.TabIndex = 21;
            this.tenderedReciptOutput.Text = "Nil";
            // 
            // reciptItemBoughtLabel
            // 
            this.reciptItemBoughtLabel.AutoSize = true;
            this.reciptItemBoughtLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptItemBoughtLabel.Location = new System.Drawing.Point(760, 144);
            this.reciptItemBoughtLabel.Name = "reciptItemBoughtLabel";
            this.reciptItemBoughtLabel.Size = new System.Drawing.Size(60, 24);
            this.reciptItemBoughtLabel.TabIndex = 22;
            this.reciptItemBoughtLabel.Text = "Item:";
            // 
            // itemBoughtOutput
            // 
            this.itemBoughtOutput.AutoSize = true;
            this.itemBoughtOutput.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemBoughtOutput.Location = new System.Drawing.Point(824, 144);
            this.itemBoughtOutput.Name = "itemBoughtOutput";
            this.itemBoughtOutput.Size = new System.Drawing.Size(34, 24);
            this.itemBoughtOutput.TabIndex = 23;
            this.itemBoughtOutput.Text = "Nil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.itemBoughtOutput);
            this.Controls.Add(this.reciptItemBoughtLabel);
            this.Controls.Add(this.tenderedReciptOutput);
            this.Controls.Add(this.reciptPriceOutput);
            this.Controls.Add(this.tenderedDisplayLabel);
            this.Controls.Add(this.reciptPriceDisplay);
            this.Controls.Add(this.glockFiringTypeLabel);
            this.Controls.Add(this.glockImage);
            this.Controls.Add(this.tenderedCashTextLabel);
            this.Controls.Add(this.tenderedTextBox);
            this.Controls.Add(this.lineText);
            this.Controls.Add(this.ReciptTextLabel);
            this.Controls.Add(this.csgoReciptLabel);
            this.Controls.Add(this.tec9Image);
            this.Controls.Add(this.deagleImage);
            this.Controls.Add(this.reciptLabel);
            this.Controls.Add(this.glockPriceLabel);
            this.Controls.Add(this.tec9FiringTypeLabel);
            this.Controls.Add(this.tec9PriceLabel);
            this.Controls.Add(this.deagleFiringTypeLabel);
            this.Controls.Add(this.deaglePriceLabel);
            this.Controls.Add(this.pistolShopFunction);
            this.Controls.Add(this.shopBase);
            this.Controls.Add(this.gunDisplayLabel);
            this.Name = "Form1";
            this.Text = "Counter Strike - Global Offence";
            ((System.ComponentModel.ISupportInitialize)(this.shopBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deagleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tec9Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glockImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox shopBase;
        private System.Windows.Forms.Label pistolShopFunction;
        private System.Windows.Forms.Label gunDisplayLabel;
        private System.Windows.Forms.PictureBox deagleImage;
        private System.Windows.Forms.Label deaglePriceLabel;
        private System.Windows.Forms.Label deagleFiringTypeLabel;
        private System.Windows.Forms.Label tec9FiringTypeLabel;
        private System.Windows.Forms.Label tec9PriceLabel;
        private System.Windows.Forms.PictureBox tec9Image;
        private System.Windows.Forms.Label glockFiringTypeLabel;
        private System.Windows.Forms.Label glockPriceLabel;
        private System.Windows.Forms.PictureBox glockImage;
        private System.Windows.Forms.Label reciptLabel;
        private System.Windows.Forms.Label csgoReciptLabel;
        private System.Windows.Forms.Label ReciptTextLabel;
        private System.Windows.Forms.Label lineText;
        private System.Windows.Forms.TextBox tenderedTextBox;
        private System.Windows.Forms.Label tenderedCashTextLabel;
        private System.Windows.Forms.Label reciptPriceDisplay;
        private System.Windows.Forms.Label tenderedDisplayLabel;
        private System.Windows.Forms.Label reciptPriceOutput;
        private System.Windows.Forms.Label tenderedReciptOutput;
        private System.Windows.Forms.Label reciptItemBoughtLabel;
        private System.Windows.Forms.Label itemBoughtOutput;
    }
}

