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
            this.newOrderButton = new System.Windows.Forms.Button();
            this.totalCostDisplay = new System.Windows.Forms.Label();
            this.walletLabel = new System.Windows.Forms.Label();
            this.moneyCounter = new System.Windows.Forms.Label();
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
            this.pistolShopFunction.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pistolShopFunction.ForeColor = System.Drawing.Color.LightGray;
            this.pistolShopFunction.Location = new System.Drawing.Point(135, 88);
            this.pistolShopFunction.Name = "pistolShopFunction";
            this.pistolShopFunction.Size = new System.Drawing.Size(79, 40);
            this.pistolShopFunction.TabIndex = 1;
            this.pistolShopFunction.Text = "Pistols";
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
            this.deagleImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deagleImage.Image = ((System.Drawing.Image)(resources.GetObject("deagleImage.Image")));
            this.deagleImage.Location = new System.Drawing.Point(567, 67);
            this.deagleImage.Name = "deagleImage";
            this.deagleImage.Size = new System.Drawing.Size(100, 51);
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
            this.deaglePriceLabel.Location = new System.Drawing.Point(448, 62);
            this.deaglePriceLabel.Name = "deaglePriceLabel";
            this.deaglePriceLabel.Size = new System.Drawing.Size(101, 23);
            this.deaglePriceLabel.TabIndex = 4;
            this.deaglePriceLabel.Text = "Price: $700";
            this.deaglePriceLabel.Visible = false;
            // 
            // deagleFiringTypeLabel
            // 
            this.deagleFiringTypeLabel.AutoSize = true;
            this.deagleFiringTypeLabel.BackColor = System.Drawing.Color.DimGray;
            this.deagleFiringTypeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deagleFiringTypeLabel.Location = new System.Drawing.Point(464, 88);
            this.deagleFiringTypeLabel.Name = "deagleFiringTypeLabel";
            this.deagleFiringTypeLabel.Size = new System.Drawing.Size(69, 23);
            this.deagleFiringTypeLabel.TabIndex = 5;
            this.deagleFiringTypeLabel.Text = "Deagle";
            this.deagleFiringTypeLabel.Visible = false;
            // 
            // tec9FiringTypeLabel
            // 
            this.tec9FiringTypeLabel.AutoSize = true;
            this.tec9FiringTypeLabel.BackColor = System.Drawing.Color.DimGray;
            this.tec9FiringTypeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tec9FiringTypeLabel.Location = new System.Drawing.Point(472, 176);
            this.tec9FiringTypeLabel.Name = "tec9FiringTypeLabel";
            this.tec9FiringTypeLabel.Size = new System.Drawing.Size(49, 23);
            this.tec9FiringTypeLabel.TabIndex = 8;
            this.tec9FiringTypeLabel.Text = "Tec9";
            this.tec9FiringTypeLabel.Visible = false;
            // 
            // tec9PriceLabel
            // 
            this.tec9PriceLabel.AutoSize = true;
            this.tec9PriceLabel.BackColor = System.Drawing.Color.DimGray;
            this.tec9PriceLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tec9PriceLabel.Location = new System.Drawing.Point(447, 148);
            this.tec9PriceLabel.Name = "tec9PriceLabel";
            this.tec9PriceLabel.Size = new System.Drawing.Size(101, 23);
            this.tec9PriceLabel.TabIndex = 7;
            this.tec9PriceLabel.Text = "Price: $500";
            this.tec9PriceLabel.Visible = false;
            // 
            // tec9Image
            // 
            this.tec9Image.BackColor = System.Drawing.Color.DimGray;
            this.tec9Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tec9Image.Image = ((System.Drawing.Image)(resources.GetObject("tec9Image.Image")));
            this.tec9Image.Location = new System.Drawing.Point(567, 148);
            this.tec9Image.Name = "tec9Image";
            this.tec9Image.Size = new System.Drawing.Size(100, 51);
            this.tec9Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tec9Image.TabIndex = 6;
            this.tec9Image.TabStop = false;
            this.tec9Image.Visible = false;
            this.tec9Image.Click += new System.EventHandler(this.tec9Image_Click_1);
            // 
            // glockFiringTypeLabel
            // 
            this.glockFiringTypeLabel.AutoSize = true;
            this.glockFiringTypeLabel.BackColor = System.Drawing.Color.DimGray;
            this.glockFiringTypeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glockFiringTypeLabel.Location = new System.Drawing.Point(472, 264);
            this.glockFiringTypeLabel.Name = "glockFiringTypeLabel";
            this.glockFiringTypeLabel.Size = new System.Drawing.Size(57, 23);
            this.glockFiringTypeLabel.TabIndex = 11;
            this.glockFiringTypeLabel.Text = "Glock";
            this.glockFiringTypeLabel.Visible = false;
            // 
            // glockPriceLabel
            // 
            this.glockPriceLabel.AutoSize = true;
            this.glockPriceLabel.BackColor = System.Drawing.Color.DimGray;
            this.glockPriceLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glockPriceLabel.Location = new System.Drawing.Point(447, 236);
            this.glockPriceLabel.Name = "glockPriceLabel";
            this.glockPriceLabel.Size = new System.Drawing.Size(101, 23);
            this.glockPriceLabel.TabIndex = 10;
            this.glockPriceLabel.Text = "Price: $200";
            this.glockPriceLabel.Visible = false;
            // 
            // glockImage
            // 
            this.glockImage.BackColor = System.Drawing.Color.DimGray;
            this.glockImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.glockImage.Image = ((System.Drawing.Image)(resources.GetObject("glockImage.Image")));
            this.glockImage.Location = new System.Drawing.Point(567, 236);
            this.glockImage.Name = "glockImage";
            this.glockImage.Size = new System.Drawing.Size(100, 51);
            this.glockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.glockImage.TabIndex = 9;
            this.glockImage.TabStop = false;
            this.glockImage.Visible = false;
            this.glockImage.Click += new System.EventHandler(this.glockImage_Click);
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
            this.csgoReciptLabel.BackColor = System.Drawing.Color.White;
            this.csgoReciptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csgoReciptLabel.Location = new System.Drawing.Point(740, 32);
            this.csgoReciptLabel.Name = "csgoReciptLabel";
            this.csgoReciptLabel.Size = new System.Drawing.Size(116, 40);
            this.csgoReciptLabel.TabIndex = 13;
            this.csgoReciptLabel.Text = "Counter Strike \r\nGlobal Offence";
            this.csgoReciptLabel.Visible = false;
            // 
            // reciptTextLabel
            // 
            this.reciptTextLabel.AutoSize = true;
            this.reciptTextLabel.BackColor = System.Drawing.Color.White;
            this.reciptTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptTextLabel.Location = new System.Drawing.Point(783, 79);
            this.reciptTextLabel.Name = "reciptTextLabel";
            this.reciptTextLabel.Size = new System.Drawing.Size(55, 20);
            this.reciptTextLabel.TabIndex = 14;
            this.reciptTextLabel.Text = "Recipt";
            this.reciptTextLabel.Visible = false;
            // 
            // tenderedTextBox
            // 
            this.tenderedTextBox.Location = new System.Drawing.Point(456, 360);
            this.tenderedTextBox.Name = "tenderedTextBox";
            this.tenderedTextBox.Size = new System.Drawing.Size(200, 20);
            this.tenderedTextBox.TabIndex = 16;
            this.tenderedTextBox.Visible = false;
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
            this.tenderedCashTextLabel.Visible = false;
            // 
            // reciptPriceDisplay
            // 
            this.reciptPriceDisplay.AutoSize = true;
            this.reciptPriceDisplay.BackColor = System.Drawing.Color.White;
            this.reciptPriceDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptPriceDisplay.Location = new System.Drawing.Point(752, 161);
            this.reciptPriceDisplay.Name = "reciptPriceDisplay";
            this.reciptPriceDisplay.Size = new System.Drawing.Size(52, 20);
            this.reciptPriceDisplay.TabIndex = 18;
            this.reciptPriceDisplay.Text = "Price: ";
            this.reciptPriceDisplay.Visible = false;
            // 
            // tenderedDisplayLabel
            // 
            this.tenderedDisplayLabel.AutoSize = true;
            this.tenderedDisplayLabel.BackColor = System.Drawing.Color.White;
            this.tenderedDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedDisplayLabel.Location = new System.Drawing.Point(724, 202);
            this.tenderedDisplayLabel.Name = "tenderedDisplayLabel";
            this.tenderedDisplayLabel.Size = new System.Drawing.Size(81, 20);
            this.tenderedDisplayLabel.TabIndex = 19;
            this.tenderedDisplayLabel.Text = "Tendered:";
            this.tenderedDisplayLabel.Visible = false;
            // 
            // reciptPriceOutput
            // 
            this.reciptPriceOutput.AutoSize = true;
            this.reciptPriceOutput.BackColor = System.Drawing.Color.White;
            this.reciptPriceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptPriceOutput.Location = new System.Drawing.Point(824, 161);
            this.reciptPriceOutput.Name = "reciptPriceOutput";
            this.reciptPriceOutput.Size = new System.Drawing.Size(26, 20);
            this.reciptPriceOutput.TabIndex = 20;
            this.reciptPriceOutput.Text = "Nil";
            this.reciptPriceOutput.Visible = false;
            // 
            // tenderedReciptOutput
            // 
            this.tenderedReciptOutput.AutoSize = true;
            this.tenderedReciptOutput.BackColor = System.Drawing.Color.White;
            this.tenderedReciptOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedReciptOutput.Location = new System.Drawing.Point(824, 202);
            this.tenderedReciptOutput.Name = "tenderedReciptOutput";
            this.tenderedReciptOutput.Size = new System.Drawing.Size(26, 20);
            this.tenderedReciptOutput.TabIndex = 21;
            this.tenderedReciptOutput.Text = "Nil";
            this.tenderedReciptOutput.Visible = false;
            // 
            // reciptItemBoughtLabel
            // 
            this.reciptItemBoughtLabel.AutoSize = true;
            this.reciptItemBoughtLabel.BackColor = System.Drawing.Color.White;
            this.reciptItemBoughtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptItemBoughtLabel.Location = new System.Drawing.Point(760, 121);
            this.reciptItemBoughtLabel.Name = "reciptItemBoughtLabel";
            this.reciptItemBoughtLabel.Size = new System.Drawing.Size(45, 20);
            this.reciptItemBoughtLabel.TabIndex = 22;
            this.reciptItemBoughtLabel.Text = "Item:";
            this.reciptItemBoughtLabel.Visible = false;
            // 
            // itemBoughtOutput
            // 
            this.itemBoughtOutput.AutoSize = true;
            this.itemBoughtOutput.BackColor = System.Drawing.Color.White;
            this.itemBoughtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemBoughtOutput.Location = new System.Drawing.Point(824, 121);
            this.itemBoughtOutput.Name = "itemBoughtOutput";
            this.itemBoughtOutput.Size = new System.Drawing.Size(26, 20);
            this.itemBoughtOutput.TabIndex = 23;
            this.itemBoughtOutput.Text = "Nil";
            this.itemBoughtOutput.Visible = false;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.BackColor = System.Drawing.Color.White;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(722, 254);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(73, 20);
            this.subTotalLabel.TabIndex = 25;
            this.subTotalLabel.Text = "Subtotal:";
            this.subTotalLabel.Visible = false;
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.AutoSize = true;
            this.subTotalOutput.BackColor = System.Drawing.Color.White;
            this.subTotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutput.Location = new System.Drawing.Point(824, 254);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(26, 20);
            this.subTotalOutput.TabIndex = 26;
            this.subTotalOutput.Text = "Nil";
            this.subTotalOutput.Visible = false;
            // 
            // taxAmountLabel
            // 
            this.taxAmountLabel.AutoSize = true;
            this.taxAmountLabel.BackColor = System.Drawing.Color.White;
            this.taxAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxAmountLabel.Location = new System.Drawing.Point(769, 291);
            this.taxAmountLabel.Name = "taxAmountLabel";
            this.taxAmountLabel.Size = new System.Drawing.Size(38, 20);
            this.taxAmountLabel.TabIndex = 27;
            this.taxAmountLabel.Text = "Tax:";
            this.taxAmountLabel.Visible = false;
            // 
            // taxAmountOutput
            // 
            this.taxAmountOutput.AutoSize = true;
            this.taxAmountOutput.BackColor = System.Drawing.Color.White;
            this.taxAmountOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxAmountOutput.Location = new System.Drawing.Point(824, 291);
            this.taxAmountOutput.Name = "taxAmountOutput";
            this.taxAmountOutput.Size = new System.Drawing.Size(26, 20);
            this.taxAmountOutput.TabIndex = 28;
            this.taxAmountOutput.Text = "Nil";
            this.taxAmountOutput.Visible = false;
            // 
            // totalTextLabel
            // 
            this.totalTextLabel.AutoSize = true;
            this.totalTextLabel.BackColor = System.Drawing.Color.White;
            this.totalTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextLabel.Location = new System.Drawing.Point(751, 328);
            this.totalTextLabel.Name = "totalTextLabel";
            this.totalTextLabel.Size = new System.Drawing.Size(48, 20);
            this.totalTextLabel.TabIndex = 29;
            this.totalTextLabel.Text = "Total:";
            this.totalTextLabel.Visible = false;
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.BackColor = System.Drawing.Color.White;
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(824, 328);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(26, 20);
            this.totalOutput.TabIndex = 30;
            this.totalOutput.Text = "Nil";
            this.totalOutput.Visible = false;
            // 
            // returnedAmountLabel
            // 
            this.returnedAmountLabel.AutoSize = true;
            this.returnedAmountLabel.BackColor = System.Drawing.Color.White;
            this.returnedAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnedAmountLabel.Location = new System.Drawing.Point(724, 367);
            this.returnedAmountLabel.Name = "returnedAmountLabel";
            this.returnedAmountLabel.Size = new System.Drawing.Size(80, 20);
            this.returnedAmountLabel.TabIndex = 31;
            this.returnedAmountLabel.Text = "Returned:";
            this.returnedAmountLabel.Visible = false;
            // 
            // returnedAmountOutput
            // 
            this.returnedAmountOutput.AutoSize = true;
            this.returnedAmountOutput.BackColor = System.Drawing.Color.White;
            this.returnedAmountOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnedAmountOutput.Location = new System.Drawing.Point(824, 367);
            this.returnedAmountOutput.Name = "returnedAmountOutput";
            this.returnedAmountOutput.Size = new System.Drawing.Size(26, 20);
            this.returnedAmountOutput.TabIndex = 32;
            this.returnedAmountOutput.Text = "Nil";
            this.returnedAmountOutput.Visible = false;
            // 
            // calculatePurchaseButtton
            // 
            this.calculatePurchaseButtton.AutoSize = true;
            this.calculatePurchaseButtton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatePurchaseButtton.Location = new System.Drawing.Point(456, 393);
            this.calculatePurchaseButtton.Margin = new System.Windows.Forms.Padding(2);
            this.calculatePurchaseButtton.Name = "calculatePurchaseButtton";
            this.calculatePurchaseButtton.Size = new System.Drawing.Size(199, 32);
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
            this.lineLabel1.Location = new System.Drawing.Point(710, 107);
            this.lineLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lineLabel1.Name = "lineLabel1";
            this.lineLabel1.Size = new System.Drawing.Size(214, 8);
            this.lineLabel1.TabIndex = 34;
            this.lineLabel1.Visible = false;
            // 
            // lineLabel2
            // 
            this.lineLabel2.BackColor = System.Drawing.Color.Black;
            this.lineLabel2.Location = new System.Drawing.Point(710, 225);
            this.lineLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lineLabel2.Name = "lineLabel2";
            this.lineLabel2.Size = new System.Drawing.Size(214, 8);
            this.lineLabel2.TabIndex = 35;
            this.lineLabel2.Visible = false;
            // 
            // selectAnOptionLabel
            // 
            this.selectAnOptionLabel.AutoSize = true;
            this.selectAnOptionLabel.BackColor = System.Drawing.Color.DimGray;
            this.selectAnOptionLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAnOptionLabel.Location = new System.Drawing.Point(466, 32);
            this.selectAnOptionLabel.Name = "selectAnOptionLabel";
            this.selectAnOptionLabel.Size = new System.Drawing.Size(176, 24);
            this.selectAnOptionLabel.TabIndex = 36;
            this.selectAnOptionLabel.Text = "Select an Option";
            this.selectAnOptionLabel.Visible = false;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.Black;
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.ForeColor = System.Drawing.Color.White;
            this.newOrderButton.Location = new System.Drawing.Point(712, 393);
            this.newOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(212, 30);
            this.newOrderButton.TabIndex = 37;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Visible = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // totalCostDisplay
            // 
            this.totalCostDisplay.AutoSize = true;
            this.totalCostDisplay.BackColor = System.Drawing.Color.DimGray;
            this.totalCostDisplay.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostDisplay.Location = new System.Drawing.Point(488, 296);
            this.totalCostDisplay.Name = "totalCostDisplay";
            this.totalCostDisplay.Size = new System.Drawing.Size(65, 24);
            this.totalCostDisplay.TabIndex = 38;
            this.totalCostDisplay.Text = "Total:";
            this.totalCostDisplay.Visible = false;
            // 
            // walletLabel
            // 
            this.walletLabel.AutoSize = true;
            this.walletLabel.BackColor = System.Drawing.Color.Transparent;
            this.walletLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletLabel.Location = new System.Drawing.Point(24, 0);
            this.walletLabel.Name = "walletLabel";
            this.walletLabel.Size = new System.Drawing.Size(84, 29);
            this.walletLabel.TabIndex = 39;
            this.walletLabel.Text = "Wallet:";
            this.walletLabel.Visible = false;
            // 
            // moneyCounter
            // 
            this.moneyCounter.AutoSize = true;
            this.moneyCounter.BackColor = System.Drawing.Color.Transparent;
            this.moneyCounter.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyCounter.Location = new System.Drawing.Point(104, 0);
            this.moneyCounter.Name = "moneyCounter";
            this.moneyCounter.Size = new System.Drawing.Size(0, 29);
            this.moneyCounter.TabIndex = 40;
            this.moneyCounter.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.moneyCounter);
            this.Controls.Add(this.walletLabel);
            this.Controls.Add(this.totalCostDisplay);
            this.Controls.Add(this.newOrderButton);
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
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label totalCostDisplay;
        private System.Windows.Forms.Label walletLabel;
        private System.Windows.Forms.Label moneyCounter;
    }
}

