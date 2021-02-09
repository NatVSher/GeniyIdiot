using GeniyIdiotClassLibrary;
using System;
using System.Windows.Forms;


namespace GeniyIdiotWindowsFormsApp
{
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            var userQuestion = questionTextBox.Text;
            var userAnswerTxt = answerTextBox.Text;
            if (!isValidUserAnswer(userAnswerTxt))
            {
                return;
            }
            var userAnswer = Convert.ToInt32(userAnswerTxt);
            var question = new Question(userQuestion, userAnswer);
            QuestionStorage.Append(question);
            this.Close();
        }
        private bool isValidUserAnswer(string userAnswerTxt)
        {
            int userAnswer;
            bool correctEntry;
            correctEntry = Int32.TryParse(userAnswerTxt, out userAnswer);
            if (!correctEntry)
            {
                MessageBox.Show("Пожалуйста, введите число (не превосходящее 10^9)!");
                answerTextBox.Text = "";
            }
            return correctEntry;
        }

    }
}
