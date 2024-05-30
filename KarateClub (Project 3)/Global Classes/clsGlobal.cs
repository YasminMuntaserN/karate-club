using Karate_Bussiness;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub__Project_3_.Global_Classes
{
    public class clsGlobal
    {
        public static clsUsers CurrentUser;

        public static bool CheckAccessDenied(clsUsers.enPermissions enPermissions)
        {
            if (CurrentUser.Permissions == (int)clsUsers.enPermissions.All)
                return true;


            if (((int)enPermissions & CurrentUser.Permissions) == (int)enPermissions)
                return true;

            else
                return false;

        }

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            // Specify the Registry key and path
            string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\KarateClub";
            string UserNameName = "UserName";
            string PasswordName = "Password";

            try
            {
                // Write the value to the Registry
                Registry.SetValue(keyPath, UserNameName, Username, RegistryValueKind.String);
                Registry.SetValue(keyPath, PasswordName, Password, RegistryValueKind.String);


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            // Specify the Registry key and path
            string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\KarateClub";
            string UserNameName = "UserName";
            string PasswordName = "Password";

            try
            {
                // Read the value from the Registry
                string value = Registry.GetValue(keyPath, UserNameName, null) as string;
                string value2 = Registry.GetValue(keyPath, PasswordName, null) as string;

                if (value == null && value2 == null)
                {
                    return false;
                }
                Username = value;
                Password = value2;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DeleteValueFromRegistry()
        {
            // Specify the registry key path and value name
            string keyPath = @"SOFTWARE\KarateClub";
            string valueName = "UserName";
            string value2Name = "Password";

            try
            {
                // Open the registry key in read/write mode with explicit registry view
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
                    {
                        if (key != null)
                        {
                            // Delete the specified value
                            key.DeleteValue(valueName);
                            key.DeleteValue(value2Name);

                            return true;

                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                return false;

            }
            catch (Exception ex)
            {
                return false;

            }
        }
    }
}
