using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdl.LanguagePlatform.Core;
using Sdl.LanguagePlatform.TranslationMemory;
using Sdl.LanguagePlatform.TranslationMemoryApi;


namespace TM_InnerJoin
{
    /// <summary>
    /// Holds a set of string credentials and a boolean specifying whether the credentials are set to persist in the store
    /// </summary>
    public class UnencryptedCredentials
    {
        /// <summary>
        /// Constructs using username and password string, alond with boolean for persistence
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="persist">Whether the credentials are set to persist in the credential store.</param>
        public UnencryptedCredentials(string username, string password, bool persist)
        {
            Username = username;
            Password = password;
            Persist = persist;
        }
        public string Username;
        public string Password;
        public bool Persist;
    }
    /// <summary>
    /// Provides methods for getting and saving from/to SDL credential store
    /// </summary>
    public class TranslationProviderCredentialHelper
    {
        ITranslationProviderCredentialStore credStore;
        /// <summary>
        /// Constructs an instance of the helper. Requires a credential store object.
        /// </summary>
        /// <param name="credentialStore">An instance of the credential store object.</param>
        public TranslationProviderCredentialHelper(ITranslationProviderCredentialStore credentialStore)
        {
            credStore = credentialStore;
        }
        
        /// <summary>
        /// Gets credentials from the credential store for a give uri. Returns null if they don't exist.
        /// </summary>
        /// <param name="uri">The uri to search</param>
        /// <returns>An object of the <c>UnencryptedCredentials</c> type, or null if the credentials do not exist.</returns>
        public UnencryptedCredentials GetDecryptedCredentials(string uri)
        {

            string username = string.Empty;
            string password = string.Empty;
            bool persist = false;
            TranslationProviderCredential getCred = getCredentials(uri);
            if (getCred != null)
            {
                try
                {
                    GenericCredentials creds = new GenericCredentials(getCred.Credential); //parse credential into username and password
                    username = creds.UserName;
                    password = creds.Password;
                    persist = getCred.Persist;
                }
                catch
                {
                    return null;
                }
            }
            UnencryptedCredentials result = new UnencryptedCredentials(username, password, persist);
            return result;
        }

        /// <summary>
        /// Deletes the credentials for the uri. Returns true if they exist and false otherwise.
        /// </summary>
        /// <param name="uri">The uri of the credentials to delete.</param>
        /// <returns>Returns true if the credentials exist, and are therefore deleted, and false otherwise.</returns>
        public bool DeleteCredentials(string uri)
        {
            try
            {
                getCredentials(uri);
            }
            catch
            {
                return false;
            }
            credStore.RemoveCredential(new Uri(uri));
            return true;
        }
        
        /// <summary>
        /// Saves credentials as encrypted to the credential store.
        /// </summary>
        /// <param name="credentials">An instance of the <c>UnencryptedCredentials</c> object to encrypt and store.</param>
        /// <param name="uri">The uri of the credentials to save as encrypted.</param>
        /// <returns>True if successful and false if there is any error.</returns>
        public bool SaveEncryptedCredentials(UnencryptedCredentials credentials, string uri)
        {
            //set cred
            try
            {
                GenericCredentials gcreds = new GenericCredentials(credentials.Username, credentials.Password);
                setCredentials(uri, gcreds, credentials.Persist);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private TranslationProviderCredential getCredentials(string uri)
        {
            Uri myUri = new Uri(uri);
            TranslationProviderCredential cred = null;

            if (credStore.GetCredential(myUri) != null)
            {

                //get the credential to return
                cred = new TranslationProviderCredential(credStore.GetCredential(myUri).Credential, credStore.GetCredential(myUri).Persist);
            }

            return cred;

        }

        private void setCredentials(string uri, GenericCredentials creds, bool persistCred)
        { //used to set credentials
            // we are only setting and getting credentials for the uri with no parameters...kind of like a master credential
            Uri myUri = new Uri(uri);

            TranslationProviderCredential cred = new TranslationProviderCredential(creds.ToCredentialString(), persistCred);
            credStore.RemoveCredential(myUri);
            credStore.AddCredential(myUri, cred);


        }

    }
}
