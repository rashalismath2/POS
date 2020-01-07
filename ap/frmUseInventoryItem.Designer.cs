namespace ap
{
    partial class frmUseInventoryItem
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
            this.lblInventoryItem = new System.Windows.Forms.Label();
            this.btnUseItem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTotalItemWeight = new System.Windows.Forms.TextBox();
            this.lblTotalItemWeight = new System.Windows.Forms.Label();
            this.txtUseItemWeight = new System.Windows.Forms.TextBox();
            this.lblUseItemWeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInventoryItem
            // 
            this.lblInventoryItem.AutoSize = true;
            this.lblInventoryItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryItem.Location = new System.Drawing.Point(37, 41);
            this.lblInventoryItem.Name = "lblInventoryItem";
            this.lblInventoryItem.Size = new System.Drawing.Size(106, 25);
            this.lblInventoryItem.TabIndex = 0;
            this.lblInventoryItem.Text = "Item Name";
            // 
            // btnUseItem
            // 
            this.btnUseItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseItem.Location = new System.Drawing.Point(319, 197);
            this.btnUseItem.Name = "btnUseItem";
            this.btnUseItem.Size = new System.Drawing.Size(84, 33);
            this.btnUseItem.TabIndex = 1;
            this.btnUseItem.Text = "Done";
            this.btnUseItem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(203, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 30);
            this.textBox1.TabIndex = 2;
            // 
            // txtTotalItemWeight
            // 
            this.txtTotalItemWeight.Enabled = false;
            this.txtTotalItemWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalItemWeight.Location = new System.Drawing.Point(203, 87);
            this.txtTotalItemWeight.Name = "txtTotalItemWeight";
            this.txtTotalItemWeight.ReadOnly = true;
            this.txtTotalItemWeight.Size = new System.Drawing.Size(200, 30);
            this.txtTotalItemWeight.TabIndex = 4;
            // 
            // lblTotalItemWeight
            // 
            this.lblTotalItemWeight.AutoSize = true;
            this.lblTotalItemWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemWeight.Location = new System.Drawing.Point(37, 92);
            this.lblTotalItemWeight.Name = "lblTotalItemWeight";
            this.lblTotalItemWeight.Size = new System.Drawing.Size(156, 25);
            this.lblTotalItemWeight.TabIndex = 3;
            this.lblTotalItemWeight.Text = "Total Wight(K.g)";
            // 
            // txtUseItemWeight
            // 
            this.txtUseItemWeight.Enabled = false;
            this.txtUseItemWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUseItemWeight.Location = new System.Drawing.Point(203, 140);
            this.txtUseItemWeight.Name = "txtUseItemWeight";
            this.txtUseItemWeight.Size = new System.Drawing.Size(200, 30);
            this.txtUseItemWeight.TabIndex = 6;
            // 
            // lblUseItemWeight
            // 
            this.lblUseItemWeight.AutoSize = true;
            this.lblUseItemWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseItemWeight.Location = new System.Drawing.Point(37, 145);
            this.lblUseItemWeight.Name = "lblUseItemWeight";
            this.lblUseItemWeight.Size = new System.Drawing.Size(108, 25);
            this.lblUseItemWeight.TabIndex = 5;
            this.lblUseItemWeight.Text = "Use weight";
            // 
            // frmUseInventoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 265);
            this.Controls.Add(this.txtUseItemWeight);
            this.Controls.Add(this.lblUseItemWeight);
            this.Controls.Add(this.txtTotalItemWeight);
            this.Controls.Add(this.lblTotalItemWeight);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUseItem);
            this.Controls.Add(this.lblInventoryItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUseInventoryItem";
            this.Text = "Use Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventoryItem;
        private System.Windows.Forms.Button btnUseItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTotalItemWeight;
        private System.Windows.Forms.Label lblTotalItemWeight;
        private System.Windows.Forms.TextBox txtUseItemWeight;
        private System.Windows.Forms.Label lblUseItemWeight;
    }
}