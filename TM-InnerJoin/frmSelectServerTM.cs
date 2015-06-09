using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sdl.LanguagePlatform.TranslationMemoryApi;
using Sdl.LanguagePlatform.TranslationMemory;
using Sdl.LanguagePlatform.Core.Tokenization;
using Sdl.LanguagePlatform.Core;

namespace TM_InnerJoin
{
    public partial class frmSelectServerTM : Form
    {
        private string uri;

        public frmSelectServerTM(string uriString=null)
        {
            this.uri = uriString;
            InitializeComponent();
            UpdateDialog();
        }

        public void UpdateDialog()
        {
            if(!string.IsNullOrEmpty(uri))
            {
                txtServerUri.Text = uri;
            }
        }

        #region "cancel"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


         


        #region "connect"
        // By clicking the Connect button you establish a connectionw with the TM
        // Server. This will fill populate the dropdown list with the names of the
        // server TMs and enable the list, which is by default disabled.
        // Moreover, the OK button gets enabled.
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connector connection = new Connector();
            connection.Connect(this.txtServerUri.Text, this.txtUserName.Text, 
                this.txtPassword.Text, this.comboServerTMs);
            
            this.btnOK.Enabled = true;
        }
        #endregion



        #region "ok"
        private void btnOK_Click(object sender, EventArgs e)
        {

            // close form with dialog result ok
            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion 

        private void frmSelectTM_Load(object sender, EventArgs e)
        {

        }

        

  




  
    }
}
