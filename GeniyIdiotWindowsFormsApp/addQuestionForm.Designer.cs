namespace GeniyIdiotWindowsFormsApp
{
    partial class AddQuestionForm
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
            this.newQuestionLabel = new System.Windows.Forms.Label();
            this.answerNewQuestionLabel = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newQuestionLabel
            // 
            this.newQuestionLabel.AutoSize = true;
            this.newQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newQuestionLabel.Location = new System.Drawing.Point(275, 46);
            this.newQuestionLabel.Name = "newQuestionLabel";
            this.newQuestionLabel.Size = new System.Drawing.Size(249, 25);
            this.newQuestionLabel.TabIndex = 0;
            this.newQuestionLabel.Text = "Введите свой вопрос.";
            // 
            // answerNewQuestionLabel
            // 
            this.answerNewQuestionLabel.AutoSize = true;
            this.answerNewQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerNewQuestionLabel.Location = new System.Drawing.Point(247, 155);
            this.answerNewQuestionLabel.Name = "answerNewQuestionLabel";
            this.answerNewQuestionLabel.Size = new System.Drawing.Size(327, 25);
            this.answerNewQuestionLabel.TabIndex = 1;
            this.answerNewQuestionLabel.Text = "Введите ответ (целое число)";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTextBox.Location = new System.Drawing.Point(117, 101);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(564, 29);
            this.questionTextBox.TabIndex = 2;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerTextBox.Location = new System.Drawing.Point(347, 215);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 29);
            this.answerTextBox.TabIndex = 3;
            // 
            // doneButton
            // 
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doneButton.Location = new System.Drawing.Point(347, 285);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(100, 36);
            this.doneButton.TabIndex = 4;
            this.doneButton.Text = "Готово";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.answerNewQuestionLabel);
            this.Controls.Add(this.newQuestionLabel);
            this.Name = "AddQuestionForm";
            this.Text = "Добавление вопроса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newQuestionLabel;
        private System.Windows.Forms.Label answerNewQuestionLabel;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button doneButton;
    }
}