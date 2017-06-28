namespace veracity
{
    partial class ManagerStatistic
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
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.DepartmentColumn,
            this.HourColumn,
            this.PointsColumn});
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(709, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // DepartmentColumn
            // 
            this.DepartmentColumn.HeaderText = "Department";
            this.DepartmentColumn.Name = "DepartmentColumn";
            this.DepartmentColumn.ReadOnly = true;
            // 
            // HourColumn
            // 
            this.HourColumn.HeaderText = "Hours";
            this.HourColumn.Name = "HourColumn";
            this.HourColumn.ReadOnly = true;
            // 
            // PointsColumn
            // 
            this.PointsColumn.HeaderText = "Points";
            this.PointsColumn.Name = "PointsColumn";
            this.PointsColumn.ReadOnly = true;
            // 
            // ManagerStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 288);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManagerStatistic";
            this.Text = "ManagerStatistic";
            this.Load += new System.EventHandler(this.ManagerStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointsColumn;
        private int iD;

       
    }
}