namespace GeniyIdiotWindowsFormsApp
{
    partial class StatisticDiagnoseForm
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
            this.statisticDiagnoseDataGridView = new System.Windows.Forms.DataGridView();
            this.DiagnoseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.statisticDiagnoseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticDiagnoseDataGridView
            // 
            this.statisticDiagnoseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticDiagnoseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiagnoseColumn,
            this.CountColumn});
            this.statisticDiagnoseDataGridView.Location = new System.Drawing.Point(21, 21);
            this.statisticDiagnoseDataGridView.Name = "statisticDiagnoseDataGridView";
            this.statisticDiagnoseDataGridView.Size = new System.Drawing.Size(240, 222);
            this.statisticDiagnoseDataGridView.TabIndex = 0;
            // 
            // DiagnoseColumn
            // 
            this.DiagnoseColumn.HeaderText = "Диагноз";
            this.DiagnoseColumn.Name = "DiagnoseColumn";
            // 
            // CountColumn
            // 
            this.CountColumn.HeaderText = "Количество";
            this.CountColumn.Name = "CountColumn";
            // 
            // StatisticDiagnoseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 267);
            this.Controls.Add(this.statisticDiagnoseDataGridView);
            this.Name = "StatisticDiagnoseForm";
            this.Text = "StatisticDiagnoseForm";
            this.Load += new System.EventHandler(this.StatisticDiagnoseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisticDiagnoseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView statisticDiagnoseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnoseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
    }
}