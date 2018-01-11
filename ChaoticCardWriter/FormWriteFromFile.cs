// Copyright 2018 github.com/KingCrazy
// Handles the write from file window.

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
    public partial class FormWriteFromFile : Form
    {

        private string textFileFilter = "Normal text file|*.txt";
        private FormMain mainForm;
        public FormWriteFromFile(FormMain form)
        {
            InitializeComponent();
            InitializeLanguage();
            comboBox_format.SelectedIndex = 0;
            mainForm = form;
        }

        // Localization stoofs.
        private void InitializeLanguage()
        {
            
            button_source_browse.Text = Program.language.GetValue(LanguageFileConsts.KEY_BUTTON_BROWSE);
            button_destination_folder_browse.Text = Program.language.GetValue(LanguageFileConsts.KEY_BUTTON_BROWSE);
            button_stats_file_browse.Text = Program.language.GetValue(LanguageFileConsts.KEY_BUTTON_BROWSE);

            button_Done.Text = Program.language.GetValue(LanguageFileConsts.KEY_BUTTON_DONE);
            button_write.Text = Program.language.GetValue(LanguageFileConsts.KEY_BUTTON_WRITE);

            label_static_counting.Text = Program.language.GetValue(LanguageFileConsts.KEY_LABEL_CARD_WRITER_COUNTER);
            label_static_format.Text = Program.language.GetValue(LanguageFileConsts.KEY_LABEL_FORMAT);

            label_static_destination.Text = Program.language.GetValue(LanguageFileConsts.KEY_DESC_DESTINATION_FOLDER);
            label_static_source.Text = Program.language.GetValue(LanguageFileConsts.KEY_DESC_SOURCE_FOLDER);
            label_static_destination.Text = Program.language.GetValue(LanguageFileConsts.KEY_DESC_DESTINATION_FOLDER);

            groupBox_destination.Text = Program.language.GetValue(LanguageFileConsts.KEY_LABEL_DESTINATION_FOLDER);
            groupBox_source.Text = Program.language.GetValue(LanguageFileConsts.KEY_LABEL_SOURCE_FOLDER);
            groupBox_stats.Text = Program.language.GetValue(LanguageFileConsts.KEY_LABEL_STATS_FILE);

        }

        // Handles the browsing dialog for the stats file.
        private void button_stats_file_browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = textFileFilter;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_stats_file.Text = openFileDialog1.FileName;
            }
            openFileDialog1.Dispose();
        }

        // Begins the mass-file writing.
        // Checks if the path is empty. If not, we'll set the extension and format. Then we'll call CardIO to do the heavy lifting.
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (!EmptyPath())
            {
                string ext = "png";
                System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;
                switch (comboBox_format.SelectedIndex)
                {
                    case 0:
                        ext = "png";
                        format = System.Drawing.Imaging.ImageFormat.Png;
                        break;
                    case 1:
                        ext = "jpg";
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    case 2:
                        ext = "bmp";
                        format = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                    default:
                        break;
                }


                CardIO.MultiWriteFiles(textBox_stats_file.Text, textBox_source_folder.Text, textBox_destination_folder.Text, textBox_counting.Text, ext, mainForm.GetStatLabels(),format);
            } else
            {
                MessageBox.Show(Program.language.GetValue(LanguageFileConsts.KEY_WARN_STATS_PATH_EMPTY), Program.language.GetValue(LanguageFileConsts.KEY_LABEL_WARNING));
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_destination_folder_browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_destination_folder.Text = folderBrowserDialog1.SelectedPath;
            }
            folderBrowserDialog1.Dispose();
        }

        private void button_source_browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_source_folder.Text = folderBrowserDialog1.SelectedPath;
            }
            folderBrowserDialog1.Dispose();
        }

        private void textBox_counting_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!FormMain.CheckIfNumericalValue(textBox.Text))
            {
                textBox.Text = "0";
            }
        }

        // Checks if any of the three textboxes are empty. Returns true if it's found an empty path.
        private bool EmptyPath()
        {
            return (textBox_stats_file.Text.Trim().Equals("") || textBox_source_folder.Text.Trim().Equals("") || textBox_destination_folder.Text.Trim().Equals(""));
        }
    }
}
