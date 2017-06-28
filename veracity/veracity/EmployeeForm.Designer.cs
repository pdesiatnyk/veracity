namespace veracity
{
    partial class EmployeeForm
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
            this.BtnEmpTaskStatictic = new System.Windows.Forms.Button();
            this.BtnEmpTimeStatictic = new System.Windows.Forms.Button();
            this.BtnEmpProjectedSalary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEmpTaskStatictic
            // 
            this.BtnEmpTaskStatictic.Location = new System.Drawing.Point(56, 37);
            this.BtnEmpTaskStatictic.Name = "BtnEmpTaskStatictic";
            this.BtnEmpTaskStatictic.Size = new System.Drawing.Size(140, 60);
            this.BtnEmpTaskStatictic.TabIndex = 0;
            this.BtnEmpTaskStatictic.Text = "Task Statistic";
            this.BtnEmpTaskStatictic.UseVisualStyleBackColor = true;
            this.BtnEmpTaskStatictic.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEmpTimeStatictic
            // 
            this.BtnEmpTimeStatictic.Location = new System.Drawing.Point(56, 103);
            this.BtnEmpTimeStatictic.Name = "BtnEmpTimeStatictic";
            this.BtnEmpTimeStatictic.Size = new System.Drawing.Size(140, 60);
            this.BtnEmpTimeStatictic.TabIndex = 1;
            this.BtnEmpTimeStatictic.Text = "Time Statistic";
            this.BtnEmpTimeStatictic.UseVisualStyleBackColor = true;
            this.BtnEmpTimeStatictic.Click += new System.EventHandler(this.BtnEmpTimeStatictic_Click);
            // 
            // BtnEmpProjectedSalary
            // 
            this.BtnEmpProjectedSalary.Location = new System.Drawing.Point(56, 169);
            this.BtnEmpProjectedSalary.Name = "BtnEmpProjectedSalary";
            this.BtnEmpProjectedSalary.Size = new System.Drawing.Size(140, 60);
            this.BtnEmpProjectedSalary.TabIndex = 1;
            this.BtnEmpProjectedSalary.Text = "Projected Salary";
            this.BtnEmpProjectedSalary.UseVisualStyleBackColor = true;
            this.BtnEmpProjectedSalary.Click += new System.EventHandler(this.BtnEmpProjectedSalary_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 291);
            this.Controls.Add(this.BtnEmpProjectedSalary);
            this.Controls.Add(this.BtnEmpTimeStatictic);
            this.Controls.Add(this.BtnEmpTaskStatictic);
            this.Name = "EmployeeForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEmpTaskStatictic;
        private System.Windows.Forms.Button BtnEmpTimeStatictic;
        private System.Windows.Forms.Button BtnEmpProjectedSalary;
    }
}