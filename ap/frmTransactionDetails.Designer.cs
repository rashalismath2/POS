namespace ap
{
    partial class frmTransactionDetails
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
            this.dataGridCustomerTrans = new System.Windows.Forms.DataGridView();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1lblTotalCustoemrTrans = new System.Windows.Forms.Label();
            this.txtTotalCustomerTransactions = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCustomerTrans
            // 
            this.dataGridCustomerTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomerTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productname,
            this.quentity,
            this.date,
            this.total});
            this.dataGridCustomerTrans.Location = new System.Drawing.Point(12, 49);
            this.dataGridCustomerTrans.Name = "dataGridCustomerTrans";
            this.dataGridCustomerTrans.Size = new System.Drawing.Size(447, 262);
            this.dataGridCustomerTrans.TabIndex = 0;
            // 
            // productname
            // 
            this.productname.HeaderText = "Product Name";
            this.productname.Name = "productname";
            // 
            // quentity
            // 
            this.quentity.HeaderText = "Quentity";
            this.quentity.Name = "quentity";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // label1lblTotalCustoemrTrans
            // 
            this.label1lblTotalCustoemrTrans.AutoSize = true;
            this.label1lblTotalCustoemrTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1lblTotalCustoemrTrans.Location = new System.Drawing.Point(244, 339);
            this.label1lblTotalCustoemrTrans.Name = "label1lblTotalCustoemrTrans";
            this.label1lblTotalCustoemrTrans.Size = new System.Drawing.Size(56, 25);
            this.label1lblTotalCustoemrTrans.TabIndex = 1;
            this.label1lblTotalCustoemrTrans.Text = "Total";
            // 
            // txtTotalCustomerTransactions
            // 
            this.txtTotalCustomerTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCustomerTransactions.Location = new System.Drawing.Point(315, 334);
            this.txtTotalCustomerTransactions.Name = "txtTotalCustomerTransactions";
            this.txtTotalCustomerTransactions.Size = new System.Drawing.Size(144, 30);
            this.txtTotalCustomerTransactions.TabIndex = 2;
            this.txtTotalCustomerTransactions.Text = "0.";
            // 
            // frmTransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 382);
            this.Controls.Add(this.txtTotalCustomerTransactions);
            this.Controls.Add(this.label1lblTotalCustoemrTrans);
            this.Controls.Add(this.dataGridCustomerTrans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTransactionDetails";
            this.Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCustomerTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label1lblTotalCustoemrTrans;
        private System.Windows.Forms.TextBox txtTotalCustomerTransactions;
    }
}