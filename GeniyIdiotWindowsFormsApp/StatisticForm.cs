using System;
using System.Windows.Forms;
using GeniyIdiotClassLibrary;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            var users = UserResultsStorage.GetAll();
            foreach (var user in users)
            {
                statisticDataGridView.Rows.Add(user.Name, user.CountRightAnswers, user.Diagnose);
            }
        }
    }
}
