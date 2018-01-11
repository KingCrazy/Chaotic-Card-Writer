// Copyright 2018 github.com/KingCrazy
// The CardIO class handles the writing of cards to the computer's storage device.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ChaoticCardWriter
{
    class CardIO
    {
        // Handles the Write From File functionality. Will mass-write cards from a given text file, source folder, and destination folder. Uses the settings the user set up for a single card.
        public static void MultiWriteFiles(string filePath, string sourcePath, string destPath, string startNum, string ext, Label[] labels, System.Drawing.Imaging.ImageFormat format)
        {
            string path = "";
            string line;
            string[] tmp;

            int counter = 0;

            Image curImg = null;

            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            try
            {
                while ((line = file.ReadLine()) != null)
                {
                    tmp = line.Split(' ');

                    // Every even line should be the file name for the card. We check to see if it's even or odd, then we decide what to do.
                    if (counter % 2 == 0)
                    {
                        path = string.Format("{0}\\{1}", sourcePath, tmp[0]);
                        curImg = Image.FromFile(path);
                    }

                    // If the line number is not even, then we know we've grabbed the stats. We'll call our mainForm's WriteCard function to draw the cards up, and then save it.
                    else
                    {
                        if (curImg != null)
                        {
                            path = string.Format("{0}\\{1}.{2}", destPath, int.Parse(startNum) + (int)(counter / 2), ext);
                            WriteCard(curImg, tmp, labels).Save(path, format);
                        }
                    }
                    // After all is said and done, we increment the counter to help us keep track of what line number we're on.
                    counter++;
                }

                // Oops! We detected that the counter ended at an odd number, meaning a card was listed but no stats were below it. This should be reported to the user.
                if (counter % 2 > 0)
                {
                    MessageBox.Show(Program.language.GetValue(LanguageFileConsts.KEY_WARN_STATS_ODD), Program.language.GetValue(LanguageFileConsts.KEY_PROGRAM_TITLE));
                }
                else
                {
                    MessageBox.Show(Program.language.GetValue(LanguageFileConsts.KEY_BUTTON_DONE), Program.language.GetValue(LanguageFileConsts.KEY_PROGRAM_TITLE));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Program.language.GetValue(LanguageFileConsts.KEY_WARN_STATS_ERROR), Program.language.GetValue(LanguageFileConsts.KEY_PROGRAM_TITLE));
                Console.WriteLine(e);

                Console.WriteLine(path);
            }
            file.Close();
        }

        // Handles the writing of cards given an image, an array of stats, and an array of labels.
        private static Image WriteCard(Image img, string[] stats, Label[] labels)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = stats[i];
            }
            return WriteCard(img, labels);
        }

        // Handles the writing of cards given an image, and an array of labels.
        public static Image WriteCard(Image img, Label[] labels)
        {
            Image returnImg = img.Clone() as Image;
            Point pos = Point.Empty;
            SizeF stringSize = new SizeF();
            float offset = 0.0f;

            using (Graphics g = Graphics.FromImage(returnImg))
            {
                for (int i = 0; i < 5; i++)
                {
                    pos = labels[i].Location;

                    stringSize = g.MeasureString(labels[i].Text, labels[i].Font);

                    offset = (float)Math.Floor(labels[i].Width - stringSize.Width);

                    if (i == 4) // We're working with the energy stat
                    {
                        offset /= 2.0f;
                    }

                    if (labels[i].Text.Length == 1)
                        offset -= 1;

                    g.DrawString(labels[i].Text, labels[i].Font, Brushes.Black, pos.X + offset, pos.Y); //- 2, pos.Y); //new RectangleF(pos.X, pos.Y, stringSize.Width,stringSize.Height));
                }
            }

            return returnImg;
        }
    }
}
