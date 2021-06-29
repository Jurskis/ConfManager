using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConfManager
{
    public partial class ConfigManagerForm : Form
    {
        public ConfigManagerForm()
        {
            InitializeComponent();
        }

        // Add an entry to the output window.
        public void AddOutput(string msg)
        {
            rtb_outputWindow.AppendText("[" + DateTime.Now + "] : " + msg + "\n\n");
        }

        // Show given config(s) in config window.
        public void ShowConfigs(List<Config> configs)
        {
            lv_configsWindow.Items.Clear();
            foreach(Config config in configs)
            {
                lv_configsWindow.Items.Add(new ListViewItem(new[] { config.Id, config.Value }));
            }
        }

        // Add a config file to config file window
        public void AddConfigFile(string file)
        {
            if (!lb_configFilesWindow.Items.Contains(file))
                lb_configFilesWindow.Items.Add(file);
        }

        private void btn_showAllConfigs_Click(object sender, EventArgs e)
        {
            ShowConfigs(Program.Configs);
        }

        private void btn_searchConfig_Click(object sender, EventArgs e)
        {
            string input = tb_config.Text;
            if(input != "")
            {
                List<Config> searchConfigs = Program.Configs.FindAll(config => config.Id == input);

                if (searchConfigs.Count == 0)
                    AddOutput("No config with this name found.");

                ShowConfigs(searchConfigs);
            }
            else
                AddOutput("Search input field empty.");
        }
    }
}
