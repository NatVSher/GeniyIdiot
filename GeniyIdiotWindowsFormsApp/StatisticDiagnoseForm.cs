using GeniyIdiotClassLibrary;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class StatisticDiagnoseForm : Form
    {
        public StatisticDiagnoseForm()
        {
            InitializeComponent();
        }

        private void StatisticDiagnoseForm_Load(object sender, EventArgs e)
        {
            var diagnoses = DiagnoseCalculator.GetDiagnoses();
            var countDiagnose = CountDiagnose();            
            for (int i = 0; i < countDiagnose.Length; i++)
            {
                statisticDiagnoseDataGridView.Rows.Add(diagnoses[i], countDiagnose[i]);
            }
        }
        private int[] CountDiagnose()
        {
            var diagnoses = DiagnoseCalculator.GetDiagnoses();
            var countDiagnose = new int[diagnoses.Length];
            var users = UserResultsStorage.GetAll();
            foreach (var user in users)
            {
                for (int i = 0; i < diagnoses.Length; i++)
                {
                    if (user.Diagnose == diagnoses[i])
                    {
                        countDiagnose[i]++;
                    }
                }
            }
            return countDiagnose;
        }
    }
}
