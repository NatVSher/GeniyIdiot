namespace GeniyIdiotWindowsFormsApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.nextButton = new System.Windows.Forms.Button();
            this.questionNamberLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьСначалаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пПосмотретьРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСвойВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterNameButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.countTimer = new System.Windows.Forms.Timer(this.components);
            this.статистикаДиагнозовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nextButton.Location = new System.Drawing.Point(269, 350);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(194, 64);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // questionNamberLabel
            // 
            this.questionNamberLabel.AutoSize = true;
            this.questionNamberLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionNamberLabel.Location = new System.Drawing.Point(305, 127);
            this.questionNamberLabel.Name = "questionNamberLabel";
            this.questionNamberLabel.Size = new System.Drawing.Size(97, 22);
            this.questionNamberLabel.TabIndex = 1;
            this.questionNamberLabel.Text = "Вопрос №";
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTextLabel.Location = new System.Drawing.Point(12, 176);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(135, 22);
            this.questionTextLabel.TabIndex = 2;
            this.questionTextLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Enabled = false;
            this.userAnswerTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userAnswerTextBox.Location = new System.Drawing.Point(269, 288);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(194, 29);
            this.userAnswerTextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(713, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьСначалаToolStripMenuItem,
            this.пПосмотретьРезультатыToolStripMenuItem,
            this.статистикаДиагнозовToolStripMenuItem,
            this.добавитьСвойВопросToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // начатьСначалаToolStripMenuItem
            // 
            this.начатьСначалаToolStripMenuItem.Name = "начатьСначалаToolStripMenuItem";
            this.начатьСначалаToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.начатьСначалаToolStripMenuItem.Text = "Рестарт";
            this.начатьСначалаToolStripMenuItem.Click += new System.EventHandler(this.начатьСначалаToolStripMenuItem_Click);
            // 
            // пПосмотретьРезультатыToolStripMenuItem
            // 
            this.пПосмотретьРезультатыToolStripMenuItem.Name = "пПосмотретьРезультатыToolStripMenuItem";
            this.пПосмотретьРезультатыToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.пПосмотретьРезультатыToolStripMenuItem.Text = "Посмотреть статистику";
            this.пПосмотретьРезультатыToolStripMenuItem.Click += new System.EventHandler(this.ПосмотретьРезультатыToolStripMenuItem_Click);
            // 
            // добавитьСвойВопросToolStripMenuItem
            // 
            this.добавитьСвойВопросToolStripMenuItem.Name = "добавитьСвойВопросToolStripMenuItem";
            this.добавитьСвойВопросToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.добавитьСвойВопросToolStripMenuItem.Text = "Добавить свой вопрос";
            this.добавитьСвойВопросToolStripMenuItem.Click += new System.EventHandler(this.добавитьСвойВопросToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // enterNameButton
            // 
            this.enterNameButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterNameButton.Location = new System.Drawing.Point(269, 51);
            this.enterNameButton.Name = "enterNameButton";
            this.enterNameButton.Size = new System.Drawing.Size(194, 51);
            this.enterNameButton.TabIndex = 10;
            this.enterNameButton.Text = "Начать игру";
            this.enterNameButton.UseVisualStyleBackColor = true;
            this.enterNameButton.Click += new System.EventHandler(this.enterNameButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(12, 238);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(126, 19);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "Время для ответа";
            // 
            // countTimer
            // 
            this.countTimer.Interval = 700;
            this.countTimer.Tick += new System.EventHandler(this.countTimer_Tick);
            // 
            // статистикаДиагнозовToolStripMenuItem
            // 
            this.статистикаДиагнозовToolStripMenuItem.Name = "статистикаДиагнозовToolStripMenuItem";
            this.статистикаДиагнозовToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.статистикаДиагнозовToolStripMenuItem.Text = "Статистика диагнозов";
            this.статистикаДиагнозовToolStripMenuItem.Click += new System.EventHandler(this.статистикаДиагнозовToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.enterNameButton);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionNamberLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ГенийИдиот";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label questionNamberLabel;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.TextBox userAnswerTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьСначалаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пПосмотретьРезультатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСвойВопросToolStripMenuItem;
        private System.Windows.Forms.Button enterNameButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer countTimer;
        private System.Windows.Forms.ToolStripMenuItem статистикаДиагнозовToolStripMenuItem;
    }
}

