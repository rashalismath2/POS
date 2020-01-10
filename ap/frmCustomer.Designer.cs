namespace ap
{
    partial class frmCustomer
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
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.txtSearchCustomers = new System.Windows.Forms.TextBox();
            this.btnCustomerTrans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Location = new System.Drawing.Point(16, 73);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.Size = new System.Drawing.Size(645, 294);
            this.dataGridCustomers.TabIndex = 0;
            this.dataGridCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomers_CellContentClick);
            // 
            // txtSearchCustomers
            // 
            this.txtSearchCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomers.Location = new System.Drawing.Point(154, 28);
            this.txtSearchCustomers.Name = "txtSearchCustomers";
            this.txtSearchCustomers.Size = new System.Drawing.Size(345, 30);
            this.txtSearchCustomers.TabIndex = 1;
            this.txtSearchCustomers.Text = "Search";
            // 
            // btnCustomerTrans
            // 
            this.btnCustomerTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerTrans.Location = new System.Drawing.Point(517, 383);
            this.btnCustomerTrans.Name = "btnCustomerTrans";
            this.btnCustomerTrans.Size = new System.Drawing.Size(144, 33);
            this.btnCustomerTrans.TabIndex = 2;
            this.btnCustomerTrans.Text = "Transactions";
            this.btnCustomerTrans.UseVisualStyleBackColor = true;
            this.btnCustomerTrans.Click += new System.EventHandler(this.btnCustomerTrans_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 437);
            this.Controls.Add(this.btnCustomerTrans);
            this.Controls.Add(this.txtSearchCustomers);
            this.Controls.Add(this.dataGridCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.TextBox txtSearchCustomers;
        private System.Windows.Forms.Button btnCustomerTrans;
    }
}