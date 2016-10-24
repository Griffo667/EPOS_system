namespace Dissertation
{
    partial class Form3
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
            this.btnSignoff = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.lboxProduct = new System.Windows.Forms.ListBox();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.btnStockLevel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignoff
            // 
            this.btnSignoff.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSignoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignoff.Location = new System.Drawing.Point(12, 267);
            this.btnSignoff.Name = "btnSignoff";
            this.btnSignoff.Size = new System.Drawing.Size(105, 81);
            this.btnSignoff.TabIndex = 23;
            this.btnSignoff.Text = "Return";
            this.btnSignoff.UseVisualStyleBackColor = false;
            this.btnSignoff.Click += new System.EventHandler(this.btnSignoff_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.PaleGreen;
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Location = new System.Drawing.Point(12, 182);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(105, 81);
            this.btnShop.TabIndex = 22;
            this.btnShop.Text = "Shop Reports";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(12, 97);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(105, 81);
            this.btnOrder.TabIndex = 21;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(12, 12);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(105, 81);
            this.btnStock.TabIndex = 20;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // lboxProduct
            // 
            this.lboxProduct.BackColor = System.Drawing.SystemColors.Window;
            this.lboxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxProduct.FormattingEnabled = true;
            this.lboxProduct.ItemHeight = 18;
            this.lboxProduct.Location = new System.Drawing.Point(418, 59);
            this.lboxProduct.Name = "lboxProduct";
            this.lboxProduct.Size = new System.Drawing.Size(267, 292);
            this.lboxProduct.TabIndex = 24;
            // 
            // cbProductType
            // 
            this.cbProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Location = new System.Drawing.Point(234, 97);
            this.cbProductType.MaxDropDownItems = 5;
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(178, 26);
            this.cbProductType.TabIndex = 26;
            this.cbProductType.Text = "Choose product type....";
            this.cbProductType.SelectedIndexChanged += new System.EventHandler(this.cbProductType_SelectedIndexChanged);
            // 
            // btnStockLevel
            // 
            this.btnStockLevel.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStockLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockLevel.Location = new System.Drawing.Point(123, 12);
            this.btnStockLevel.Name = "btnStockLevel";
            this.btnStockLevel.Size = new System.Drawing.Size(105, 81);
            this.btnStockLevel.TabIndex = 27;
            this.btnStockLevel.Text = "Show Stock Levels";
            this.btnStockLevel.UseVisualStyleBackColor = false;
            this.btnStockLevel.Click += new System.EventHandler(this.btnStockLevel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dissertation.Properties.Resources.Shop_logo;
            this.pictureBox1.Location = new System.Drawing.Point(637, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(123, 100);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(96, 18);
            this.lblProductType.TabIndex = 29;
            this.lblProductType.Text = "Product Type";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(123, 155);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(60, 18);
            this.lblProduct.TabIndex = 31;
            this.lblProduct.Text = "Product";
            this.lblProduct.Visible = false;
            // 
            // cbProduct
            // 
            this.cbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(234, 152);
            this.cbProduct.MaxDropDownItems = 5;
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(178, 26);
            this.cbProduct.TabIndex = 30;
            this.cbProduct.Text = "Choose product....";
            this.cbProduct.Visible = false;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.Location = new System.Drawing.Point(234, 12);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(105, 81);
            this.btnAddToOrder.TabIndex = 32;
            this.btnAddToOrder.Text = "Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Visible = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(123, 213);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 18);
            this.lblQuantity.TabIndex = 33;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Visible = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(234, 210);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(178, 24);
            this.txtQuantity.TabIndex = 34;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.Visible = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(234, 97);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(178, 24);
            this.dtpDate.TabIndex = 35;
            this.dtpDate.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(123, 267);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 81);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(697, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStockLevel);
            this.Controls.Add(this.lboxProduct);
            this.Controls.Add(this.btnSignoff);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbProductType);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management - Stock";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignoff;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.ListBox lboxProduct;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.Button btnStockLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnClear;
    }
}