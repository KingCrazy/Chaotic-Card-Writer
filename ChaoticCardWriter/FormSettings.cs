// Copyright 2018 github.com/KingCrazy
// Handles the settings window.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaoticCardWriter
{
    public partial class FormSettings : Form
    {
        FormMain mainForm;

        public FormSettings(FormMain main)
        {
            InitializeComponent();
            InitializeLanguageBox();
            InitializeLanguage();
            mainForm = main;   
        }

        // Initializes the language dropdown box.
        // Clears the items in the combo box, then re-populates them based on the LocalizationHandler's list.
        // Sets the selected item to the currently selected language.
        private void InitializeLanguageBox()
        {
            Program.localizationHandler.LoadLanguages();
            comboBox_language.Items.Clear();
            if (!Program.language.id.Trim().Equals(""))
            {
                for (int i = 0; i < Program.localizationHandler.languageFiles.Count; i++)
                {
                    comboBox_language.Items.Add(Program.localizationHandler.languageFiles[i].id);
                    Console.WriteLine("Adding language file: {0}", Program.localizationHandler.languageFiles[i].id);
                }
                comboBox_language.SelectedIndex = Program.localizationHandler.GetLanguageFileIndexById(Program.language.id);
            }
        }

        // Localization stoofs.
        private void InitializeLanguage()
        {
            groupBox_language.Text = Program.language.GetValue(LanguageFileConsts.KEY_LABEL_LOCALIZATION);
            button_OK.Text = Program.language.GetValue(LanguageFileConsts.KEY_BUTTON_OK);
            this.Text = string.Format("{0}: {1}", Program.language.GetValue(LanguageFileConsts.KEY_PROGRAM_TITLE), Program.language.GetValue(LanguageFileConsts.KEY_MENU_SETTINGS));
        }

        // Updates the program's overall language, sets the default language, and then closes the window.
        private void button_OK_Click(object sender, EventArgs e)
        {
            Program.configHandler.SetDefaultLanguage(Program.language.id);
            mainForm.UpdateLanguage();
            this.Close();
        }

        private void comboBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ChangeLanguage(comboBox.SelectedIndex);
        }

        // Changes the program's language to the language specified by the given index.
        private void ChangeLanguage(int index)
        {
            Program.language = Program.localizationHandler.languageFiles[index];
            InitializeLanguage();
        }
        
    }
}
