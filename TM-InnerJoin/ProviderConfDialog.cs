using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TM_InnerJoin
{
    public partial class ProviderConfDialog : Form
    {

        public TranslationOptions Options;
        #region "initialize"
        // Initialize form with default search settings.
        public ProviderConfDialog(TranslationOptions options)
        {
            Options = options;
            InitializeComponent();
            UpdateDialog();
            
        }
        #endregion

        /// <summary>
        /// Update the dialog with values from options if they are set
        /// </summary>
        private void UpdateDialog()
        {
            //TODO: if saving/storing of credentials is added, try getting them if the ones in the options are blank, and load them into the form if they exist

            txtTm1Path.Text = Options.ServerFullPathTm1;
            txtTm2Path.Text = Options.ServerFullPathTm2;
            comboLanguagePairsTm1.Text = Options.LangDirString1;
            comboLanguagePairsTm2.Text = Options.LangDirString2;
            //TODO: for both TMs, if it's server based...try a lookup to refresh the list and select the one that was previously selected
            if(Options.IsServerTm1)
            {
                //TODO: do a connect to get list and select based on index.....but only if the options have already been set...or maybe just add a refresh button instead of doing it on forom load
            }
            if (Options.IsServerTm2)
            {
                //TODO: do a connect to get list and select based on index.....but only if the options have already been set...or maybe just add a refresh button instead of doing it on forom load
            }
        }
       
        #region "btnSelectTm_Click"
        private void btnSelectTm1_Click(object sender, EventArgs e)
        {
            contextMenuTm1.Show(btnSelectTm1, new Point(0, 20));
        }
        private void btnSelectTm2_Click(object sender, EventArgs e)
        {
            contextMenuTm2.Show(btnSelectTm2, new Point(0, 20));
        }
        #endregion



        #region "SelectFileTm"
        private void toolStripSelectFileTm1_Click(object sender, EventArgs e)
        {
            LoadFileTm(txtTm1Path, comboLanguagePairsTm1, 1);
        }
        private void toolStripSelectFileTm2_Click(object sender, EventArgs e)
        {
            LoadFileTm(txtTm2Path, comboLanguagePairsTm2, 2);
        }

        private void LoadFileTm(TextBox txtTmPath, ComboBox comboLangPairs, int tmNumber)
        {
            // Raise open file dialog.
            this.openFileDialog.Title = "Select Translation Memory File";
            this.openFileDialog.Filter = "Translation memories (*.sdltm)|*.sdltm";

            // Check whether an *.sdltm file was selected
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a new connector object to connect to the file TM
                Connector fileConnect = new Connector();
                string tmFilename = this.openFileDialog.FileName;
                fileConnect.SelectFileTm(tmFilename);
                txtTmPath.Text = tmFilename;

                // File TMs have only one language direction, which is filled into the 
                // language pair list.
                string srcLang = Connector.fileTm.LanguageDirection.SourceLanguage.DisplayName.ToString();
                string trgLang = Connector.fileTm.LanguageDirection.TargetLanguage.DisplayName.ToString();

                comboLangPairs.Items.Clear();
                comboLangPairs.Text = srcLang + " -> " + trgLang;
                if(tmNumber==1)
                {
                    Options.IsServerTm1 = false;
                    Options.NameTm1 = null; //TODO: null options values when not used???
                    Options.ServerUriTm1 = tmFilename;
                    Options.UsernameTm1 = null;
                    Options.PasswordTm1 = null;
                }
                else
                {
                    Options.IsServerTm2 = false;
                    Options.NameTm2 = null; //TODO: null options values when not used???
                    Options.ServerUriTm2 = tmFilename;
                    Options.UsernameTm2 = null;
                    Options.PasswordTm2 = null;
                }
            }
        }
        #endregion

        #region "RaiseServerTmForm"
        private void toolStripSelectServerTm1_Click(object sender, EventArgs e)
        {
            LoadServerTm(txtTm1Path, comboLanguagePairsTm1, 1, Options.ServerUriTm1);
        }
        private void toolStripSelectServerTm2_Click(object sender, EventArgs e)
        {
            LoadServerTm(txtTm2Path, comboLanguagePairsTm2, 2, Options.ServerUriTm2);
        }
        private void LoadServerTm(TextBox txtTmPath, ComboBox comboLangPairs, int tmNumber, string uri)
        {
            frmSelectServerTM selectTm = new frmSelectServerTM(uri);
            selectTm.ShowDialog(this);
            if(selectTm.DialogResult == DialogResult.OK)
            {
                // Establish a connection to the TM Server.
                Connector connect = new Connector();

                //need to set options here for username, etc...
                //TODO: if we add storing/retrieving of credentials, then need to save credentials to the store...possibly here...or do it with save/delete button/s in the child form
                if(tmNumber==1)
                {
                    Options.IsServerTm1 = true;
                    Options.NameTm1 = selectTm.comboServerTMs.Text;
                    Options.ServerUriTm1 = selectTm.txtServerUri.Text;
                    Options.UsernameTm1 = selectTm.txtUserName.Text;
                    Options.PasswordTm1 = selectTm.txtPassword.Text;
                }
                else
                {
                    Options.IsServerTm2 = true;
                    Options.NameTm2 = selectTm.comboServerTMs.Text;
                    Options.ServerUriTm2 = selectTm.txtServerUri.Text;
                    Options.UsernameTm2 = selectTm.txtUserName.Text;
                    Options.PasswordTm2 = selectTm.txtPassword.Text;
                }

                connect.SelectServerTm(selectTm.comboServerTMs.Text, selectTm.txtServerUri.Text,
                        selectTm.txtUserName.Text, selectTm.txtPassword.Text);
                txtTmPath.Text = Connector.serverTM.Uri.ToString();

                // Loop through the available language directions of the selected TM and fill them
                // into the corresponding list in the main application form.
                comboLangPairs.Items.Clear();
                for (int i = 0; i < Connector.serverTM.LanguageDirections.Count; i++)
                {
                    string srcLang = Connector.serverTM.LanguageDirections[i].SourceLanguage.DisplayName;
                    string trgLang = Connector.serverTM.LanguageDirections[i].TargetLanguage.DisplayName;
                    comboLangPairs.Items.Add(srcLang + " -> " + trgLang);
                }

                // Select the first available language direction.
                string currentSrcLang = Connector.serverTM.LanguageDirections[0].SourceLanguage.DisplayName;
                string currentTrgLang = Connector.serverTM.LanguageDirections[0].TargetLanguage.DisplayName;
                comboLangPairs.Text = currentSrcLang + " -> " + currentTrgLang;


            }
        }
        #endregion

        
        private void btnOK_Click(object sender, EventArgs e)
        {
            //TODO: validate to check whether all necessary options have been set before clicking ok in the form

            //set any options that haven't been set already
            Options.LangDirString1 = comboLanguagePairsTm1.Text;
            Options.LangDirString2 = comboLanguagePairsTm2.Text;
            Options.ServerFullPathTm1 = txtTm1Path.Text;
            Options.ServerFullPathTm2 = txtTm2Path.Text;


            // close form with dialog result ok
            DialogResult = DialogResult.OK;
            Close();
        }

        private void comboLanguagePairsTm1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Options.LangDirIndexTm1 = comboLanguagePairsTm1.SelectedIndex; //set the selected language index in the options
        }

        private void comboLanguagePairsTm2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Options.LangDirIndexTm2 = comboLanguagePairsTm2.SelectedIndex; //set the selected language index in the options
        }

        
        

    }
}
