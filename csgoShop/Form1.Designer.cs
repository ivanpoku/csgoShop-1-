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
            ((System.ComponentModel.ISupportInitialize)(this.shopBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deagleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // shopBase
            // 
            this.shopBase.BackColor = System.Drawing.Color.Transparent;
            this.shopBase.Image = ((System.Drawing.Image)(resources.GetObject("shopBase.Image")));
            this.shopBase.Location = new System.Drawing.Point(80, 32);
            this.shopBase.Name = "shopBase";
            this.shopBase.Size = new System.Drawing.Size(392, 392);
            this.shopBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shopBase.TabIndex = 0;
            this.shopBase.TabStop = false;
            // 
            // pistolShopFunction
            // 
            this.pistolShopFunction.BackColor = System.Drawing.Color.Black;
            this.pistolShopFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pistolShopFunction.ForeColor = System.Drawing.Color.White;
            this.pistolShopFunction.Location = new System.Drawing.Point(336, 168);
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
            this.gunDisplayLabel.Location = new System.Drawing.Point(528, 24);
            this.gunDisplayLabel.Name = "gunDisplayLabel";
            this.gunDisplayLabel.Size = new System.Drawing.Size(244, 408);
            this.gunDisplayLabel.TabIndex = 2;
            this.gunDisplayLabel.Visible = false;
            // 
            // deagleImage
            // 
            this.deagleImage.BackColor = System.Drawing.Color.DimGray;
            this.deagleImage.Image = ((System.Drawing.Image)(resources.GetObject("deagleImage.Image")));
            this.deagleImage.Location = new System.Drawing.Point(656, 40);
            this.deagleImage.Name = "deagleImage";
            this.deagleImage.Size = new System.Drawing.Size(100, 50);
            this.deagleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deagleImage.TabIndex = 3;
            this.deagleImage.TabStop = false;
            this.deagleImage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deagleImage);
            this.Controls.Add(this.gunDisplayLabel);
            this.Controls.Add(this.pistolShopFunction);
            this.Controls.Add(this.shopBase);
            this.Name = "Form1";
            this.Text = "Counter Strike - Global Offence";
            ((System.ComponentModel.ISupportInitialize)(this.shopBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deagleImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox shopBase;
        private System.Windows.Forms.Label pistolShopFunction;
        private System.Windows.Forms.Label gunDisplayLabel;
        private System.Windows.Forms.PictureBox deagleImage;
    }
}

