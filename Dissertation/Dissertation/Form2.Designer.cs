namespace Dissertation
{
    partial class Form2
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
            this.btnSale = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSignoff = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.ListBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.btnNextItem = new System.Windows.Forms.Button();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnVoid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Location = new System.Drawing.Point(12, 12);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(105, 81);
            this.btnSale.TabIndex = 16;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dissertation.Properties.Resources.Shop_logo;
            this.pictureBox1.Location = new System.Drawing.Point(637, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefund
            // 
            this.btnRefund.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefund.Location = new System.Drawing.Point(12, 97);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(105, 81);
            this.btnRefund.TabIndex = 17;
            this.btnRefund.Text = "Refund";
            this.btnRefund.UseVisualStyleBackColor = false;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(12, 182);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(105, 81);
            this.btnReport.TabIndex = 18;
            this.btnReport.Text = "Management";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSignoff
            // 
            this.btnSignoff.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSignoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignoff.Location = new System.Drawing.Point(12, 267);
            this.btnSignoff.Name = "btnSignoff";
            this.btnSignoff.Size = new System.Drawing.Size(105, 81);
            this.btnSignoff.TabIndex = 19;
            this.btnSignoff.Text = "Sign Off";
            this.btnSignoff.UseVisualStyleBackColor = false;
            this.btnSignoff.Click += new System.EventHandler(this.button4_Click);
            // 
            // Product
            // 
            this.Product.Enabled = false;
            this.Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.FormattingEnabled = true;
            this.Product.ItemHeight = 18;
            this.Product.Location = new System.Drawing.Point(438, 59);
            this.Product.Name = "Product";
            this.Product.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Product.Size = new System.Drawing.Size(193, 256);
            this.Product.TabIndex = 22;
            this.Product.SelectedIndexChanged += new System.EventHandler(this.Product_SelectedIndexChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(485, 327);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(200, 24);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "£0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Total";
            // 
            // btn00
            // 
            this.btn00.BackColor = System.Drawing.Color.PaleGreen;
            this.btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.Location = new System.Drawing.Point(392, 311);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(40, 40);
            this.btn00.TabIndex = 5;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = false;
            this.btn00.Click += new System.EventHandler(this.btn00_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.PaleGreen;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(346, 311);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(40, 40);
            this.btn0.TabIndex = 4;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.PaleGreen;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(392, 267);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 40);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.PaleGreen;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(346, 267);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 40);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.PaleGreen;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(300, 267);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 40);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.PaleGreen;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(392, 223);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 40);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.PaleGreen;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(346, 223);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 40);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.PaleGreen;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(300, 223);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 40);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.PaleGreen;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(392, 177);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 40);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.PaleGreen;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(346, 177);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 40);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.PaleGreen;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(300, 177);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 40);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(300, 97);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(132, 24);
            this.txtProductID.TabIndex = 1;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            this.txtProductID.Enter += new System.EventHandler(this.txtProductID_Enter);
            this.txtProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductID_KeyPress);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(123, 100);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(78, 18);
            this.lblProductID.TabIndex = 20;
            this.lblProductID.Text = "Product ID";
            // 
            // btnNextItem
            // 
            this.btnNextItem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNextItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextItem.Location = new System.Drawing.Point(254, 311);
            this.btnNextItem.Name = "btnNextItem";
            this.btnNextItem.Size = new System.Drawing.Size(86, 40);
            this.btnNextItem.TabIndex = 3;
            this.btnNextItem.Text = "Next Item";
            this.btnNextItem.UseVisualStyleBackColor = false;
            this.btnNextItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNewTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTransaction.Location = new System.Drawing.Point(123, 12);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(105, 81);
            this.btnNewTransaction.TabIndex = 15;
            this.btnNewTransaction.Text = "Finish Transaction";
            this.btnNewTransaction.UseVisualStyleBackColor = false;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // Price
            // 
            this.Price.Enabled = false;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.FormattingEnabled = true;
            this.Price.ItemHeight = 18;
            this.Price.Location = new System.Drawing.Point(611, 59);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(74, 256);
            this.Price.TabIndex = 23;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(123, 138);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 18);
            this.lblQuantity.TabIndex = 21;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(300, 135);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(132, 24);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.BackColor = System.Drawing.Color.PaleGreen;
            this.btnProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSearch.Location = new System.Drawing.Point(234, 12);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(105, 81);
            this.btnProductSearch.TabIndex = 25;
            this.btnProductSearch.Text = "Product Search";
            this.btnProductSearch.UseVisualStyleBackColor = false;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(300, 97);
            this.comboBox1.MaxDropDownItems = 5;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 26);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // btnVoid
            // 
            this.btnVoid.BackColor = System.Drawing.Color.PaleGreen;
            this.btnVoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid.Location = new System.Drawing.Point(162, 311);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(86, 40);
            this.btnVoid.TabIndex = 27;
            this.btnVoid.Text = "Void Item";
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(697, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.btnProductSearch);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.btnNewTransaction);
            this.Controls.Add(this.btnNextItem);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.btnSignoff);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSignoff;
        private System.Windows.Forms.ListBox Product;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Button btnNextItem;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.ListBox Price;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnVoid;

    }
}