// Copyright 2018 github.com/KingCrazy
// This is where most of the action happens. This is the main screen for the application.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ChaoticCardWriter
{
    public partial class FormMain : Form
    {
        // Not really necessary. Just shortens typing a little.
        LangFileObject language;

        private string currentCard = "";

        // Event handlers
        private EventHandler textChangedEvent;
        private EventHandler fontChangedEvent;
        private EventHandler adjustButtonEvent;
        private EventHandler resetButtonEvent;

        // Defaults
        private Font defaultStatFont;
        private Font defaultEnergyFont;
        private Point[] defaultStatCoordinates = new Point[5];

        public FormMain()
        {
            InitializeComponent();

            InitializeTextChangedEvent();
            InitializeFontChangedEvent();
            InitializeAdjustButtonEvent();
            InitializeResetButtonEvent();

            InitializeDefaults();

            language = Program.language;

            if (!language.id.Equals("default"))
            {
                InitializeLanguage();
            }

            ChangeLabelVisibility(false);

            openFileDialog.Filter = "Image Files|*.png";
            openFileDialog.Title = "Load Card Image";

            saveFileDialog.Filter = "png|*.png";
        }

        // Initializes the default fonts and stat label coordinates
        private void InitializeDefaults()
        {

            defaultStatFont = label_stat_courage.Font;
            defaultEnergyFont = label_stat_energy.Font;

            Point tempCoord;
            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        tempCoord = label_stat_courage.Location;
                        break;
                    case 1:
                        tempCoord = label_stat_power.Location;
                        break;
                    case 2:
                        tempCoord = label_stat_wisdom.Location;
                        break;
                    case 3:
                        tempCoord = label_stat_speed.Location;
                        break;
                    case 4:
                        tempCoord = label_stat_energy.Location;
                        break;
                    default:
                        tempCoord = Point.Empty;
                        break;
                }
                defaultStatCoordinates[i] = tempCoord;
            }

            tempCoord = Point.Empty;
        }

        // Localization stoofs
        private void InitializeLanguage()
        {
            label_courage_static.Text = language.GetValue(LanguageFileConsts.KEY_LABEL_COURAGE);
            label_power_static.Text = language.GetValue(LanguageFileConsts.KEY_LABEL_POWER);
            label_wisdom_static.Text = language.GetValue(LanguageFileConsts.KEY_LABEL_WISDOM);
            label_speed_static.Text = language.GetValue(LanguageFileConsts.KEY_LABEL_SPEED);
            label_energy_static.Text = language.GetValue(LanguageFileConsts.KEY_LABEL_ENERGY);

            button_courage_adjust.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_ADJUST);
            button_power_adjust.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_ADJUST);
            button_wisdom_adjust.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_ADJUST);
            button_speed_adjust.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_ADJUST);
            button_energy_adjust.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_ADJUST);

            button_courage_font.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_FONT);
            button_power_font.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_FONT);
            button_wisdom_font.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_FONT);
            button_speed_font.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_FONT);
            button_energy_font.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_FONT);

            button_courage_reset.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_RESET);
            button_power_reset.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_RESET);
            button_wisdom_reset.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_RESET);
            button_speed_reset.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_RESET);
            button_energy_reset.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_RESET);

            button_resetAll.Text = language.GetValue(LanguageFileConsts.KEY_BUTTON_RESET_ALL);

            fileToolStripMenuItem.Text = language.GetValue(LanguageFileConsts.KEY_MENU_FILE);
            writeFromFileToolStripMenuItem.Text = language.GetValue(LanguageFileConsts.KEY_MENU_WRITE_FROM_FILE);
            loadImageToolStripMenuItem.Text = language.GetValue(LanguageFileConsts.KEY_MENU_LOAD_IMAGE);
            saveAsToolStripMenuItem.Text = language.GetValue(LanguageFileConsts.KEY_MENU_SAVE_AS);

            aboutToolStripMenuItem.Text = language.GetValue(LanguageFileConsts.KEY_MENU_ABOUT);
            settingsToolStripMenuItem.Text = language.GetValue(LanguageFileConsts.KEY_MENU_SETTINGS);
            versionToolStripMenuItem.Text = string.Format("{0} {1}", language.GetValue(LanguageFileConsts.KEY_LABEL_VERSION), System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());

            this.Text = Program.language.GetValue(LanguageFileConsts.KEY_PROGRAM_TITLE);
        }


        // Setting up the TextChanged event handler.
        private void InitializeTextChangedEvent()
        {
            textChangedEvent = new EventHandler(TextChangedEvent_TextChanged);
            textBox_courage.TextChanged += textChangedEvent;
            textBox_power.TextChanged += textChangedEvent;
            textBox_wisdom.TextChanged += textChangedEvent;
            textBox_speed.TextChanged += textChangedEvent;
            textBox_energy.TextChanged += textChangedEvent;
        }

        // Setting up the FontChanged event handler.
        private void InitializeFontChangedEvent()
        {
            fontChangedEvent = new EventHandler(FontChangedEvent_FontChanged);
            button_courage_font.Click += fontChangedEvent;
            button_power_font.Click += fontChangedEvent;
            button_wisdom_font.Click += fontChangedEvent;
            button_speed_font.Click += fontChangedEvent;
            button_energy_font.Click += fontChangedEvent;
        }

        // Setting up the AdjustButton event handler.
        private void InitializeAdjustButtonEvent()
        {
            adjustButtonEvent = new EventHandler(AdjustButton_Click);
            button_courage_adjust.Click += adjustButtonEvent;
            button_power_adjust.Click += adjustButtonEvent;
            button_wisdom_adjust.Click += adjustButtonEvent;
            button_speed_adjust.Click += adjustButtonEvent;
            button_energy_adjust.Click += adjustButtonEvent;
        }
        
        // Setting up the ResetButton event handler.
        private void InitializeResetButtonEvent()
        {
            resetButtonEvent = new EventHandler(ResetButton_Click);
            button_courage_reset.Click += resetButtonEvent;
            button_power_reset.Click += resetButtonEvent;
            button_wisdom_reset.Click += resetButtonEvent;
            button_speed_reset.Click += resetButtonEvent;
            button_energy_reset.Click += resetButtonEvent;
        }

        // Handles the changing of visibility of all stat labels.
        private void ChangeLabelVisibility(bool value)
        {
            label_stat_courage.Visible = value;
            label_stat_power.Visible = value;
            label_stat_wisdom.Visible = value;
            label_stat_speed.Visible = value;
            label_stat_energy.Visible = value;
        }

        // Resets the given stat label to the defaults.
        private void ResetStat(Label label, TextBox textBox, Point point)
        {
            Size tempSize = new Size(32, 20);
            label.Location = point;
            if (label.Name.Equals("label_stat_energy"))
            {
                label.Font = defaultEnergyFont;
                tempSize = new Size(48, 25);
            }
            else
                label.Font = defaultStatFont;
            label.Size = tempSize;
            textBox.Text = "0";
        }

        // Resets all stat labels.
        private void ResetAllStats()
        {
            Label tempLabel;
            TextBox tempTextBox;
            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        tempLabel = label_stat_courage;
                        tempTextBox = textBox_courage;
                        break;
                    case 1:
                        tempLabel = label_stat_power;
                        tempTextBox = textBox_power;
                        break;
                    case 2:
                        tempLabel = label_stat_wisdom;
                        tempTextBox = textBox_wisdom;
                        break;
                    case 3:
                        tempLabel = label_stat_speed;
                        tempTextBox = textBox_speed;
                        break;
                    case 4:
                        tempLabel = label_stat_energy;
                        tempTextBox = textBox_energy;
                        break;
                    default:
                        tempLabel = label_stat_courage;
                        tempTextBox = textBox_courage;
                        break;
                }
                ResetStat(tempLabel, tempTextBox, defaultStatCoordinates[i]);
            }
            tempLabel = null;
            tempTextBox = null;
        }

        // Handles the status strip coordinates when mousing over the image.
        private void pictureBox_card_MouseHover(object sender, EventArgs e)
        {
            Point mousePos = PointToClient(System.Windows.Forms.Cursor.Position);
            toolStripStatusLabel1.Text = String.Format("X: {0} Y: {1}", mousePos.X - pictureBox_card.Location.X - panel2.Location.X - 1, mousePos.Y - pictureBox_card.Location.Y - panel2.Location.Y - 1);
        }

        // Handles the "Load Image" menu bar option.
        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                currentCard = openFileDialog.FileName;
                pictureBox_card.Load(currentCard);
                ChangeLabelVisibility(true);
            }
            openFileDialog.Dispose();
        }

        // Handles the save dialogue for saving the cards.
        private void SaveCardImage()
        {

            if (currentCard.Length > 0)
            {
                ImageFormat format = ImageFormat.Png;
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string extension = System.IO.Path.GetExtension(saveFileDialog.FileName);
                    switch (extension)
                    {
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                        default:
                            format = ImageFormat.Png;
                            break;
                    }
                    if (currentCard.Equals(saveFileDialog.FileName))
                    {
                        MessageBox.Show("Cannot override current file.","Warning!");
                        return;
                    } else 
                        CardIO.WriteCard(pictureBox_card.Image, GetStatLabels()).Save(saveFileDialog.FileName, format);
                }
            } else
            {
                MessageBox.Show("No image loaded.","Warning!");
                return;
            }
        }

        // Handles the "Save As" menu bar option.
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCardImage();
        }
        
        // Handles the TextChanged event.
        private void TextChangedEvent_TextChanged(object sender, EventArgs e)
        {
            Label label;
            TextBox textBox = sender as TextBox;
            string tempVal = "";
            switch (textBox.Name)
            {
                case "textBox_courage":
                    label = label_stat_courage;
                    break;
                case "textBox_power":
                    label = label_stat_power;
                    break;
                case "textBox_wisdom":
                    label = label_stat_wisdom;
                    break;
                case "textBox_speed":
                    label = label_stat_speed;
                    break;
                case "textBox_energy":
                    label = label_stat_energy;
                    break;
                default:
                    label = label_stat_courage;
                    break;
            }
            tempVal = label.Text;
            if (!CheckIfNumericalValue(textBox.Text))
            {
                textBox.Text = tempVal;
            } else
            {
                tempVal = "";
            }
            label.Text = textBox.Text;
            label = null;
            textBox = null;
        }

        // Checks if a string is purely a numerical value.
        // Returns true if string is a purely numerical value, returns false otherwise.
        public static bool CheckIfNumericalValue(string text)
        {
            int code;
            return int.TryParse(text, out code);
        }

        // Handles the FontChanged event.
        private void FontChangedEvent_FontChanged(object sender, EventArgs e)
        {
            Button obj = sender as Button;
            Font font;
            Label stat;
            SizeF test;
            switch (obj.Name)
            {
                case "button_courage_font":
                    stat = label_stat_courage;
                    break;
                case "button_power_font":
                    stat = label_stat_power;
                    break;
                case "button_wisdom_font":
                    stat = label_stat_wisdom;
                    break;
                case "button_speed_font":
                    stat = label_stat_speed;
                    break;
                case "button_energy_font":
                    stat = label_stat_energy;
                    break;
                default:
                    stat = label_stat_courage;
                    break;
            }
            
            fontDialog.Font = stat.Font;

            if (fontDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                font = fontDialog.Font;
                stat.Font = font;

            }
            Graphics g = Graphics.FromImage(pictureBox_card.Image);
            test = g.MeasureString(stat.Text, stat.Font);

            if (stat.Width != test.Width)
                stat.Width = (int)Math.Floor(test.Width);

            if (stat.Height != test.Height)
                stat.Height = (int)Math.Floor(test.Height);

            obj = null;
            font = null;
            stat = null;
            
        }

        // Updates the coordinates of a given label to the given coordinates.
        // Used in FormCoordAdjust
        public void UpdateCoordinatesOfLabel(Label label, Point coords)
        {
            label.Location = coords;
        }

        // Handles the AdjustButton event.
        private void AdjustButton_Click(object sender, EventArgs e)
        {
            Button obj = sender as Button;
            Label labelToSend;
            switch (obj.Name)
            {
                case "button_courage_adjust":
                    labelToSend = label_stat_courage;
                    break;
                case "button_power_adjust":
                    labelToSend = label_stat_power;
                    break;
                case "button_wisdom_adjust":
                    labelToSend = label_stat_wisdom;
                    break;
                case "button_speed_adjust":
                    labelToSend = label_stat_speed;
                    break;
                case "button_energy_adjust":
                    labelToSend = label_stat_energy;
                    break;
                default:
                    labelToSend = label_stat_courage;
                    break;
            }
            new FormCoordAdjust(this, ref labelToSend).Show();

            obj = null;
        }

        // Handles the "Write From File" menu bar button.
        private void writeFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormWriteFromFile(this).Show();
        }
        
        // Handles the reset button event.
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Button obj = sender as Button;
            
            switch (obj.Name)
            {
                case "button_courage_reset":
                    ResetStat(label_stat_courage, textBox_courage, defaultStatCoordinates[0]);
                    break;
                case "button_power_reset":
                    ResetStat(label_stat_power, textBox_power, defaultStatCoordinates[1]);
                    break;
                case "button_wisdom_reset":
                    ResetStat(label_stat_wisdom, textBox_wisdom, defaultStatCoordinates[2]);
                    break;
                case "button_speed_reset":
                    ResetStat(label_stat_speed, textBox_speed, defaultStatCoordinates[3]);
                    break;
                case "button_energy_reset":
                    ResetStat(label_stat_energy, textBox_energy, defaultStatCoordinates[4]);
                    break;
                default:
                    break;
            }
        }

        // Returns all stat labels as an array of labels.
        public Label[] GetStatLabels()
        {
            Label[] labels = { label_stat_courage, label_stat_power, label_stat_wisdom, label_stat_speed, label_stat_energy };
            return labels;
        }

        // Handles the "About" menu bar button.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }

        // Handles the "Settings" menu bar button.
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSettings(this).Show();
        }

        // Handles updating the language of all buttons. Gets the language from the Program static class and then re-initializes the buttons and labels.
        public void UpdateLanguage()
        {
            if (!language.id.Equals(Program.language.id))
            {
                language = Program.language;
                InitializeLanguage();
            }
        }

        // Handles the reset all button event.
        private void button_resetAll_Click(object sender, EventArgs e)
        {
            ResetAllStats();
        }
    }
}
