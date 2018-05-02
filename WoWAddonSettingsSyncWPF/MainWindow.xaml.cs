using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WoWAddonSettingsSyncWPF
{
    public partial class MainWindow : Window
    {
        private string _WoWPath;
        private List<string> _accountsList = new List<string>();
        private List<string> _accountsPathsList = new List<string>();
        private Dictionary<string, List<string>> _characterDictionary = new Dictionary<string, List<string>>();

        public MainWindow()
        {
            InitializeComponent();
            TryFindWoWPath();
        }

        private void TryFindWoWPath()
        {
            if (Directory.Exists(@"C:\Program Files (x86)\World of Warcraft\WTF\Account"))
            {
                _WoWPath = @"C:\Program Files (x86)\World of Warcraft\WTF\Account";
                FindAccounts();
            }
            else
            {
                // TODO - alert user that path was not automatically found
            }
        }

        private void FindAccounts()
        {
            foreach (var dir in Directory.GetDirectories(_WoWPath))
            {
                var d = new DirectoryInfo(dir);
                if (!d.Name.Contains("SavedVariables"))
                {
                    _accountsList.Add(d.Name);
                    _accountsPathsList.Add(dir);
                }
            }

            //debug
            Console.WriteLine("PATH\n" + _WoWPath + "\nACCOUNTS");
            foreach (var v in _accountsPathsList)
            {
                Console.WriteLine(v);
            }

            FindCharacters(_accountsPathsList);
        }

        private void FindCharacters(List<string> pathsList)
        {
            foreach (var path in pathsList) //acc
            {
                foreach (var dir in Directory.GetDirectories(path)) //realm
                {
                    var dirInfo = new DirectoryInfo(dir);
                    if (!dirInfo.Name.Contains("SavedVariables"))
                    {
                        foreach (var characterDir in Directory.GetDirectories(dirInfo.FullName)) //character
                        {
                            Console.WriteLine(characterDir);
                        }
                    }
                }
            }
        }
    }
}
