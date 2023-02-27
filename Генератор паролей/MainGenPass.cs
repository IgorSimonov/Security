using System;
using System.Text;
using System.Windows.Forms;

namespace Генератор_паролей
{
    public partial class MainGenPass : Form
    {
        public MainGenPass()
        {
            InitializeComponent();
        }

        private void genPass_Click(object sender, EventArgs e)
        {
            StringBuilder passList = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                passList.Append(GenPass.CreatePassword() + Environment.NewLine);
            }

            this.passList.Text = passList.ToString();
        }
    }
}
