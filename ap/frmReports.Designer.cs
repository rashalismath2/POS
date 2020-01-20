namespace UI
{
    partial class frmReports
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
            this.btnReports = new System.Windows.Forms.Button();
            this.btnTotalByBranches = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(75, 170);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(95, 60);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Total by date";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnTotalByBranches
            // 
            this.btnTotalByBranches.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalByBranches.Location = new System.Drawing.Point(199, 170);
            this.btnTotalByBranches.Name = "btnTotalByBranches";
            this.btnTotalByBranches.Size = new System.Drawing.Size(104, 60);
            this.btnTotalByBranches.TabIndex = 6;
            this.btnTotalByBranches.Text = "Total by branch";
            this.btnTotalByBranches.UseVisualStyleBackColor = true;
            this.btnTotalByBranches.Click += new System.EventHandler(this.btnTotalByBranches_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 437);
            this.Controls.Add(this.btnTotalByBranches);
            this.Controls.Add(this.btnReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnTotalByBranches;
    }
}