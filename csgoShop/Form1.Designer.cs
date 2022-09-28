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
            this.reciptTextLabel = new System.Windows.Forms.Label();
            this.tenderedTextBox = new System.Windows.Forms.TextBox();
            this.tenderedCashTextLabel = new System.Windows.Forms.Label();
            this.reciptPriceDisplay = new System.Windows.Forms.Label();
            this.tenderedDisplayLabel = new System.Windows.Forms.Label();
            this.reciptPriceOutput = new System.Windows.Forms.Label();
            this.tenderedReciptOutput = new System.Windows.Forms.Label();
            this.reciptItemBoughtLabel = new System.Windows.Forms.Label();
            this.itemBoughtOutput = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxAmountLabel = new System.Windows.Forms.Label();
            this.taxAmountOutput = new System.Windows.Forms.Label();
            this.totalTextLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.returnedAmountLabel = new System.Windows.Forms.Label();
            this.returnedAmountOutput = new System.Windows.Forms.Label();
            this.calculatePurchaseButtton = new System.Windows.Forms.Button();
            this.lineLabel1 = new System.Windows.Forms.Label();
            this.lineLabel2 = new System.Windows.Forms.Label();
            this.selectAnOptionLabel = new System.Windows.Forms.Label();
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
            this.shopBase.Location = new System.Drawing.Point(32, 39);
            this.shopBase.Margin = new System.Windows.Forms.Padding(4);
            this.shopBase.Name = "shopBase";
            this.shopBase.Size = new System.Drawing.Size(523, 482);
            this.shopBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shopBase.TabIndex = 0;
            this.shopBase.TabStop = false;
            // 
            // pistolShopFunction
            // 
            this.pistolShopFunction.BackColor = System.Drawing.Color.Black;
            this.pistolShopFunction.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pistolShopFunction.ForeColor = System.Drawing.Color.LightGray;
            this.pistolShopFunction.Location = new System.Drawing.Point(180, 108);
            this.pistolShopFunction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pistolShopFunction.Name = "pistolShopFunction";
            this.pistolShopFunction.Size = new System.Drawing.Size(105, 49);
            this.pistolShopFunction.TabIndex = 1;
            this.pistolShopFunction.Text = "Pistols";
            this.pistolShopFunction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pistolShopFunction.Click += new System.EventHandler(this.pistolShopFunction_Click);
            // 
            // gunDisplayLabel
            // 
            this.gunDisplayLabel.BackColor = System.Drawing.Color.DimGray;
            this.gunDisplayLabel.ForeColor = System.Drawing.Color.Gray;
            this.gunDisplayLabel.Location = new System.Drawing.Point(576, 30);
            this.gunDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunDisplayLabel.Name = "gunDisplayLabel";
            this.gunDisplayLabel.Size = new System.Drawing.Size(325, 502);
            this.gunDisplayLabel.TabIndex = 2;
            this.gunDisplayLabel.Visible = false;
            // 
            // deagleImage
            // 
            this.deagleImage.BackColor = System.Drawing.Color.DimGray;
            this.deagleImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deagleImage.Image = ((System.Drawing.Image)(resources.GetObject("deagleImage.Image")));
            this.deagleImage.Location = new System.Drawing.Point(756, 83);
            this.deagleImage.Margin = new System.Windows.Forms.Padding(4);
            this.deagleImage.Name = "deagleImage";
            this.deagleImage.Size = new System.Drawing.Size(133, 62);
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
            this.deaglePriceLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deaglePriceLabel.Location = new System.Drawing.Point(597, 76);
            this.deaglePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deaglePriceLabel.Name = "deaglePriceLabel";
            this.deaglePriceLabel.Size = new System.Drawing.Size(122, 30);
            this.deaglePriceLabel.TabIndex = 4;
            this.deaglePriceLabel.Text = "Price: $700";
            this.deaglePriceLabel.Visible = false;
            // 
            // deagleFiringTypeLabel
            // 
            this.deagleFiringTypeLabel.AutoSize = true;
            this.deagleFiringTypeLabel.BackColor = System.Drawing.Color.DimGray;
            this.deagleFiringTypeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deagleFiringTypeLabel.Location = new System.Drawing.Point(587, 116);
            this.deagleFiringTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deagleFiringTypeLabel.Name = "deagleFiringTypeLabel";
            this.deagleFiringTypeLabel.Size = new System.Drawing.Size(175, 30);
            this.deagleFiringTypeLabel.TabIndex = 5;
            this.deagleFiringTypeLabel.Text = "Semi Automatic";
            this.deagleFiringTypeLabel.Visible = false;
            // 
            // tec9FiringTypeLabel
            // 
            this.tec9FiringTypeLabel.AutoSize = true;
            this.tec9FiringTypeLabel.BackColor = System.Drawing.Color.DimGray;
            this.tec9FiringTypeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tec9FiringTypeLabel.Location = new System.Drawing.Point(586, 221);
            this.tec9FiringTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tec9FiringTypeLabel.Name = "tec9FiringTypeLabel";
            this.tec9FiringTypeLabel.Size = new System.Drawing.Size(175, 30);
            this.tec9FiringTypeLabel.TabIndex = 8;
            this.tec9FiringTypeLabel.Text = "Semi Automatic";
            this.tec9FiringTypeLabel.Visible = false;
            // 
            // tec9PriceLabel
            // 
            this.tec9PriceLabel.AutoSize = true;
            this.tec9PriceLabel.BackColor = System.Drawing.Color.DimGray;
            this.tec9PriceLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tec9PriceLabel.Location = new System.Drawing.Point(596, 182);
            this.tec9PriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tec9PriceLabel.Name = "tec9PriceLabel";
            this.tec9PriceLabel.Size = new System.Drawing.Size(122, 30);
            this.tec9PriceLabel.TabIndex = 7;
            this.tec9PriceLabel.Text = "Price: $500";
            this.tec9PriceLabel.Visible = false;
            // 
            // tec9Image
            // 
            this.tec9Image.BackColor = System.Drawing.Color.DimGray;
            this.tec9Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tec9Image.Image = ((System.Drawing.Image)(resources.GetObject("tec9Image.Image")));
            this.tec9Image.Location = new System.Drawing.Point(756, 182);
            this.tec9Image.Margin = new System.Windows.Forms.Padding(4);
            this.tec9Image.Name = "tec9Image";
            this.tec9Image.Size = new System.Drawing.Size(133, 62);
            this.tec9Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tec9Image.TabIndex = 6;
            this.tec9Image.TabStop = false;
            this.tec9Image.Visible = false;
            // 
            // glockFiringTypeLabel
            // 
            this.glockFiringTypeLabel.AutoSize = true;
            this.glockFiringTypeLabel.BackColor = System.Drawing.Color.DimGray;
            this.glockFiringTypeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glockFiringTypeLabel.Location = new System.Drawing.Point(586, 329);
            this.glockFiringTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.glockFiringTypeLabel.Name = "glockFiringTypeLabel";
            this.glockFiringTypeLabel.Size = new System.Drawing.Size(181, 60);
            this.glockFiringTypeLabel.TabIndex = 11;
            this.glockFiringTypeLabel.Text = "Semi Automatic \r\n/ Burst Fire";
            this.glockFiringTypeLabel.Visible = false;
            // 
            // glockPriceLabel
            // 
            this.glockPriceLabel.AutoSize = true;
            this.glockPriceLabel.BackColor = System.Drawing.Color.DimGray;
            this.glockPriceLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glockPriceLabel.Location = new System.Drawing.Point(596, 290);
            this.glockPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.glockPriceLabel.Name = "glockPriceLabel";
            this.glockPriceLabel.Size = new System.Drawing.Size(122, 30);
            this.glockPriceLabel.TabIndex = 10;
            this.glockPriceLabel.Text = "Price: $200";
            this.glockPriceLabel.Visible = false;
            // 
            // glockImage
            // 
            this.glockImage.BackColor = System.Drawing.Color.DimGray;
            this.glockImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.glockImage.Image = ((System.Drawing.Image)(resources.GetObject("glockImage.Image")));
            this.glockImage.Location = new System.Drawing.Point(756, 290);
            this.glockImage.Margin = new System.Windows.Forms.Padding(4);
            this.glockImage.Name = "glockImage";
            this.glockImage.Size = new System.Drawing.Size(133, 62);
            this.glockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.glockImage.TabIndex = 9;
            this.glockImage.TabStop = false;
            this.glockImage.Visible = false;
            // 
            // reciptLabel
            // 
            this.reciptLabel.BackColor = System.Drawing.Color.White;
            this.reciptLabel.ForeColor = System.Drawing.Color.Gray;
            this.reciptLabel.Location = new System.Drawing.Point(928, 30);
            this.reciptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reciptLabel.Name = "reciptLabel";
            this.reciptLabel.Size = new System.Drawing.Size(325, 502);
            this.reciptLabel.TabIndex = 12;
            this.reciptLabel.Visible = false;
            // 
            // csgoReciptLabel
            // 
            this.csgoReciptLabel.AutoSize = true;
            this.csgoReciptLabel.BackColor = System.Drawing.Color.White;
            this.csgoReciptLabel.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csgoReciptLabel.Location = new System.Drawing.Point(987, 39);
            this.csgoReciptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.csgoReciptLabel.Name = "csgoReciptLabel";
            this.csgoReciptLabel.Size = new System.Drawing.Size(190, 48);
            this.csgoReciptLabel.TabIndex = 13;
            this.csgoReciptLabel.Text = "Counter Strike \r\nGlobal Offence";
            this.csgoReciptLabel.Visible = false;
            // 
            // reciptTextLabel
            // 
            this.reciptTextLabel.AutoSize = true;
            this.reciptTextLabel.BackColor = System.Drawing.Color.White;
            this.reciptTextLabel.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptTextLabel.Location = new System.Drawing.Point(1044, 97);
            this.reciptTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reciptTextLabel.Name = "reciptTextLabel";
            this.reciptTextLabel.Size = new System.Drawing.Size(82, 24);
            this.reciptTextLabel.TabIndex = 14;
            this.reciptTextLabel.Text = "Recipt";
            this.reciptTextLabel.Visible = false;
            // 
            // tenderedTextBox
            // 
            this.tenderedTextBox.Location = new System.Drawing.Point(608, 443);
            this.tenderedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tenderedTextBox.Name = "tenderedTextBox";
            this.tenderedTextBox.Size = new System.Drawing.Size(265, 22);
            this.tenderedTextBox.TabIndex = 16;
            this.tenderedTextBox.Visible = false;
            this.tenderedTextBox.TextChanged += new System.EventHandler(this.tenderedTextBox_TextChanged);
            // 
            // tenderedCashTextLabel
            // 
            this.tenderedCashTextLabel.AutoSize = true;
            this.tenderedCashTextLabel.BackColor = System.Drawing.Color.DimGray;
            this.tenderedCashTextLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedCashTextLabel.Location = new System.Drawing.Point(597, 404);
            this.tenderedCashTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tenderedCashTextLabel.Name = "tenderedCashTextLabel";
            this.tenderedCashTextLabel.Size = new System.Drawing.Size(290, 32);
            this.tenderedCashTextLabel.TabIndex = 17;
            this.tenderedCashTextLabel.Text = "Enter Tendered Cash";
            this.tenderedCashTextLabel.Visible = false;
            // 
            // reciptPriceDisplay
            // 
            this.reciptPriceDisplay.AutoSize = true;
            this.reciptPriceDisplay.BackColor = System.Drawing.Color.White;
            this.reciptPriceDisplay.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptPriceDisplay.Location = new System.Drawing.Point(1003, 198);
            this.reciptPriceDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reciptPriceDisplay.Name = "reciptPriceDisplay";
            this.reciptPriceDisplay.Size = new System.Drawing.Size(94, 24);
            this.reciptPriceDisplay.TabIndex = 18;
            this.reciptPriceDisplay.Text = "Price: ";
            this.reciptPriceDisplay.Visible = false;
            // 
            // tenderedDisplayLabel
            // 
            this.tenderedDisplayLabel.AutoSize = true;
            this.tenderedDisplayLabel.BackColor = System.Drawing.Color.White;
            this.tenderedDisplayLabel.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedDisplayLabel.Location = new System.Drawing.Point(965, 248);
            this.tenderedDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tenderedDisplayLabel.Name = "tenderedDisplayLabel";
            this.tenderedDisplayLabel.Size = new System.Drawing.Size(118, 24);
            this.tenderedDisplayLabel.TabIndex = 19;
            this.tenderedDisplayLabel.Text = "Tendered:";
            this.tenderedDisplayLabel.Visible = false;
            // 
            // reciptPriceOutput
            // 
            this.reciptPriceOutput.AutoSize = true;
            this.reciptPriceOutput.BackColor = System.Drawing.Color.White;
            this.reciptPriceOutput.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptPriceOutput.Location = new System.Drawing.Point(1099, 198);
            this.reciptPriceOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reciptPriceOutput.Name = "reciptPriceOutput";
            this.reciptPriceOutput.Size = new System.Drawing.Size(46, 24);
            this.reciptPriceOutput.TabIndex = 20;
            this.reciptPriceOutput.Text = "Nil";
            this.reciptPriceOutput.Visible = false;
            // 
            // tenderedReciptOutput
            // 
            this.tenderedReciptOutput.AutoSize = true;
            this.tenderedReciptOutput.BackColor = System.Drawing.Color.White;
            this.tenderedReciptOutput.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedReciptOutput.Location = new System.Drawing.Point(1099, 248);
            this.tenderedReciptOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tenderedReciptOutput.Name = "tenderedReciptOutput";
            this.tenderedReciptOutput.Size = new System.Drawing.Size(46, 24);
            this.tenderedReciptOutput.TabIndex = 21;
            this.tenderedReciptOutput.Text = "Nil";
            this.tenderedReciptOutput.Visible = false;
            // 
            // reciptItemBoughtLabel
            // 
            this.reciptItemBoughtLabel.AutoSize = true;
            this.reciptItemBoughtLabel.BackColor = System.Drawing.Color.White;
            this.reciptItemBoughtLabel.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptItemBoughtLabel.Location = new System.Drawing.Point(1013, 149);
            this.reciptItemBoughtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reciptItemBoughtLabel.Name = "reciptItemBoughtLabel";
            this.reciptItemBoughtLabel.Size = new System.Drawing.Size(70, 24);
            this.reciptItemBoughtLabel.TabIndex = 22;
            this.reciptItemBoughtLabel.Text = "Item:";
            this.reciptItemBoughtLabel.Visible = false;
            // 
            // itemBoughtOutput
            // 
            this.itemBoughtOutput.AutoSize = true;
            this.itemBoughtOutput.BackColor = System.Drawing.Color.White;
            this.itemBoughtOutput.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemBoughtOutput.Location = new System.Drawing.Point(1099, 149);
            this.itemBoughtOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemBoughtOutput.Name = "itemBoughtOutput";
            this.itemBoughtOutput.Size = new System.Drawing.Size(46, 24);
            this.itemBoughtOutput.TabIndex = 23;
            this.itemBoughtOutput.Text = "Nil";
            this.itemBoughtOutput.Visible = false;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.BackColor = System.Drawing.Color.White;
            this.subTotalLabel.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(962, 313);
            this.subTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(118, 24);
            this.subTotalLabel.TabIndex = 25;
            this.subTotalLabel.Text = "Subtotal:";
            this.subTotalLabel.Visible = false;
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.AutoSize = true;
            this.subTotalOutput.BackColor = System.Drawing.Color.White;
            this.subTotalOutput.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutput.Location = new System.Drawing.Point(1099, 313);
            this.subTotalOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(46, 24);
            this.subTotalOutput.TabIndex = 26;
            this.subTotalOutput.Text = "Nil";
            this.subTotalOutput.Visible = false;
            // 
            // taxAmountLabel
            // 
            this.taxAmountLabel.AutoSize = true;
            this.taxAmountLabel.BackColor = System.Drawing.Color.White;
            this.taxAmountLabel.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxAmountLabel.Location = new System.Drawing.Point(1025, 358);
            this.taxAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxAmountLabel.Name = "taxAmountLabel";
            this.taxAmountLabel.Size = new System.Drawing.Size(58, 24);
            this.taxAmountLabel.TabIndex = 27;
            this.taxAmountLabel.Text = "Tax:";
            this.taxAmountLabel.Visible = false;
            // 
            // taxAmountOutput
            // 
            this.taxAmountOutput.AutoSize = true;
            this.taxAmountOutput.BackColor = System.Drawing.Color.White;
            this.taxAmountOutput.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxAmountOutput.Location = new System.Drawing.Point(1099, 358);
            this.taxAmountOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxAmountOutput.Name = "taxAmountOutput";
            this.taxAmountOutput.Size = new System.Drawing.Size(46, 24);
            this.taxAmountOutput.TabIndex = 28;
            this.taxAmountOutput.Text = "Nil";
            this.taxAmountOutput.Visible = false;
            // 
            // totalTextLabel
            // 
            this.totalTextLabel.AutoSize = true;
            this.totalTextLabel.BackColor = System.Drawing.Color.White;
            this.totalTextLabel.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextLabel.Location = new System.Drawing.Point(1001, 404);
            this.totalTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalTextLabel.Name = "totalTextLabel";
            this.totalTextLabel.Size = new System.Drawing.Size(82, 24);
            this.totalTextLabel.TabIndex = 29;
            this.totalTextLabel.Text = "Total:";
            this.totalTextLabel.Visible = false;
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.BackColor = System.Drawing.Color.White;
            this.totalOutput.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(1099, 404);
            this.totalOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(46, 24);
            this.totalOutput.TabIndex = 30;
            this.totalOutput.Text = "Nil";
            this.totalOutput.Visible = false;
            // 
            // returnedAmountLabel
            // 
            this.returnedAmountLabel.AutoSize = true;
            this.returnedAmountLabel.BackColor = System.Drawing.Color.White;
            this.returnedAmountLabel.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnedAmountLabel.Location = new System.Drawing.Point(965, 452);
            this.returnedAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.returnedAmountLabel.Name = "returnedAmountLabel";
            this.returnedAmountLabel.Size = new System.Drawing.Size(118, 24);
            this.returnedAmountLabel.TabIndex = 31;
            this.returnedAmountLabel.Text = "Returned:";
            this.returnedAmountLabel.Visible = false;
            // 
            // returnedAmountOutput
            // 
            this.returnedAmountOutput.AutoSize = true;
            this.returnedAmountOutput.BackColor = System.Drawing.Color.White;
            this.returnedAmountOutput.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnedAmountOutput.Location = new System.Drawing.Point(1099, 452);
            this.returnedAmountOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.returnedAmountOutput.Name = "returnedAmountOutput";
            this.returnedAmountOutput.Size = new System.Drawing.Size(46, 24);
            this.returnedAmountOutput.TabIndex = 32;
            this.returnedAmountOutput.Text = "Nil";
            this.returnedAmountOutput.Visible = false;
            // 
            // calculatePurchaseButtton
            // 
            this.calculatePurchaseButtton.AutoSize = true;
            this.calculatePurchaseButtton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatePurchaseButtton.Location = new System.Drawing.Point(608, 484);
            this.calculatePurchaseButtton.Name = "calculatePurchaseButtton";
            this.calculatePurchaseButtton.Size = new System.Drawing.Size(265, 37);
            this.calculatePurchaseButtton.TabIndex = 33;
            this.calculatePurchaseButtton.Text = "Purchase";
            this.calculatePurchaseButtton.UseMnemonic = false;
            this.calculatePurchaseButtton.UseVisualStyleBackColor = true;
            this.calculatePurchaseButtton.Visible = false;
            this.calculatePurchaseButtton.Click += new System.EventHandler(this.calculatePurchaseButtton_Click);
            // 
            // lineLabel1
            // 
            this.lineLabel1.BackColor = System.Drawing.Color.Black;
            this.lineLabel1.Location = new System.Drawing.Point(946, 132);
            this.lineLabel1.Name = "lineLabel1";
            this.lineLabel1.Size = new System.Drawing.Size(286, 10);
            this.lineLabel1.TabIndex = 34;
            this.lineLabel1.Visible = false;
            // 
            // lineLabel2
            // 
            this.lineLabel2.BackColor = System.Drawing.Color.Black;
            this.lineLabel2.Location = new System.Drawing.Point(946, 277);
            this.lineLabel2.Name = "lineLabel2";
            this.lineLabel2.Size = new System.Drawing.Size(286, 10);
            this.lineLabel2.TabIndex = 35;
            this.lineLabel2.Visible = false;
            // 
            // selectAnOptionLabel
            // 
            this.selectAnOptionLabel.AutoSize = true;
            this.selectAnOptionLabel.BackColor = System.Drawing.Color.DimGray;
            this.selectAnOptionLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAnOptionLabel.Location = new System.Drawing.Point(622, 39);
            this.selectAnOptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectAnOptionLabel.Name = "selectAnOptionLabel";
            this.selectAnOptionLabel.Size = new System.Drawing.Size(231, 32);
            this.selectAnOptionLabel.TabIndex = 36;
            this.selectAnOptionLabel.Text = "Select an Option";
            this.selectAnOptionLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1269, 554);
            this.Controls.Add(this.glockImage);
            this.Controls.Add(this.tec9Image);
            this.Controls.Add(this.deagleImage);
            this.Controls.Add(this.selectAnOptionLabel);
            this.Controls.Add(this.lineLabel2);
            this.Controls.Add(this.lineLabel1);
            this.Controls.Add(this.calculatePurchaseButtton);
            this.Controls.Add(this.returnedAmountOutput);
            this.Controls.Add(this.returnedAmountLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.totalTextLabel);
            this.Controls.Add(this.taxAmountOutput);
            this.Controls.Add(this.tenderedReciptOutput);
            this.Controls.Add(this.tenderedDisplayLabel);
            this.Controls.Add(this.reciptTextLabel);
            this.Controls.Add(this.taxAmountLabel);
            this.Controls.Add(this.tec9FiringTypeLabel);
            this.Controls.Add(this.deagleFiringTypeLabel);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.itemBoughtOutput);
            this.Controls.Add(this.reciptItemBoughtLabel);
            this.Controls.Add(this.reciptPriceOutput);
            this.Controls.Add(this.reciptPriceDisplay);
            this.Controls.Add(this.glockFiringTypeLabel);
            this.Controls.Add(this.tenderedCashTextLabel);
            this.Controls.Add(this.tenderedTextBox);
            this.Controls.Add(this.csgoReciptLabel);
            this.Controls.Add(this.glockPriceLabel);
            this.Controls.Add(this.tec9PriceLabel);
            this.Controls.Add(this.deaglePriceLabel);
            this.Controls.Add(this.pistolShopFunction);
            this.Controls.Add(this.shopBase);
            this.Controls.Add(this.gunDisplayLabel);
            this.Controls.Add(this.reciptLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label reciptTextLabel;
        private System.Windows.Forms.TextBox tenderedTextBox;
        private System.Windows.Forms.Label tenderedCashTextLabel;
        private System.Windows.Forms.Label reciptPriceDisplay;
        private System.Windows.Forms.Label tenderedDisplayLabel;
        private System.Windows.Forms.Label reciptPriceOutput;
        private System.Windows.Forms.Label tenderedReciptOutput;
        private System.Windows.Forms.Label reciptItemBoughtLabel;
        private System.Windows.Forms.Label itemBoughtOutput;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxAmountLabel;
        private System.Windows.Forms.Label taxAmountOutput;
        private System.Windows.Forms.Label totalTextLabel;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label returnedAmountLabel;
        private System.Windows.Forms.Label returnedAmountOutput;
        private System.Windows.Forms.Button calculatePurchaseButtton;
        private System.Windows.Forms.Label lineLabel1;
        private System.Windows.Forms.Label lineLabel2;
        private System.Windows.Forms.Label selectAnOptionLabel;
    }
}

