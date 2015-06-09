namespace TM_InnerJoin
{
    partial class ProviderConfDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProviderConfDialog));
            this.comboLanguagePairsTm1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxTm1 = new System.Windows.Forms.GroupBox();
            this.btnSelectTm1 = new System.Windows.Forms.Button();
            this.contextMenuTm1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSelectFileTm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSelectServerTm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTm1Path = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxTm2 = new System.Windows.Forms.GroupBox();
            this.btnSelectTm2 = new System.Windows.Forms.Button();
            this.txtTm2Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboLanguagePairsTm2 = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.contextMenuTm2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSelectFileTm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSelectServerTm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxTm1.SuspendLayout();
            this.contextMenuTm1.SuspendLayout();
            this.groupBoxTm2.SuspendLayout();
            this.contextMenuTm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboLanguagePairsTm1
            // 
            this.comboLanguagePairsTm1.FormattingEnabled = true;
            this.comboLanguagePairsTm1.Location = new System.Drawing.Point(12, 84);
            this.comboLanguagePairsTm1.Margin = new System.Windows.Forms.Padding(4);
            this.comboLanguagePairsTm1.Name = "comboLanguagePairsTm1";
            this.comboLanguagePairsTm1.Size = new System.Drawing.Size(455, 24);
            this.comboLanguagePairsTm1.TabIndex = 8;
            this.comboLanguagePairsTm1.SelectedIndexChanged += new System.EventHandler(this.comboLanguagePairsTm1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Language pair:";
            // 
            // groupBoxTm1
            // 
            this.groupBoxTm1.Controls.Add(this.btnSelectTm1);
            this.groupBoxTm1.Controls.Add(this.txtTm1Path);
            this.groupBoxTm1.Controls.Add(this.label2);
            this.groupBoxTm1.Controls.Add(this.comboLanguagePairsTm1);
            this.groupBoxTm1.Location = new System.Drawing.Point(24, 33);
            this.groupBoxTm1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTm1.Name = "groupBoxTm1";
            this.groupBoxTm1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTm1.Size = new System.Drawing.Size(761, 137);
            this.groupBoxTm1.TabIndex = 13;
            this.groupBoxTm1.TabStop = false;
            this.groupBoxTm1.Text = "Select translation memory 1";
            // 
            // btnSelectTm1
            // 
            this.btnSelectTm1.ContextMenuStrip = this.contextMenuTm1;
            this.btnSelectTm1.Location = new System.Drawing.Point(640, 21);
            this.btnSelectTm1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectTm1.Name = "btnSelectTm1";
            this.btnSelectTm1.Size = new System.Drawing.Size(111, 28);
            this.btnSelectTm1.TabIndex = 1;
            this.btnSelectTm1.Text = "Select TM >";
            this.btnSelectTm1.UseVisualStyleBackColor = true;
            this.btnSelectTm1.Click += new System.EventHandler(this.btnSelectTm1_Click);
            // 
            // contextMenuTm1
            // 
            this.contextMenuTm1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuTm1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSelectFileTm1,
            this.toolStripSelectServerTm1});
            this.contextMenuTm1.Name = "contextMenuTm";
            this.contextMenuTm1.Size = new System.Drawing.Size(189, 52);
            // 
            // toolStripSelectFileTm1
            // 
            this.toolStripSelectFileTm1.Name = "toolStripSelectFileTm1";
            this.toolStripSelectFileTm1.Size = new System.Drawing.Size(188, 24);
            this.toolStripSelectFileTm1.Text = "Select File TM";
            this.toolStripSelectFileTm1.Click += new System.EventHandler(this.toolStripSelectFileTm1_Click);
            // 
            // toolStripSelectServerTm1
            // 
            this.toolStripSelectServerTm1.Name = "toolStripSelectServerTm1";
            this.toolStripSelectServerTm1.Size = new System.Drawing.Size(188, 24);
            this.toolStripSelectServerTm1.Text = "Select Server TM";
            this.toolStripSelectServerTm1.Click += new System.EventHandler(this.toolStripSelectServerTm1_Click);
            // 
            // txtTm1Path
            // 
            this.txtTm1Path.Enabled = false;
            this.txtTm1Path.Location = new System.Drawing.Point(12, 23);
            this.txtTm1Path.Margin = new System.Windows.Forms.Padding(4);
            this.txtTm1Path.Name = "txtTm1Path";
            this.txtTm1Path.Size = new System.Drawing.Size(619, 22);
            this.txtTm1Path.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // groupBoxTm2
            // 
            this.groupBoxTm2.Controls.Add(this.btnSelectTm2);
            this.groupBoxTm2.Controls.Add(this.txtTm2Path);
            this.groupBoxTm2.Controls.Add(this.label1);
            this.groupBoxTm2.Controls.Add(this.comboLanguagePairsTm2);
            this.groupBoxTm2.Location = new System.Drawing.Point(24, 194);
            this.groupBoxTm2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTm2.Name = "groupBoxTm2";
            this.groupBoxTm2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTm2.Size = new System.Drawing.Size(761, 137);
            this.groupBoxTm2.TabIndex = 14;
            this.groupBoxTm2.TabStop = false;
            this.groupBoxTm2.Text = "Select translation memory 2";
            // 
            // btnSelectTm2
            // 
            this.btnSelectTm2.ContextMenuStrip = this.contextMenuTm1;
            this.btnSelectTm2.Location = new System.Drawing.Point(640, 21);
            this.btnSelectTm2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectTm2.Name = "btnSelectTm2";
            this.btnSelectTm2.Size = new System.Drawing.Size(111, 28);
            this.btnSelectTm2.TabIndex = 1;
            this.btnSelectTm2.Text = "Select TM >";
            this.btnSelectTm2.UseVisualStyleBackColor = true;
            this.btnSelectTm2.Click += new System.EventHandler(this.btnSelectTm2_Click);
            // 
            // txtTm2Path
            // 
            this.txtTm2Path.Enabled = false;
            this.txtTm2Path.Location = new System.Drawing.Point(12, 23);
            this.txtTm2Path.Margin = new System.Windows.Forms.Padding(4);
            this.txtTm2Path.Name = "txtTm2Path";
            this.txtTm2Path.Size = new System.Drawing.Size(619, 22);
            this.txtTm2Path.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Language pair:";
            // 
            // comboLanguagePairsTm2
            // 
            this.comboLanguagePairsTm2.FormattingEnabled = true;
            this.comboLanguagePairsTm2.Location = new System.Drawing.Point(12, 84);
            this.comboLanguagePairsTm2.Margin = new System.Windows.Forms.Padding(4);
            this.comboLanguagePairsTm2.Name = "comboLanguagePairsTm2";
            this.comboLanguagePairsTm2.Size = new System.Drawing.Size(455, 24);
            this.comboLanguagePairsTm2.TabIndex = 8;
            this.comboLanguagePairsTm2.SelectedIndexChanged += new System.EventHandler(this.comboLanguagePairsTm2_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(697, 357);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 28);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(602, 356);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 30);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // contextMenuTm2
            // 
            this.contextMenuTm2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuTm2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSelectFileTm2,
            this.toolStripSelectServerTm2});
            this.contextMenuTm2.Name = "contextMenuTm";
            this.contextMenuTm2.Size = new System.Drawing.Size(189, 52);
            // 
            // toolStripSelectFileTm2
            // 
            this.toolStripSelectFileTm2.Name = "toolStripSelectFileTm2";
            this.toolStripSelectFileTm2.Size = new System.Drawing.Size(188, 24);
            this.toolStripSelectFileTm2.Text = "Select File TM";
            this.toolStripSelectFileTm2.Click += new System.EventHandler(this.toolStripSelectFileTm2_Click);
            // 
            // toolStripSelectServerTm2
            // 
            this.toolStripSelectServerTm2.Name = "toolStripSelectServerTm2";
            this.toolStripSelectServerTm2.Size = new System.Drawing.Size(188, 24);
            this.toolStripSelectServerTm2.Text = "Select Server TM";
            this.toolStripSelectServerTm2.Click += new System.EventHandler(this.toolStripSelectServerTm2_Click);
            // 
            // ProviderConfDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(808, 407);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBoxTm2);
            this.Controls.Add(this.groupBoxTm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProviderConfDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.groupBoxTm1.ResumeLayout(false);
            this.groupBoxTm1.PerformLayout();
            this.contextMenuTm1.ResumeLayout(false);
            this.groupBoxTm2.ResumeLayout(false);
            this.groupBoxTm2.PerformLayout();
            this.contextMenuTm2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxTm1;
        private System.Windows.Forms.Button btnSelectTm1;
        public System.Windows.Forms.ComboBox comboLanguagePairsTm1;
        private System.Windows.Forms.ContextMenuStrip contextMenuTm1;
        private System.Windows.Forms.ToolStripMenuItem toolStripSelectFileTm1;
        private System.Windows.Forms.ToolStripMenuItem toolStripSelectServerTm1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.TextBox txtTm1Path;
        private System.Windows.Forms.GroupBox groupBoxTm2;
        private System.Windows.Forms.Button btnSelectTm2;
        public System.Windows.Forms.TextBox txtTm2Path;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboLanguagePairsTm2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuTm2;
        private System.Windows.Forms.ToolStripMenuItem toolStripSelectFileTm2;
        private System.Windows.Forms.ToolStripMenuItem toolStripSelectServerTm2;
    }
}

