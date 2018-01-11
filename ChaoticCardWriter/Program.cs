using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaoticCardWriter
{
    static class Program
    {
        public static ConfigHandler configHandler;
        public static LangFileObject language;
        public static LocalizationHandler localizationHandler;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize our handlers and necessary stuff.
            language = new LangFileObject();
            localizationHandler = new LocalizationHandler(); // Loads the language files on construction
            configHandler = new ConfigHandler();

            // Load the config file.
            configHandler.LoadConfigFile();
            // Load the default language based on the config file loaded in.
            localizationHandler.LoadDefaultLanguage(configHandler.GetDefaultLanguage());
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        
    }
}
