namespace GeniyIdiotWindowsFormsApp
{
    partial class StatisticForm
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
            this.statisticDataGridView = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRightAnsverColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnoseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.statisticDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticDataGridView
            // 
            this.statisticDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.userRightAnsverColumn,
            this.diagnoseColumn});
            this.statisticDataGridView.Location = new System.Drawing.Point(26, 22);
            this.statisticDataGridView.Name = "statisticDataGridView";
            this.statisticDataGridView.Size = new System.Drawing.Size(342, 278);
            this.statisticDataGridView.TabIndex = 0;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Имя";
            this.nameColumn.Name = "nameColumn";
            // 
            // userRightAnsverColumn
            // 
            this.userRightAnsverColumn.HeaderText = "Количество правильных ответов";
            this.userRightAnsverColumn.Name = "userRightAnsverColumn";
            // 
            // diagnoseColumn
            // 
            this.diagnoseColumn.HeaderText = "Диагноз";
            this.diagnoseColumn.Name = "diagnoseColumn";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 321);
            this.Controls.Add(this.statisticDataGridView);
            this.Name = "StatisticForm";
            this.Text = "Статистика игры";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisticDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView statisticDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRightAnsverColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnoseColumn;
    }
}