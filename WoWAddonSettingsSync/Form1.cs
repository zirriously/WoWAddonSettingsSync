using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWAddonSettingsSync
{
    public partial class Form1 : Form
    {
        private string path;

        public Form1()
        {
            InitializeComponent();
            TryFindWoWDirectory();
        }

        private void TryFindWoWDirectory()
        {
            //Will try to find the full path - if more than 1 WoW account is found, ask the user. If none is found, proceed as normal

            if (Directory.Exists(@"C:\Program Files (x86)\World of Warcraft\WTF\Account"))
            {
                int folderCount = System.IO.Directory
                    .GetDirectories(@"C:\Program Files (x86)\World of Warcraft\WTF\Account").Length;
                if (folderCount > 2)
                {
                    MessageBox.Show(
                        System.IO.Directory.GetDirectories(@"C:\Program Files (x86)\World of Warcraft\WTF\Account")[0]);
                }
                MessageBox.Show(folderCount.ToString());
            }
        }
    }
}
