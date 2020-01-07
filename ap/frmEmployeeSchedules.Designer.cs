namespace ap
{
    partial class frmEmployeeSchedules
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchEmployeeSchedule = new System.Windows.Forms.TextBox();
            this.btnUpdateSchedule = new System.Windows.Forms.Button();
            this.btnDeleteEmployeeSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employee,
            this.day,
            this.starttime,
            this.endtime});
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // employee
            // 
            this.employee.HeaderText = "Employee name";
            this.employee.Name = "employee";
            // 
            // day
            // 
            this.day.HeaderText = "Day";
            this.day.Name = "day";
            // 
            // starttime
            // 
            this.starttime.HeaderText = "Start Time";
            this.starttime.Name = "starttime";
            // 
            // endtime
            // 
            this.endtime.HeaderText = "End Time";
            this.endtime.Name = "endtime";
            // 
            // txtSearchEmployeeSchedule
            // 
            this.txtSearchEmployeeSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmployeeSchedule.Location = new System.Drawing.Point(12, 25);
            this.txtSearchEmployeeSchedule.Name = "txtSearchEmployeeSchedule";
            this.txtSearchEmployeeSchedule.Size = new System.Drawing.Size(349, 30);
            this.txtSearchEmployeeSchedule.TabIndex = 2;
            this.txtSearchEmployeeSchedule.Text = "Search";
            // 
            // btnUpdateSchedule
            // 
            this.btnUpdateSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSchedule.Location = new System.Drawing.Point(512, 244);
            this.btnUpdateSchedule.Name = "btnUpdateSchedule";
            this.btnUpdateSchedule.Size = new System.Drawing.Size(84, 34);
            this.btnUpdateSchedule.TabIndex = 3;
            this.btnUpdateSchedule.Text = "Update";
            this.btnUpdateSchedule.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployeeSchedule
            // 
            this.btnDeleteEmployeeSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployeeSchedule.Location = new System.Drawing.Point(512, 297);
            this.btnDeleteEmployeeSchedule.Name = "btnDeleteEmployeeSchedule";
            this.btnDeleteEmployeeSchedule.Size = new System.Drawing.Size(84, 34);
            this.btnDeleteEmployeeSchedule.TabIndex = 4;
            this.btnDeleteEmployeeSchedule.Text = "Delete";
            this.btnDeleteEmployeeSchedule.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 540);
            this.Controls.Add(this.btnDeleteEmployeeSchedule);
            this.Controls.Add(this.btnUpdateSchedule);
            this.Controls.Add(this.txtSearchEmployeeSchedule);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEmployeeSchedules";
            this.Text = "Schedules";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtime;
        private System.Windows.Forms.TextBox txtSearchEmployeeSchedule;
        private System.Windows.Forms.Button btnUpdateSchedule;
        private System.Windows.Forms.Button btnDeleteEmployeeSchedule;
    }
}