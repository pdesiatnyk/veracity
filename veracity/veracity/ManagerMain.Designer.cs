namespace veracity
{
    partial class ManagerMain
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
            this.BtnStatistic = new System.Windows.Forms.Button();
            this.BtnNewTask = new System.Windows.Forms.Button();
            this.BtnSalary = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStatistic
            // 
            this.BtnStatistic.Location = new System.Drawing.Point(70, 15);
            this.BtnStatistic.Name = "BtnStatistic";
            this.BtnStatistic.Size = new System.Drawing.Size(119, 62);
            this.BtnStatistic.TabIndex = 0;
            this.BtnStatistic.Text = "Statistic by department";
            this.BtnStatistic.UseVisualStyleBackColor = true;
            this.BtnStatistic.Click += new System.EventHandler(this.BtnStatistic_Click);
            // 
            // BtnNewTask
            // 
            this.BtnNewTask.Location = new System.Drawing.Point(70, 92);
            this.BtnNewTask.Name = "BtnNewTask";
            this.BtnNewTask.Size = new System.Drawing.Size(119, 62);
            this.BtnNewTask.TabIndex = 1;
            this.BtnNewTask.Text = "Add new task";
            this.BtnNewTask.UseVisualStyleBackColor = true;
            this.BtnNewTask.Click += new System.EventHandler(this.BtnNewTask_Click);
            // 
            // BtnSalary
            // 
            this.BtnSalary.Location = new System.Drawing.Point(70, 169);
            this.BtnSalary.Name = "BtnSalary";
            this.BtnSalary.Size = new System.Drawing.Size(119, 62);
            this.BtnSalary.TabIndex = 2;
            this.BtnSalary.Text = "Manage salary";
            this.BtnSalary.UseVisualStyleBackColor = true;
            this.BtnSalary.Click += new System.EventHandler(this.BtnSalary_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(70, 246);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(119, 62);
            this.BtnConfirm.TabIndex = 3;
            this.BtnConfirm.Text = "Confirm task";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 325);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnSalary);
            this.Controls.Add(this.BtnNewTask);
            this.Controls.Add(this.BtnStatistic);
            this.Name = "ManagerMain";
            this.Text = "ManagerMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStatistic;
        private System.Windows.Forms.Button BtnNewTask;
        private System.Windows.Forms.Button BtnSalary;
        private System.Windows.Forms.Button BtnConfirm;
    }
}