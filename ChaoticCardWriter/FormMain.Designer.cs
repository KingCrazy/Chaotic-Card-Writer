using System;

namespace ChaoticCardWriter
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_card = new System.Windows.Forms.PictureBox();
            this.label_stat_energy = new System.Windows.Forms.Label();
            this.label_stat_speed = new System.Windows.Forms.Label();
            this.label_stat_wisdom = new System.Windows.Forms.Label();
            this.label_stat_power = new System.Windows.Forms.Label();
            this.label_stat_courage = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_energy_reset = new System.Windows.Forms.Button();
            this.button_speed_reset = new System.Windows.Forms.Button();
            this.button_wisdom_reset = new System.Windows.Forms.Button();
            this.button_power_reset = new System.Windows.Forms.Button();
            this.button_courage_reset = new System.Windows.Forms.Button();
            this.button_resetAll = new System.Windows.Forms.Button();
            this.button_energy_font = new System.Windows.Forms.Button();
            this.button_speed_font = new System.Windows.Forms.Button();
            this.button_wisdom_font = new System.Windows.Forms.Button();
            this.button_power_font = new System.Windows.Forms.Button();
            this.button_courage_font = new System.Windows.Forms.Button();
            this.button_energy_adjust = new System.Windows.Forms.Button();
            this.button_speed_adjust = new System.Windows.Forms.Button();
            this.button_wisdom_adjust = new System.Windows.Forms.Button();
            this.button_power_adjust = new System.Windows.Forms.Button();
            this.button_courage_adjust = new System.Windows.Forms.Button();
            this.label_energy_static = new System.Windows.Forms.Label();
            this.label_speed_static = new System.Windows.Forms.Label();
            this.label_wisdom_static = new System.Windows.Forms.Label();
            this.label_power_static = new System.Windows.Forms.Label();
            this.label_courage_static = new System.Windows.Forms.Label();
            this.textBox_energy = new System.Windows.Forms.TextBox();
            this.textBox_speed = new System.Windows.Forms.TextBox();
            this.textBox_wisdom = new System.Windows.Forms.TextBox();
            this.textBox_power = new System.Windows.Forms.TextBox();
            this.textBox_courage = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_card)).BeginInit();
            this.pictureBox_card.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(540, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeFromFileToolStripMenuItem,
            this.loadImageToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // writeFromFileToolStripMenuItem
            // 
            this.writeFromFileToolStripMenuItem.Name = "writeFromFileToolStripMenuItem";
            this.writeFromFileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.writeFromFileToolStripMenuItem.Text = "Write From File";
            this.writeFromFileToolStripMenuItem.Click += new System.EventHandler(this.writeFromFileToolStripMenuItem_Click);
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // pictureBox_card
            // 
            this.pictureBox_card.Controls.Add(this.label_stat_energy);
            this.pictureBox_card.Controls.Add(this.label_stat_speed);
            this.pictureBox_card.Controls.Add(this.label_stat_wisdom);
            this.pictureBox_card.Controls.Add(this.label_stat_power);
            this.pictureBox_card.Controls.Add(this.label_stat_courage);
            this.pictureBox_card.InitialImage = null;
            this.pictureBox_card.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_card.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_card.Name = "pictureBox_card";
            this.pictureBox_card.Size = new System.Drawing.Size(250, 350);
            this.pictureBox_card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_card.TabIndex = 1;
            this.pictureBox_card.TabStop = false;
            this.pictureBox_card.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_card_MouseHover);
            // 
            // label_stat_energy
            // 
            this.label_stat_energy.BackColor = System.Drawing.Color.Transparent;
            this.label_stat_energy.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label_stat_energy.Location = new System.Drawing.Point(193, 316);
            this.label_stat_energy.Name = "label_stat_energy";
            this.label_stat_energy.Size = new System.Drawing.Size(48, 25);
            this.label_stat_energy.TabIndex = 6;
            this.label_stat_energy.Text = "0";
            this.label_stat_energy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_stat_speed
            // 
            this.label_stat_speed.BackColor = System.Drawing.Color.Transparent;
            this.label_stat_speed.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_stat_speed.Location = new System.Drawing.Point(7, 291);
            this.label_stat_speed.Name = "label_stat_speed";
            this.label_stat_speed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_stat_speed.Size = new System.Drawing.Size(32, 20);
            this.label_stat_speed.TabIndex = 5;
            this.label_stat_speed.Text = "0";
            // 
            // label_stat_wisdom
            // 
            this.label_stat_wisdom.BackColor = System.Drawing.Color.Transparent;
            this.label_stat_wisdom.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_stat_wisdom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_stat_wisdom.Location = new System.Drawing.Point(7, 267);
            this.label_stat_wisdom.Name = "label_stat_wisdom";
            this.label_stat_wisdom.Size = new System.Drawing.Size(32, 20);
            this.label_stat_wisdom.TabIndex = 4;
            this.label_stat_wisdom.Text = "0";
            this.label_stat_wisdom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_stat_power
            // 
            this.label_stat_power.BackColor = System.Drawing.Color.Transparent;
            this.label_stat_power.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_stat_power.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_stat_power.Location = new System.Drawing.Point(7, 243);
            this.label_stat_power.Name = "label_stat_power";
            this.label_stat_power.Size = new System.Drawing.Size(32, 20);
            this.label_stat_power.TabIndex = 3;
            this.label_stat_power.Text = "0";
            this.label_stat_power.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_stat_courage
            // 
            this.label_stat_courage.BackColor = System.Drawing.Color.Transparent;
            this.label_stat_courage.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_stat_courage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_stat_courage.Location = new System.Drawing.Point(7, 219);
            this.label_stat_courage.Name = "label_stat_courage";
            this.label_stat_courage.Size = new System.Drawing.Size(32, 20);
            this.label_stat_courage.TabIndex = 2;
            this.label_stat_courage.Text = "0";
            this.label_stat_courage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_energy_reset);
            this.panel1.Controls.Add(this.button_speed_reset);
            this.panel1.Controls.Add(this.button_wisdom_reset);
            this.panel1.Controls.Add(this.button_power_reset);
            this.panel1.Controls.Add(this.button_courage_reset);
            this.panel1.Controls.Add(this.button_resetAll);
            this.panel1.Controls.Add(this.button_energy_font);
            this.panel1.Controls.Add(this.button_speed_font);
            this.panel1.Controls.Add(this.button_wisdom_font);
            this.panel1.Controls.Add(this.button_power_font);
            this.panel1.Controls.Add(this.button_courage_font);
            this.panel1.Controls.Add(this.button_energy_adjust);
            this.panel1.Controls.Add(this.button_speed_adjust);
            this.panel1.Controls.Add(this.button_wisdom_adjust);
            this.panel1.Controls.Add(this.button_power_adjust);
            this.panel1.Controls.Add(this.button_courage_adjust);
            this.panel1.Controls.Add(this.label_energy_static);
            this.panel1.Controls.Add(this.label_speed_static);
            this.panel1.Controls.Add(this.label_wisdom_static);
            this.panel1.Controls.Add(this.label_power_static);
            this.panel1.Controls.Add(this.label_courage_static);
            this.panel1.Controls.Add(this.textBox_energy);
            this.panel1.Controls.Add(this.textBox_speed);
            this.panel1.Controls.Add(this.textBox_wisdom);
            this.panel1.Controls.Add(this.textBox_power);
            this.panel1.Controls.Add(this.textBox_courage);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 418);
            this.panel1.TabIndex = 2;
            // 
            // button_energy_reset
            // 
            this.button_energy_reset.Location = new System.Drawing.Point(117, 314);
            this.button_energy_reset.Name = "button_energy_reset";
            this.button_energy_reset.Size = new System.Drawing.Size(50, 23);
            this.button_energy_reset.TabIndex = 25;
            this.button_energy_reset.Text = "Reset";
            this.button_energy_reset.UseVisualStyleBackColor = true;
            // 
            // button_speed_reset
            // 
            this.button_speed_reset.Location = new System.Drawing.Point(117, 240);
            this.button_speed_reset.Name = "button_speed_reset";
            this.button_speed_reset.Size = new System.Drawing.Size(50, 23);
            this.button_speed_reset.TabIndex = 24;
            this.button_speed_reset.Text = "Reset";
            this.button_speed_reset.UseVisualStyleBackColor = true;
            // 
            // button_wisdom_reset
            // 
            this.button_wisdom_reset.Location = new System.Drawing.Point(117, 168);
            this.button_wisdom_reset.Name = "button_wisdom_reset";
            this.button_wisdom_reset.Size = new System.Drawing.Size(50, 23);
            this.button_wisdom_reset.TabIndex = 23;
            this.button_wisdom_reset.Text = "Reset";
            this.button_wisdom_reset.UseVisualStyleBackColor = true;
            // 
            // button_power_reset
            // 
            this.button_power_reset.Location = new System.Drawing.Point(117, 94);
            this.button_power_reset.Name = "button_power_reset";
            this.button_power_reset.Size = new System.Drawing.Size(50, 23);
            this.button_power_reset.TabIndex = 22;
            this.button_power_reset.Text = "Reset";
            this.button_power_reset.UseVisualStyleBackColor = true;
            // 
            // button_courage_reset
            // 
            this.button_courage_reset.Location = new System.Drawing.Point(117, 23);
            this.button_courage_reset.Name = "button_courage_reset";
            this.button_courage_reset.Size = new System.Drawing.Size(50, 23);
            this.button_courage_reset.TabIndex = 21;
            this.button_courage_reset.Text = "Reset";
            this.button_courage_reset.UseVisualStyleBackColor = true;
            // 
            // button_resetAll
            // 
            this.button_resetAll.Location = new System.Drawing.Point(8, 388);
            this.button_resetAll.Name = "button_resetAll";
            this.button_resetAll.Size = new System.Drawing.Size(75, 23);
            this.button_resetAll.TabIndex = 20;
            this.button_resetAll.Text = "Reset All";
            this.button_resetAll.UseVisualStyleBackColor = true;
            this.button_resetAll.Click += new System.EventHandler(this.button_resetAll_Click);
            // 
            // button_energy_font
            // 
            this.button_energy_font.Location = new System.Drawing.Point(92, 342);
            this.button_energy_font.Name = "button_energy_font";
            this.button_energy_font.Size = new System.Drawing.Size(75, 23);
            this.button_energy_font.TabIndex = 19;
            this.button_energy_font.Text = "Font";
            this.button_energy_font.UseVisualStyleBackColor = true;
            // 
            // button_speed_font
            // 
            this.button_speed_font.Location = new System.Drawing.Point(92, 268);
            this.button_speed_font.Name = "button_speed_font";
            this.button_speed_font.Size = new System.Drawing.Size(75, 23);
            this.button_speed_font.TabIndex = 18;
            this.button_speed_font.Text = "Font";
            this.button_speed_font.UseVisualStyleBackColor = true;
            // 
            // button_wisdom_font
            // 
            this.button_wisdom_font.Location = new System.Drawing.Point(92, 196);
            this.button_wisdom_font.Name = "button_wisdom_font";
            this.button_wisdom_font.Size = new System.Drawing.Size(75, 23);
            this.button_wisdom_font.TabIndex = 17;
            this.button_wisdom_font.Text = "Font";
            this.button_wisdom_font.UseVisualStyleBackColor = true;
            // 
            // button_power_font
            // 
            this.button_power_font.Location = new System.Drawing.Point(92, 122);
            this.button_power_font.Name = "button_power_font";
            this.button_power_font.Size = new System.Drawing.Size(75, 23);
            this.button_power_font.TabIndex = 16;
            this.button_power_font.Text = "Font";
            this.button_power_font.UseVisualStyleBackColor = true;
            // 
            // button_courage_font
            // 
            this.button_courage_font.Location = new System.Drawing.Point(92, 51);
            this.button_courage_font.Name = "button_courage_font";
            this.button_courage_font.Size = new System.Drawing.Size(75, 23);
            this.button_courage_font.TabIndex = 15;
            this.button_courage_font.Text = "Font";
            this.button_courage_font.UseVisualStyleBackColor = true;
            // 
            // button_energy_adjust
            // 
            this.button_energy_adjust.Location = new System.Drawing.Point(8, 342);
            this.button_energy_adjust.Name = "button_energy_adjust";
            this.button_energy_adjust.Size = new System.Drawing.Size(75, 23);
            this.button_energy_adjust.TabIndex = 14;
            this.button_energy_adjust.Text = "Adjust";
            this.button_energy_adjust.UseVisualStyleBackColor = true;
            // 
            // button_speed_adjust
            // 
            this.button_speed_adjust.Location = new System.Drawing.Point(8, 268);
            this.button_speed_adjust.Name = "button_speed_adjust";
            this.button_speed_adjust.Size = new System.Drawing.Size(75, 23);
            this.button_speed_adjust.TabIndex = 13;
            this.button_speed_adjust.Text = "Adjust";
            this.button_speed_adjust.UseVisualStyleBackColor = true;
            // 
            // button_wisdom_adjust
            // 
            this.button_wisdom_adjust.Location = new System.Drawing.Point(8, 196);
            this.button_wisdom_adjust.Name = "button_wisdom_adjust";
            this.button_wisdom_adjust.Size = new System.Drawing.Size(75, 23);
            this.button_wisdom_adjust.TabIndex = 12;
            this.button_wisdom_adjust.Text = "Adjust";
            this.button_wisdom_adjust.UseVisualStyleBackColor = true;
            // 
            // button_power_adjust
            // 
            this.button_power_adjust.Location = new System.Drawing.Point(11, 122);
            this.button_power_adjust.Name = "button_power_adjust";
            this.button_power_adjust.Size = new System.Drawing.Size(75, 23);
            this.button_power_adjust.TabIndex = 11;
            this.button_power_adjust.Text = "Adjust";
            this.button_power_adjust.UseVisualStyleBackColor = true;
            // 
            // button_courage_adjust
            // 
            this.button_courage_adjust.Location = new System.Drawing.Point(11, 51);
            this.button_courage_adjust.Name = "button_courage_adjust";
            this.button_courage_adjust.Size = new System.Drawing.Size(75, 23);
            this.button_courage_adjust.TabIndex = 10;
            this.button_courage_adjust.Text = "Adjust";
            this.button_courage_adjust.UseVisualStyleBackColor = true;
            // 
            // label_energy_static
            // 
            this.label_energy_static.AutoSize = true;
            this.label_energy_static.Location = new System.Drawing.Point(8, 300);
            this.label_energy_static.Name = "label_energy_static";
            this.label_energy_static.Size = new System.Drawing.Size(40, 13);
            this.label_energy_static.TabIndex = 9;
            this.label_energy_static.Text = "Energy";
            // 
            // label_speed_static
            // 
            this.label_speed_static.AutoSize = true;
            this.label_speed_static.Location = new System.Drawing.Point(8, 226);
            this.label_speed_static.Name = "label_speed_static";
            this.label_speed_static.Size = new System.Drawing.Size(38, 13);
            this.label_speed_static.TabIndex = 8;
            this.label_speed_static.Text = "Speed";
            // 
            // label_wisdom_static
            // 
            this.label_wisdom_static.AutoSize = true;
            this.label_wisdom_static.Location = new System.Drawing.Point(8, 154);
            this.label_wisdom_static.Name = "label_wisdom_static";
            this.label_wisdom_static.Size = new System.Drawing.Size(45, 13);
            this.label_wisdom_static.TabIndex = 7;
            this.label_wisdom_static.Text = "Wisdom";
            // 
            // label_power_static
            // 
            this.label_power_static.AutoSize = true;
            this.label_power_static.Location = new System.Drawing.Point(11, 80);
            this.label_power_static.Name = "label_power_static";
            this.label_power_static.Size = new System.Drawing.Size(37, 13);
            this.label_power_static.TabIndex = 6;
            this.label_power_static.Text = "Power";
            // 
            // label_courage_static
            // 
            this.label_courage_static.AutoSize = true;
            this.label_courage_static.Location = new System.Drawing.Point(11, 7);
            this.label_courage_static.Name = "label_courage_static";
            this.label_courage_static.Size = new System.Drawing.Size(47, 13);
            this.label_courage_static.TabIndex = 5;
            this.label_courage_static.Text = "Courage";
            // 
            // textBox_energy
            // 
            this.textBox_energy.Location = new System.Drawing.Point(8, 316);
            this.textBox_energy.MaxLength = 3;
            this.textBox_energy.Name = "textBox_energy";
            this.textBox_energy.Size = new System.Drawing.Size(100, 20);
            this.textBox_energy.TabIndex = 4;
            this.textBox_energy.Text = "0";
            // 
            // textBox_speed
            // 
            this.textBox_speed.Location = new System.Drawing.Point(10, 242);
            this.textBox_speed.MaxLength = 3;
            this.textBox_speed.Name = "textBox_speed";
            this.textBox_speed.Size = new System.Drawing.Size(100, 20);
            this.textBox_speed.TabIndex = 3;
            this.textBox_speed.Text = "0";
            // 
            // textBox_wisdom
            // 
            this.textBox_wisdom.Location = new System.Drawing.Point(8, 170);
            this.textBox_wisdom.MaxLength = 3;
            this.textBox_wisdom.Name = "textBox_wisdom";
            this.textBox_wisdom.Size = new System.Drawing.Size(100, 20);
            this.textBox_wisdom.TabIndex = 2;
            this.textBox_wisdom.Text = "0";
            // 
            // textBox_power
            // 
            this.textBox_power.Location = new System.Drawing.Point(11, 96);
            this.textBox_power.MaxLength = 3;
            this.textBox_power.Name = "textBox_power";
            this.textBox_power.Size = new System.Drawing.Size(100, 20);
            this.textBox_power.TabIndex = 1;
            this.textBox_power.Text = "0";
            // 
            // textBox_courage
            // 
            this.textBox_courage.Location = new System.Drawing.Point(11, 25);
            this.textBox_courage.MaxLength = 3;
            this.textBox_courage.Name = "textBox_courage";
            this.textBox_courage.Size = new System.Drawing.Size(100, 20);
            this.textBox_courage.TabIndex = 0;
            this.textBox_courage.Text = "0";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 452);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(540, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox_card);
            this.panel2.Location = new System.Drawing.Point(227, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 417);
            this.panel2.TabIndex = 6;
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Enabled = false;
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(540, 474);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Chaotic Card Writer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_card)).EndInit();
            this.pictureBox_card.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox_card;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_courage_static;
        private System.Windows.Forms.TextBox textBox_energy;
        private System.Windows.Forms.TextBox textBox_speed;
        private System.Windows.Forms.TextBox textBox_wisdom;
        private System.Windows.Forms.TextBox textBox_power;
        private System.Windows.Forms.TextBox textBox_courage;
        private System.Windows.Forms.Label label_energy_static;
        private System.Windows.Forms.Label label_speed_static;
        private System.Windows.Forms.Label label_wisdom_static;
        private System.Windows.Forms.Label label_power_static;
        private System.Windows.Forms.Label label_stat_power;
        private System.Windows.Forms.Label label_stat_courage;
        private System.Windows.Forms.Label label_stat_energy;
        private System.Windows.Forms.Label label_stat_speed;
        private System.Windows.Forms.Label label_stat_wisdom;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button_energy_font;
        private System.Windows.Forms.Button button_speed_font;
        private System.Windows.Forms.Button button_wisdom_font;
        private System.Windows.Forms.Button button_power_font;
        private System.Windows.Forms.Button button_courage_font;
        private System.Windows.Forms.Button button_energy_adjust;
        private System.Windows.Forms.Button button_speed_adjust;
        private System.Windows.Forms.Button button_wisdom_adjust;
        private System.Windows.Forms.Button button_power_adjust;
        private System.Windows.Forms.Button button_courage_adjust;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button button_resetAll;
        private System.Windows.Forms.Button button_energy_reset;
        private System.Windows.Forms.Button button_speed_reset;
        private System.Windows.Forms.Button button_wisdom_reset;
        private System.Windows.Forms.Button button_power_reset;
        private System.Windows.Forms.Button button_courage_reset;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
    }
}

