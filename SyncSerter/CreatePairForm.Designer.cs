namespace SyncSerter
{
    partial class CreatePairForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePairForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBrowseLeft = new System.Windows.Forms.Button();
            this.btnBrowseRight = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtLeftFolder = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtRightFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialogLeft = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogRight = new System.Windows.Forms.FolderBrowserDialog();
            this.cbAllFilesIncluded = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExcludeFileType = new System.Windows.Forms.TextBox();
            this.btnAddFileType = new System.Windows.Forms.Button();
            this.btnRemoveFileType = new System.Windows.Forms.Button();
            this.lstExcludedFileTypes = new System.Windows.Forms.ListBox();
            this.cbExcludeHiddenFiles = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(432, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(351, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowseLeft
            // 
            this.btnBrowseLeft.Location = new System.Drawing.Point(36, 88);
            this.btnBrowseLeft.Name = "btnBrowseLeft";
            this.btnBrowseLeft.Size = new System.Drawing.Size(216, 23);
            this.btnBrowseLeft.TabIndex = 1;
            this.btnBrowseLeft.Text = "Browse...";
            this.btnBrowseLeft.UseVisualStyleBackColor = true;
            this.btnBrowseLeft.Click += new System.EventHandler(this.btnBrowseLeft_Click);
            // 
            // btnBrowseRight
            // 
            this.btnBrowseRight.Location = new System.Drawing.Point(305, 89);
            this.btnBrowseRight.Name = "btnBrowseRight";
            this.btnBrowseRight.Size = new System.Drawing.Size(202, 23);
            this.btnBrowseRight.TabIndex = 2;
            this.btnBrowseRight.Text = "Browse...";
            this.btnBrowseRight.UseVisualStyleBackColor = true;
            this.btnBrowseRight.Click += new System.EventHandler(this.btnBrowseRight_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(150, 15);
            this.lblInstructions.TabIndex = 9;
            this.lblInstructions.Text = "Choose the folders to sync:";
            // 
            // txtLeftFolder
            // 
            this.txtLeftFolder.Location = new System.Drawing.Point(36, 59);
            this.txtLeftFolder.Name = "txtLeftFolder";
            this.txtLeftFolder.ReadOnly = true;
            this.txtLeftFolder.Size = new System.Drawing.Size(216, 23);
            this.txtLeftFolder.TabIndex = 10;
            this.txtLeftFolder.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(274, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 24);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // txtRightFolder
            // 
            this.txtRightFolder.Location = new System.Drawing.Point(305, 60);
            this.txtRightFolder.Name = "txtRightFolder";
            this.txtRightFolder.ReadOnly = true;
            this.txtRightFolder.Size = new System.Drawing.Size(202, 23);
            this.txtRightFolder.TabIndex = 11;
            this.txtRightFolder.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Left Folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Right Folder:";
            // 
            // cbAllFilesIncluded
            // 
            this.cbAllFilesIncluded.AutoSize = true;
            this.cbAllFilesIncluded.Checked = true;
            this.cbAllFilesIncluded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAllFilesIncluded.Location = new System.Drawing.Point(7, 31);
            this.cbAllFilesIncluded.Name = "cbAllFilesIncluded";
            this.cbAllFilesIncluded.Size = new System.Drawing.Size(115, 19);
            this.cbAllFilesIncluded.TabIndex = 16;
            this.cbAllFilesIncluded.TabStop = false;
            this.cbAllFilesIncluded.Text = "All Files Included";
            this.cbAllFilesIncluded.UseVisualStyleBackColor = true;
            this.cbAllFilesIncluded.CheckedChanged += new System.EventHandler(this.cbAllFilesIncluded_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtExcludeFileType);
            this.groupBox1.Controls.Add(this.btnAddFileType);
            this.groupBox1.Controls.Add(this.btnRemoveFileType);
            this.groupBox1.Controls.Add(this.lstExcludedFileTypes);
            this.groupBox1.Controls.Add(this.cbExcludeHiddenFiles);
            this.groupBox1.Controls.Add(this.cbAllFilesIncluded);
            this.groupBox1.Location = new System.Drawing.Point(5, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 208);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "File Type:";
            // 
            // txtExcludeFileType
            // 
            this.txtExcludeFileType.Enabled = false;
            this.txtExcludeFileType.Location = new System.Drawing.Point(8, 78);
            this.txtExcludeFileType.Name = "txtExcludeFileType";
            this.txtExcludeFileType.Size = new System.Drawing.Size(114, 23);
            this.txtExcludeFileType.TabIndex = 21;
            // 
            // btnAddFileType
            // 
            this.btnAddFileType.Enabled = false;
            this.btnAddFileType.Location = new System.Drawing.Point(7, 107);
            this.btnAddFileType.Name = "btnAddFileType";
            this.btnAddFileType.Size = new System.Drawing.Size(114, 23);
            this.btnAddFileType.TabIndex = 20;
            this.btnAddFileType.TabStop = false;
            this.btnAddFileType.Text = "Add";
            this.btnAddFileType.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFileType
            // 
            this.btnRemoveFileType.Enabled = false;
            this.btnRemoveFileType.Location = new System.Drawing.Point(8, 136);
            this.btnRemoveFileType.Name = "btnRemoveFileType";
            this.btnRemoveFileType.Size = new System.Drawing.Size(114, 23);
            this.btnRemoveFileType.TabIndex = 19;
            this.btnRemoveFileType.TabStop = false;
            this.btnRemoveFileType.Text = "Remove";
            this.btnRemoveFileType.UseVisualStyleBackColor = true;
            // 
            // lstExcludedFileTypes
            // 
            this.lstExcludedFileTypes.Enabled = false;
            this.lstExcludedFileTypes.FormattingEnabled = true;
            this.lstExcludedFileTypes.ItemHeight = 15;
            this.lstExcludedFileTypes.Location = new System.Drawing.Point(127, 78);
            this.lstExcludedFileTypes.Name = "lstExcludedFileTypes";
            this.lstExcludedFileTypes.Size = new System.Drawing.Size(120, 124);
            this.lstExcludedFileTypes.TabIndex = 18;
            // 
            // cbExcludeHiddenFiles
            // 
            this.cbExcludeHiddenFiles.AutoSize = true;
            this.cbExcludeHiddenFiles.Location = new System.Drawing.Point(128, 31);
            this.cbExcludeHiddenFiles.Name = "cbExcludeHiddenFiles";
            this.cbExcludeHiddenFiles.Size = new System.Drawing.Size(135, 19);
            this.cbExcludeHiddenFiles.TabIndex = 17;
            this.cbExcludeHiddenFiles.TabStop = false;
            this.cbExcludeHiddenFiles.Text = "Exclude Hidden Files";
            this.cbExcludeHiddenFiles.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(381, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 23);
            this.comboBox1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Sync Action:";
            // 
            // CreatePairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRightFolder);
            this.Controls.Add(this.txtLeftFolder);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnBrowseRight);
            this.Controls.Add(this.btnBrowseLeft);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "CreatePairForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Folder Pair";
            this.Load += new System.EventHandler(this.CreatePairForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Button btnBrowseLeft;
        private Button btnBrowseRight;
        private Label lblInstructions;
        private TextBox txtLeftFolder;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtRightFolder;
        private Label label1;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialogLeft;
        private FolderBrowserDialog folderBrowserDialogRight;
        private CheckBox cbAllFilesIncluded;
        private GroupBox groupBox1;
        private CheckBox cbExcludeHiddenFiles;
        private ListBox lstExcludedFileTypes;
        private Button btnRemoveFileType;
        private TextBox txtExcludeFileType;
        private Button btnAddFileType;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
    }
}