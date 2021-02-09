using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GeniyIdiotClassLibrary;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private Game game;       
        public User user;        
        private DateTime stopTime;

        public MainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
        private void enterNameButton_Click(object sender, EventArgs e)
        {
            user = new User("Инкогнито");                       
            var enterNameForm = new EnterNameForm(user);
            enterNameForm.ShowDialog();
            game = new Game(user); 

            userAnswerTextBox.Enabled = true;
            nextButton.Enabled = true;            
            ShowNextQuestion();
        }
        private void ShowNextQuestion()
        {
            var currentQuestion = game.PopGetRandomQuestion();
            questionTextLabel.Text = currentQuestion.Text;            
            questionNamberLabel.Text = game.GetQuestionNamberInfo();
            countTimer.Enabled = true;
            stopTime = DateTime.Now.AddSeconds(11);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var userAnswerTxt = userAnswerTextBox.Text;
            if (!isValidUserAnswer(userAnswerTxt))
            {
                userAnswerTextBox.Focus();
                return;
            }
            var userAnswer = Convert.ToInt32(userAnswerTxt);
            game.AcceptAnswer(userAnswer);            
            NextQuestion();
        }

        private void NextQuestion()
        {
            countTimer.Enabled = false;            
            if (game.End())
            {                
                var diagnose = game.CalculateDiagnose();
                MessageBox.Show(diagnose);
                UserResultsStorage.Append(user);
                userAnswerTextBox.Enabled = false;
                nextButton.Enabled = false;
                timeLabel.Text = "Время для ответа";
            }
            else
            {
                ShowNextQuestion();
            }
            userAnswerTextBox.Text = "";
            userAnswerTextBox.Focus();
        }

        private bool isValidUserAnswer(string userAnswerTxt)
        {
            int userAnswer;
            bool correctEntry;
            correctEntry = Int32.TryParse(userAnswerTxt, out userAnswer);
            if (!correctEntry)
            {
                MessageBox.Show("Пожалуйста, введите число (не превосходящее 10^9)!");
                userAnswerTextBox.Text = "";
            }
            return correctEntry;
        }

        private void начатьСначалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ПосмотретьРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var statisticForm = new StatisticForm();
            statisticForm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьСвойВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addQuestionForm = new AddQuestionForm();
            addQuestionForm.Show();
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            var dateTime = DateTime.Now;
            var timeSpan = (stopTime - dateTime);
            if ((int)timeSpan.TotalSeconds > 0)
            {
                timeLabel.Text = string.Format("Время для ответа {0:0} секунд", (int)timeSpan.TotalSeconds);
            }
            else
            {
                NextQuestion();
            }
        }

        private void статистикаДиагнозовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var statisticDiagnose = new StatisticDiagnoseForm();
            statisticDiagnose.Show();
        }
    }
}
