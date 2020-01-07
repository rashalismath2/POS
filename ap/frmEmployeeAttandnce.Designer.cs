namespace ap
{
    partial class frmEmployeeAttandnce
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
            this.dataGridEmployeeAttendances = new System.Windows.Forms.DataGridView();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMarkPrasence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployeeAttendances)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEmployeeAttendances
            // 
            this.dataGridEmployeeAttendances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployeeAttendances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstname,
            this.lastname,
            this.email});
            this.dataGridEmployeeAttendances.Location = new System.Drawing.Point(12, 31);
            this.dataGridEmployeeAttendances.Name = "dataGridEmployeeAttendances";
            this.dataGridEmployeeAttendances.Size = new System.Drawing.Size(343, 427);
            this.dataGridEmployeeAttendances.TabIndex = 0;
            // 
            // firstname
            // 
            this.firstname.HeaderText = "First Name";
            this.firstname.Name = "firstname";
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Last name";
            this.lastname.Name = "lastname";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // btnMarkPrasence
            // 
            this.btnMarkPrasence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkPrasence.Location = new System.Drawing.Point(439, 227);
            this.btnMarkPrasence.Name = "btnMarkPrasence";
            this.btnMarkPrasence.Size = new System.Drawing.Size(175, 44);
            this.btnMarkPrasence.TabIndex = 1;
            this.btnMarkPrasence.Text = "Mark precense";
            this.btnMarkPrasence.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeAttandnce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 493);
            this.Controls.Add(this.btnMarkPrasence);
            this.Controls.Add(this.dataGridEmployeeAttendances);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEmployeeAttandnce";
            this.Text = "Attendances";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployeeAttendances)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEmployeeAttendances;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button btnMarkPrasence;
    }
}