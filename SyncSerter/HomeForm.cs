using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncSerter
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //load pairs
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //TODO
            //get currently selected pair from UI and execute
        }

        private void btnCreatePair_Click(object sender, EventArgs e)
        {
            var form = new CreatePairForm();

            form.Show();
        }
    }
}
