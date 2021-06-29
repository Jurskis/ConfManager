using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ConfManager
{
    public class Program
    {
        public static List<Config> Configs = new();
        static ConfigManagerForm ConfigManagerForm = new();

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Load base config file.
            ParseConfig("../../../config/base/Base_Config.txt");

            // Temporary layer variable to imitate layer level.
            int tmpLayer = 1;

            // Load specific config files.
            foreach (string file in Directory.GetFiles("../../../config/specific"))
            {
                // Trim file path to file name
                ParseConfig(file, tmpLayer++);
            }

            ConfigManagerForm.ShowConfigs(Configs);

            Application.Run(ConfigManagerForm);
        }

        /// <summary>
        /// Read lines from a config file, parse and save found configs.
        /// </summary>
        /// <param name="path">Path of the file to parse.</param>
        /// <param name="layer">The layer level on config.</param>
        public static void ParseConfig(string path, int layer = 0)
        {
            int separatorIndex, configIndex, commentIndex;
            string id, value;
            try
            {
                IEnumerable<string> lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    // Check if this line contains a config.
                    if (line.Contains(":\t"))
                    {
                        // Get the index of the first ':' symbol that separates config ID and value.
                        separatorIndex = line.IndexOf(':');
                        // Get ID.
                        id = line.Substring(0, separatorIndex);

                        // Layers other than base(0) have more logic.
                        if (layer > 0)
                        {
                            // Check if a config with given ID already exists.
                            configIndex = Configs.FindIndex(config => config.Id == id);
                            if (configIndex >= 0)
                            {
                                // Overwrite value if supplied config layer is higher.
                                if (Configs[configIndex].Layer < layer)
                                {
                                    // Check if there is a comment after value and trim if needed.
                                    commentIndex = line.Substring(separatorIndex + 1).IndexOf("//");
                                    value = (commentIndex > 0) ? line.Substring(separatorIndex + 1, commentIndex) : line.Substring(separatorIndex + 1);
                                    Configs[configIndex].Value = value;
                                    Configs[configIndex].Layer = layer;
                                }
                            }
                            else
                            {
                                commentIndex = line.Substring(separatorIndex + 1).IndexOf("//");
                                value = (commentIndex > 0) ? line.Substring(separatorIndex + 1, commentIndex) : line.Substring(separatorIndex + 1);
                                Configs.Add(new Config(id, value, layer)); // Since this is not a base layer config, we need to give the layer value here.
                            }
                        }
                        else
                        {
                            commentIndex = line.Substring(separatorIndex + 1).IndexOf("//");
                            value = (commentIndex > 0) ? line.Substring(separatorIndex + 1, commentIndex) : line.Substring(separatorIndex + 1);
                            Configs.Add(new Config(id, value));
                        }
                    }
                }

                ConfigManagerForm.AddOutput("Read file - " + path.Split('/').Last());
                ConfigManagerForm.AddConfigFile(path.Split('/').Last());
            }
            catch (IOException e)
            {
                ConfigManagerForm.AddOutput("The file could not be read." + e.Message);
            }
        }
    }
}