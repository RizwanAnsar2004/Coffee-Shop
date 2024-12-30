using System;
using ProjectSDA.Models;

namespace ProjectSDA
{
    public sealed class AdminLoginManager
    {
        private static readonly Lazy<AdminLoginManager> instance = new Lazy<AdminLoginManager>(() => new AdminLoginManager());

        private bool isLoggedIn = false;
        private string currentAdminUsername;

        private AdminLoginManager() { }

        public static AdminLoginManager Instance
        {
            get { return instance.Value; }
        }

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            private set { isLoggedIn = value; }
        }

        public string CurrentAdminUsername
        {
            get { return currentAdminUsername; }
            private set { currentAdminUsername = value; }
        }

        public bool Login(Admin_Profile admin)
        {
            if (!isLoggedIn)
            {
                isLoggedIn = true;
                currentAdminUsername = admin.Admin_Username;
                return true;
            }
            return false;
        }

        public void Logout()
        {
            isLoggedIn = false;
            currentAdminUsername = null;
        }
    }
}
