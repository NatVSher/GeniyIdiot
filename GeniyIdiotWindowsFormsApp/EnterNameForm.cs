using System;
using System.Windows.Forms;
using GeniyIdiotClassLibrary;
using System.Collections.Generic;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class EnterNameForm : Form
    {
        User user;
        public EnterNameForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            enterNameTextBox.Focus();
            string name = enterNameTextBox.Text.ToUpper();

            if (!IsValidName(name))
            {
                return;
            }
            user.Name = name;
            this.Close();
        }

        private bool IsValidName(string name)
        {
            if (name.Length > 20 || name.Length == 0)
            {
                enterNameTextBox.Text = "";
                MessageBox.Show("Имя не должно превышать 20 знаков.");
                return false;
            }

            for (int i = 0; i < name.Length; i++)
            {
                if ((name[i] < 'А' && name[i] != 'Ё') || name[i] > 'Я')
                {
                    enterNameTextBox.Text = "";
                    MessageBox.Show("Имя должно состоять только из букв русского алфавита!");
                    return false;
                }
            }
            return true;
        }

        private void EnterNameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
