using SealBank.DataSavers;
using SealBank.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SealBank.UI
{
    public partial class MainForm : Form
    {
        private readonly BankManagement Bank;

        public MainForm(BankManagement bankManagement)
        {
            InitializeComponent();
            Bank = bankManagement;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
