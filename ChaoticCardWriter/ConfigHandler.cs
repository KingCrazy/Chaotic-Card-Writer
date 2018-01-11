// Copyright 2018 github.com/KingCrazy
// All the config file junk.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaoticCardWriter
{
    class ConfigHandler
    {
        private ConfigFile config;

        public ConfigHandler()
        {
        }
        
        // Loads in the config file.
        // Checks if a default language is listed. If not, we call SetDefaultLanguage.
        public void LoadConfigFile()
        {
            config = JsonIO.ReadConfigFile();
            try
            {
                if (config.defaultLanguage.Trim().Equals(""))
                {
                    //Console.WriteLine("Default language is invalid. Setting default langauge.");
                    SetDefaultLanguage("English");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading config file. Error: {0}", e);
            }
        }

        // Returns the config file's default language.
        public string GetDefaultLanguage()
        {
            return config.defaultLanguage;
        }

        // Sets the config file's default language in memory, and writes it to the config file.
        public void SetDefaultLanguage(string id)
        {
            config.defaultLanguage = id;
            JsonIO.WriteConfigFile(ref config);
        }
    }

    class ConfigFile
    {
        ConfigFile() { }
        public string defaultLanguage = "";
    }
}
