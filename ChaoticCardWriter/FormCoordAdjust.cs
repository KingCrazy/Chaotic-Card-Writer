// Copyright 2018 github.com/KingCrazy
// A dialogue window that allows the user to adjustment the label coordinates on the main form.

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
    public partial class FormCoordAdjust : Form
    {
        FormMain form;
        Label activeLabel;
        EventHandler onValueChange;

        private Point originalPos = Point.Empty;
        private int xValue = 0;
        private int yValue = 0;

        public FormCoordAdjust(FormMain formRef, ref Label label)
        {
            InitializeComponent();
            InitializeLanguage();

            form = formRef;
            activeLabel = label;

            originalPos = label.Location;

            xValue = label.Location.X;
            yValue = label.Location.Y;

            textBox_x_value.Text = xValue.ToString();
            textBox_y_value.Text = yValue.ToString();

            onValueChange = new EventHandler(textBox_OnValueChange);
            textBox_x_value.TextChanged += onValueChange;
            textBox_y_value.TextChanged += onValueChange;
        }

        // Localization stoofs
        private void InitializeLanguage()
        {
            button_OK.Text = Program.language.GetValue(LanguageFileConsts.KEY_BUTTON_OK);
            button_cancel.Text = Program.language.GetValue(LanguageFileConsts.KEY_BUTTON_CANCEL);
            this.Text = Program.language.GetValue(LanguageFileConsts.KEY_PROGRAM_TITLE);
        }

        // Handles the X+ button.
        private void button_x_plus_Click(object sender, EventArgs e)
        {
            ++xValue;
            UpdateCoordinates();
        }

        // Handles the Y+ button.
        private void button_y_plus_Click(object sender, EventArgs e)
        {
            ++yValue;
            UpdateCoordinates();
        }

        // Handles the Y- button.
        private void button_y_minus_Click(object sender, EventArgs e)
        {
            --yValue;
            UpdateCoordinates();
        }

        // Handles the X- button.
        private void button_x_minus_Click(object sender, EventArgs e)
        {
            --xValue;
            UpdateCoordinates();
        }

        // Updates the coordinates of the stat labels on the main form.
        private void UpdateCoordinates()
        {
            textBox_x_value.Text = xValue.ToString();
            textBox_y_value.Text = yValue.ToString();
            form.UpdateCoordinatesOfLabel(activeLabel, new Point(xValue,yValue));
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xValue = originalPos.X;
            yValue = originalPos.Y;
            UpdateCoordinates();
            this.Close();
        }

        // Handles the OnValueChange event. Checks if the written value is numerical, and then changes the coordinates accordingly.
        private void textBox_OnValueChange(object sender, EventArgs e)
        {
            TextBox obj = sender as TextBox;

            if (!FormMain.CheckIfNumericalValue(obj.Text))
            {
                textBox_x_value.Text = xValue.ToString();
                textBox_y_value.Text = yValue.ToString();
                return;
            }

            if (obj.Name.Equals("textBox_x_value"))
                xValue = int.Parse(textBox_x_value.Text);
            else
                yValue = int.Parse(textBox_y_value.Text);

            UpdateCoordinates();
        }
    }
}
