namespace ap
{
    partial class frmAddCustomer
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
            this.txtCustomerLastname = new System.Windows.Forms.TextBox();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.lblCustomerFirstName = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomergender = new System.Windows.Forms.Label();
            this.comboCustomerGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCustomerLastname
            // 
            this.txtCustomerLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerLastname.Location = new System.Drawing.Point(223, 84);
            this.txtCustomerLastname.Name = "txtCustomerLastname";
            this.txtCustomerLastname.Size = new System.Drawing.Size(220, 30);
            this.txtCustomerLastname.TabIndex = 25;
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLastName.Location = new System.Drawing.Point(65, 89);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(106, 25);
            this.lblCustomerLastName.TabIndex = 24;
            this.lblCustomerLastName.Text = "Last Name";
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerFirstName.Location = new System.Drawing.Point(223, 35);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(220, 30);
            this.txtCustomerFirstName.TabIndex = 23;
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.AutoSize = true;
            this.lblCustomerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFirstName.Location = new System.Drawing.Point(65, 38);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(106, 25);
            this.lblCustomerFirstName.TabIndex = 22;
            this.lblCustomerFirstName.Text = "First Name";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(342, 242);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(101, 34);
            this.btnAddCustomer.TabIndex = 21;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerEmail.Location = new System.Drawing.Point(223, 132);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(220, 30);
            this.txtCustomerEmail.TabIndex = 18;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(65, 135);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(60, 25);
            this.lblCustomerEmail.TabIndex = 17;
            this.lblCustomerEmail.Text = "Email";
            // 
            // lblCustomergender
            // 
            this.lblCustomergender.AutoSize = true;
            this.lblCustomergender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomergender.Location = new System.Drawing.Point(65, 184);
            this.lblCustomergender.Name = "lblCustomergender";
            this.lblCustomergender.Size = new System.Drawing.Size(77, 25);
            this.lblCustomergender.TabIndex = 26;
            this.lblCustomergender.Text = "Gender";
            // 
            // comboCustomerGender
            // 
            this.comboCustomerGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCustomerGender.FormattingEnabled = true;
            this.comboCustomerGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboCustomerGender.Location = new System.Drawing.Point(223, 184);
            this.comboCustomerGender.Name = "comboCustomerGender";
            this.comboCustomerGender.Size = new System.Drawing.Size(220, 33);
            this.comboCustomerGender.TabIndex = 27;
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 349);
            this.Controls.Add(this.comboCustomerGender);
            this.Controls.Add(this.lblCustomergender);
            this.Controls.Add(this.txtCustomerLastname);
            this.Controls.Add(this.lblCustomerLastName);
            this.Controls.Add(this.txtCustomerFirstName);
            this.Controls.Add(this.lblCustomerFirstName);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.lblCustomerEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddCustomer";
            this.Text = "Add customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerLastname;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.Label lblCustomerFirstName;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomergender;
        private System.Windows.Forms.ComboBox comboCustomerGender;
    }
}