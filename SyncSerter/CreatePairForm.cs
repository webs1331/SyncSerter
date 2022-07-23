using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncSerter
{
    public partial class CreatePairForm : Form
    {
        private Pair pair;

        public CreatePairForm() => InitializeComponent();

        private void CreatePairForm_Load(object sender, EventArgs e)
        {
            pair = new Pair();
        }

        private void btnBrowseLeft_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogLeft.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtLeftFolder.Text = pair.LeftFolder = folderBrowserDialogLeft.SelectedPath;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void btnBrowseRight_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogRight.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtRightFolder.Text = pair.RightFolder = folderBrowserDialogRight.SelectedPath;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!File.Exists(pair.LeftFolder) || !File.Exists(pair.RightFolder))
            {
                return;
            }


        }

        private void cbAllFilesIncluded_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = (CheckBox) sender;

            txtExcludeFileType.Enabled = !checkbox.Checked;
            btnAddFileType.Enabled = !checkbox.Checked;
            lstExcludedFileTypes.Enabled = !checkbox.Checked;
        }
    }
}
