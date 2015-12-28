using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfProject
{
    class Class
    {
        DateTime datetimeNow = DateTime.Now;
        int trialDays = 15;


        public Class()
        {
            
            DateTime creationTime = File.GetCreationTime(Write.path);
            DateTime lastWriteTime = File.GetLastWriteTime(Write.path);
            DateTime lastAccessTime = File.GetLastAccessTime(Write.path);
            DirectoryInfo info = new DirectoryInfo(@"C:\Windows");
            DateTime window =info.LastWriteTime;
           // System.DateTime
            ;
          //  CheckRegistry();
        }
        private void CheckRegistry()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            if(key.OpenSubKey("BedmintonWatcher")==null)
            {//pridaj systemovy cas
                key.CreateSubKey("BedmintonWatcher");
                key = key.OpenSubKey("BedmintonWatcher", true);

                key.CreateSubKey("1.0.0");
                key = key.OpenSubKey("1.0.0", true);
                key.SetValue("Date", datetimeNow);
            }
            else
            {
                //preverenie datumu
                key = key.OpenSubKey("BedmintonWatcher", false);
                key = key.OpenSubKey("1.0.0", false);
               DateTime installDate=Convert.ToDateTime( key.GetValue("Date"));
                DateTime expired = installDate.Date.AddDays(trialDays);
              /*  if(!(installDate<datetimeNow && datetimeNow<expired))
                {
                    //PLATNY TRIAL
                    MessageBox.Show("Skúšobná verzia skončila. Kontaktujte autora na sasa303@gmail.com", "VPiciError" , MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    Application.Current.Shutdown();
                }*/
            }
            ;
        }
    }
}
