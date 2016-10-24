namespace Dissertation
{
    partial class Form6
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
            this.btnMore = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDateF = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.cbReport = new System.Windows.Forms.ComboBox();
            this.lblDateT = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.PaleGreen;
            this.btnMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.Location = new System.Drawing.Point(12, 182);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(105, 81);
            this.btnMore.TabIndex = 25;
            this.btnMore.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.PaleGreen;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(12, 97);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(105, 81);
            this.btnExport.TabIndex = 24;
            this.btnExport.Text = "Export Report";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.PaleGreen;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(12, 12);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(105, 81);
            this.btnView.TabIndex = 23;
            this.btnView.Text = "View Report";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(12, 267);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(105, 81);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cbData
            // 
            this.cbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbData.FormattingEnabled = true;
            this.cbData.Location = new System.Drawing.Point(239, 12);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(190, 26);
            this.cbData.TabIndex = 27;
            this.cbData.SelectedIndexChanged += new System.EventHandler(this.cbData_SelectedIndexChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(123, 15);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(75, 18);
            this.lblData.TabIndex = 28;
            this.lblData.Text = "Data Type";
            // 
            // lblDateF
            // 
            this.lblDateF.AutoSize = true;
            this.lblDateF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateF.Location = new System.Drawing.Point(123, 97);
            this.lblDateF.Name = "lblDateF";
            this.lblDateF.Size = new System.Drawing.Size(79, 18);
            this.lblDateF.TabIndex = 30;
            this.lblDateF.Text = "Date From";
            this.lblDateF.Visible = false;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(123, 56);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(53, 18);
            this.lblReport.TabIndex = 34;
            this.lblReport.Text = "Report";
            // 
            // cbReport
            // 
            this.cbReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReport.FormattingEnabled = true;
            this.cbReport.Location = new System.Drawing.Point(239, 53);
            this.cbReport.Name = "cbReport";
            this.cbReport.Size = new System.Drawing.Size(190, 26);
            this.cbReport.TabIndex = 33;
            // 
            // lblDateT
            // 
            this.lblDateT.AutoSize = true;
            this.lblDateT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateT.Location = new System.Drawing.Point(123, 137);
            this.lblDateT.Name = "lblDateT";
            this.lblDateT.Size = new System.Drawing.Size(61, 18);
            this.lblDateT.TabIndex = 36;
            this.lblDateT.Text = "Date To";
            this.lblDateT.Visible = false;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(239, 92);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(190, 24);
            this.dtpFrom.TabIndex = 37;
            this.dtpFrom.Visible = false;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(239, 132);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(190, 24);
            this.dtpTo.TabIndex = 38;
            this.dtpTo.Visible = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(697, 361);
            this.ControlBox = false;
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblDateT);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.cbReport);
            this.Controls.Add(this.lblDateF);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cbData);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnReturn);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDateF;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.ComboBox cbReport;
        private System.Windows.Forms.Label lblDateT;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        public System.Windows.Forms.ComboBox cbData;
    }
}