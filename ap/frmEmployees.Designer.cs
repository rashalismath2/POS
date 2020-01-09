namespace ap
{
    partial class frmEmployees
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
            this.btnEmployeeRecords = new System.Windows.Forms.Button();
            this.btnEmployeeAttendance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployeeRecords
            // 
            this.btnEmployeeRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeRecords.Location = new System.Drawing.Point(187, 175);
            this.btnEmployeeRecords.Name = "btnEmployeeRecords";
            this.btnEmployeeRecords.Size = new System.Drawing.Size(98, 38);
            this.btnEmployeeRecords.TabIndex = 0;
            this.btnEmployeeRecords.Text = "Records";
            this.btnEmployeeRecords.UseVisualStyleBackColor = true;
            this.btnEmployeeRecords.Click += new System.EventHandler(this.btnEmployeeRecords_Click);
            // 
            // btnEmployeeAttendance
            // 
            this.btnEmployeeAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeAttendance.Location = new System.Drawing.Point(338, 175);
            this.btnEmployeeAttendance.Name = "btnEmployeeAttendance";
            this.btnEmployeeAttendance.Size = new System.Drawing.Size(148, 38);
            this.btnEmployeeAttendance.TabIndex = 1;
            this.btnEmployeeAttendance.Text = "Attandance";
            this.btnEmployeeAttendance.UseVisualStyleBackColor = true;
            this.btnEmployeeAttendance.Click += new System.EventHandler(this.btnEmployeeAttendance_Click);
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 437);
            this.Controls.Add(this.btnEmployeeAttendance);
            this.Controls.Add(this.btnEmployeeRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmEmployees";
            this.Text = "frmEmployees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeRecords;
        private System.Windows.Forms.Button btnEmployeeAttendance;
    }
}