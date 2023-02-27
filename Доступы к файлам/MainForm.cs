using System;
using System.Linq;
using System.Windows.Forms;

namespace Доступы_к_файлам
{
    public partial class MainForm : Form
    {
        private OperationsSystem _operationsSystem;
        
        public MainForm(OperationsSystem operationsSystem)
        {
            InitializeComponent();
            _operationsSystem = operationsSystem;

            label1.Text = _operationsSystem.CurrentUser.Login;
            
            gridFile3Access.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; 
            gridFile3Access.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            girdFileAccess.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; 
            girdFileAccess.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            gridFile2Access.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; 
            gridFile2Access.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            _operationsSystem.LogOut();
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        { 
            girdFileAccess.DataSource = _operationsSystem._store.GetFiles()[0].Access;
            gridFile2Access.DataSource = _operationsSystem._store.GetFiles()[1].Access;
            gridFile3Access.DataSource = _operationsSystem._store.GetFiles()[2].Access;
        }
    }
}