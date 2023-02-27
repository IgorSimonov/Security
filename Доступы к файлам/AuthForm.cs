using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Доступы_к_файлам
{
    public partial class Form1 : Form
    {
        public OperationsSystem operatingSystem;
        
        public Form1()
        {
            InitializeComponent();

            operatingSystem = new OperationsSystem();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            operatingSystem.Authorize(loginText.Text, passText.Text);
            
            if (operatingSystem.CurrentUser != null)
            {
                new MainForm(operatingSystem).ShowDialog();
            }
            else
            {
                MessageBox.Show("Такого пользователя нет");
            }
        }
    }
}
