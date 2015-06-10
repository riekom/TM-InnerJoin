using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdl.LanguagePlatform.TranslationMemoryApi;
using System.Windows.Forms;

namespace TM_InnerJoin
{
    /// <summary>
    /// This class is used to hold the provider plug-in settings. 
    /// All settings are automatically stored in a URI.
    /// </summary>
    public class TranslationOptions
    {
        #region "TranslationMethod"
        public static readonly TranslationMethod ProviderTranslationMethod = TranslationMethod.Other;
        #endregion

        #region "TranslationProviderUriBuilder"
        TranslationProviderUriBuilder _uriBuilder;

        public TranslationOptions()
        {
            _uriBuilder = new TranslationProviderUriBuilder(TranslationProvider.TranslationProviderScheme);
        }

        public TranslationOptions(Uri uri)
        {
            _uriBuilder = new TranslationProviderUriBuilder(uri);
        }
        #endregion

        #region "session credentials"
        
        private static string usernametm1; //username
        private static string passwordtm1; //password  -- these creds only persist for the session and are never saved to credential store or URI from this class
        private static string usernametm2; //username
        private static string passwordtm2; //password  -- these creds only persist for the session and are never saved to credential store or URI from this class

        /// <summary>
        /// The username for TM 1...not stored in the URI...only persists for the current work session unless saved in the credential store
        /// </summary>
        internal string UsernameTm1
        {
            get { return usernametm1; } //the creds are going to be held in static variables so we don't have to get it from credential store all the time
            set { usernametm1 = value; }
        }

        /// <summary>
        /// The username for TM 2...not stored in the URI...only persists for the current work session unless saved in the credential store
        /// </summary>
        internal string UsernameTm2
        {
            get { return usernametm2; } //the creds are going to be held in static variables so we don't have to get it from credential store all the time
            set { usernametm2 = value; }
        }

        /// <summary>
        /// The password for TM 1...not stored in the URI...only persists for the current work session unless saved in the credential store
        /// </summary>
        internal string PasswordTm1
        {
            get { return passwordtm1; }
            set { passwordtm1 = value; }
        }
        
        /// <summary>
        /// The password for TM 2...not stored in the URI...only persists for the current work session unless saved in the credential store
        /// </summary>
        internal string PasswordTm2
        {
            get { return passwordtm2; }
            set { passwordtm2 = value; }
        }
        #endregion

        /// <summary>
        /// Use this region to set/get provider options to/from the uri saved in the project file.
        /// </summary>
        #region "options"
        public string ServerFullPathTm1
        {
            get { return GetStringParameter("serverfullpathtm1"); }
            set { SetStringParameter("serverfullpathtm1", value); }
        }
        public string ServerFullPathTm2
        {
            get { return GetStringParameter("serverfullpathtm2"); }
            set { SetStringParameter("serverfullpathtm2", value); }
        }
        public string ServerUriTm1
        {
            get { return GetStringParameter("uritm1"); }
            set { SetStringParameter("uritm1", value); }
        }
        public string ServerUriTm2
        {
            get { return GetStringParameter("uritm2"); }
            set { SetStringParameter("uritm2", value); }
        }
        public string NameTm1
        {
            get { return GetStringParameter("nametm1"); }
            set { SetStringParameter("nametm1", value); }
        }
        public string NameTm2
        {
            get { return GetStringParameter("nametm2"); }
            set { SetStringParameter("nametm2", value); }
        }
        public int LangDirIndexTm1
        {
            get 
            {
                if (GetStringParameter("langdirindextm1") != null)
                    return int.Parse(GetStringParameter("langdirindextm1"));
                else return 0;
            }
            set { SetStringParameter("langdirindextm1", value.ToString()); }
        }
        public int LangDirIndexTm2
        {
            get
            {
                if (GetStringParameter("langdirindextm2") != null)
                    return int.Parse(GetStringParameter("langdirindextm2"));
                else return 0;
            }
            set { SetStringParameter("langdirindextm2", value.ToString()); }
        }
        public string LangDirString1
        {
            get { return GetStringParameter("langdirstring1"); }
            set { SetStringParameter("langdirstring1", value); }
        }
        public string LangDirString2
        {
            get { return GetStringParameter("langdirstring2"); }
            set { SetStringParameter("langdirstring2", value); }
        }
        public bool IsServerTm1
        {
            get
            {
                string result = GetStringParameter("isservertm1");
                if (string.IsNullOrEmpty(result)) return false;
                return Boolean.Parse(result);
            }
            set { SetStringParameter("isservertm1", value.ToString()); }
        }
        public bool IsServerTm2
        {
            get 
            {
                string result = GetStringParameter("isservertm2");
                if (string.IsNullOrEmpty(result)) return false;
                return Boolean.Parse(result); 
            }
            set { SetStringParameter("isservertm2", value.ToString()); }
        }
        #endregion

        
        #region "SetStringParameter"
        private void SetStringParameter(string p, string value)
        {
            _uriBuilder[p] = value;
        }
        #endregion

        #region "GetStringParameter"
        private string GetStringParameter(string p)
        {
            string paramString = _uriBuilder[p];
            return paramString;
        }
        #endregion


        #region "Uri"
        public Uri Uri
        {
            get
            {
                return _uriBuilder.Uri;
            }
        }
        #endregion
    }
}
