namespace ChaoticCardWriter
{
    partial class FormWriteFromFile
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
            this.groupBox_stats = new System.Windows.Forms.GroupBox();
            this.button_stats_file_browse = new System.Windows.Forms.Button();
            this.label_static_instructions = new System.Windows.Forms.Label();
            this.textBox_stats_file = new System.Windows.Forms.TextBox();
            this.groupBox_destination = new System.Windows.Forms.GroupBox();
            this.label_static_destination = new System.Windows.Forms.Label();
            this.button_destination_folder_browse = new System.Windows.Forms.Button();
            this.textBox_destination_folder = new System.Windows.Forms.TextBox();
            this.textBox_counting = new System.Windows.Forms.TextBox();
            this.button_write = new System.Windows.Forms.Button();
            this.label_static_counting = new System.Windows.Forms.Label();
            this.button_Done = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox_source = new System.Windows.Forms.GroupBox();
            this.label_static_source = new System.Windows.Forms.Label();
            this.button_source_browse = new System.Windows.Forms.Button();
            this.textBox_source_folder = new System.Windows.Forms.TextBox();
            this.comboBox_format = new System.Windows.Forms.ComboBox();
            this.label_static_format = new System.Windows.Forms.Label();
            this.groupBox_stats.SuspendLayout();
            this.groupBox_destination.SuspendLayout();
            this.groupBox_source.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_stats
            // 
            this.groupBox_stats.Controls.Add(this.button_stats_file_browse);
            this.groupBox_stats.Controls.Add(this.label_static_instructions);
            this.groupBox_stats.Controls.Add(this.textBox_stats_file);
            this.groupBox_stats.Location = new System.Drawing.Point(12, 17);
            this.groupBox_stats.Name = "groupBox_stats";
            this.groupBox_stats.Size = new System.Drawing.Size(384, 96);
            this.groupBox_stats.TabIndex = 0;
            this.groupBox_stats.TabStop = false;
            this.groupBox_stats.Text = "Stats File";
            // 
            // button_stats_file_browse
            // 
            this.button_stats_file_browse.Location = new System.Drawing.Point(288, 60);
            this.button_stats_file_browse.Name = "button_stats_file_browse";
            this.button_stats_file_browse.Size = new System.Drawing.Size(75, 23);
            this.button_stats_file_browse.TabIndex = 1;
            this.button_stats_file_browse.Text = "Browse";
            this.button_stats_file_browse.UseVisualStyleBackColor = true;
            this.button_stats_file_browse.Click += new System.EventHandler(this.button_stats_file_browse_Click);
            // 
            // label_static_instructions
            // 
            this.label_static_instructions.Location = new System.Drawing.Point(15, 16);
            this.label_static_instructions.Name = "label_static_instructions";
            this.label_static_instructions.Size = new System.Drawing.Size(360, 41);
            this.label_static_instructions.TabIndex = 7;
            this.label_static_instructions.Text = "Select a file to generate cards from. See documentation for an example file.";
            // 
            // textBox_stats_file
            // 
            this.textBox_stats_file.Location = new System.Drawing.Point(16, 61);
            this.textBox_stats_file.Name = "textBox_stats_file";
            this.textBox_stats_file.Size = new System.Drawing.Size(258, 20);
            this.textBox_stats_file.TabIndex = 0;
            // 
            // groupBox_destination
            // 
            this.groupBox_destination.Controls.Add(this.label_static_destination);
            this.groupBox_destination.Controls.Add(this.button_destination_folder_browse);
            this.groupBox_destination.Controls.Add(this.textBox_destination_folder);
            this.groupBox_destination.Location = new System.Drawing.Point(12, 221);
            this.groupBox_destination.Name = "groupBox_destination";
            this.groupBox_destination.Size = new System.Drawing.Size(384, 96);
            this.groupBox_destination.TabIndex = 2;
            this.groupBox_destination.TabStop = false;
            this.groupBox_destination.Text = "Destination Folder";
            // 
            // label_static_destination
            // 
            this.label_static_destination.Location = new System.Drawing.Point(15, 16);
            this.label_static_destination.Name = "label_static_destination";
            this.label_static_destination.Size = new System.Drawing.Size(350, 42);
            this.label_static_destination.TabIndex = 9;
            this.label_static_destination.Text = "Select the directory to save your cards in.";
            // 
            // button_destination_folder_browse
            // 
            this.button_destination_folder_browse.Location = new System.Drawing.Point(290, 60);
            this.button_destination_folder_browse.Name = "button_destination_folder_browse";
            this.button_destination_folder_browse.Size = new System.Drawing.Size(75, 23);
            this.button_destination_folder_browse.TabIndex = 1;
            this.button_destination_folder_browse.Text = "Browse";
            this.button_destination_folder_browse.UseVisualStyleBackColor = true;
            this.button_destination_folder_browse.Click += new System.EventHandler(this.button_destination_folder_browse_Click);
            // 
            // textBox_destination_folder
            // 
            this.textBox_destination_folder.Location = new System.Drawing.Point(18, 61);
            this.textBox_destination_folder.Name = "textBox_destination_folder";
            this.textBox_destination_folder.Size = new System.Drawing.Size(258, 20);
            this.textBox_destination_folder.TabIndex = 0;
            // 
            // textBox_counting
            // 
            this.textBox_counting.Location = new System.Drawing.Point(97, 330);
            this.textBox_counting.Name = "textBox_counting";
            this.textBox_counting.Size = new System.Drawing.Size(62, 20);
            this.textBox_counting.TabIndex = 3;
            this.textBox_counting.Text = "0";
            this.textBox_counting.TextChanged += new System.EventHandler(this.textBox_counting_TextChanged);
            // 
            // button_write
            // 
            this.button_write.Location = new System.Drawing.Point(10, 367);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(75, 23);
            this.button_write.TabIndex = 4;
            this.button_write.Text = "Write";
            this.button_write.UseVisualStyleBackColor = true;
            this.button_write.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_static_counting
            // 
            this.label_static_counting.AutoSize = true;
            this.label_static_counting.Location = new System.Drawing.Point(9, 333);
            this.label_static_counting.Name = "label_static_counting";
            this.label_static_counting.Size = new System.Drawing.Size(82, 13);
            this.label_static_counting.TabIndex = 5;
            this.label_static_counting.Text = "Begin Counting:";
            // 
            // button_Done
            // 
            this.button_Done.Location = new System.Drawing.Point(322, 367);
            this.button_Done.Name = "button_Done";
            this.button_Done.Size = new System.Drawing.Size(75, 23);
            this.button_Done.TabIndex = 6;
            this.button_Done.Text = "Done";
            this.button_Done.UseVisualStyleBackColor = true;
            this.button_Done.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox_source
            // 
            this.groupBox_source.Controls.Add(this.label_static_source);
            this.groupBox_source.Controls.Add(this.button_source_browse);
            this.groupBox_source.Controls.Add(this.textBox_source_folder);
            this.groupBox_source.Location = new System.Drawing.Point(12, 119);
            this.groupBox_source.Name = "groupBox_source";
            this.groupBox_source.Size = new System.Drawing.Size(384, 96);
            this.groupBox_source.TabIndex = 3;
            this.groupBox_source.TabStop = false;
            this.groupBox_source.Text = "Source Folder";
            // 
            // label_static_source
            // 
            this.label_static_source.Location = new System.Drawing.Point(15, 16);
            this.label_static_source.Name = "label_static_source";
            this.label_static_source.Size = new System.Drawing.Size(360, 41);
            this.label_static_source.TabIndex = 8;
            this.label_static_source.Text = "Select the directory in which your image files are located.";
            // 
            // button_source_browse
            // 
            this.button_source_browse.Location = new System.Drawing.Point(290, 59);
            this.button_source_browse.Name = "button_source_browse";
            this.button_source_browse.Size = new System.Drawing.Size(75, 23);
            this.button_source_browse.TabIndex = 1;
            this.button_source_browse.Text = "Browse";
            this.button_source_browse.UseVisualStyleBackColor = true;
            this.button_source_browse.Click += new System.EventHandler(this.button_source_browse_Click);
            // 
            // textBox_source_folder
            // 
            this.textBox_source_folder.Location = new System.Drawing.Point(18, 60);
            this.textBox_source_folder.Name = "textBox_source_folder";
            this.textBox_source_folder.Size = new System.Drawing.Size(258, 20);
            this.textBox_source_folder.TabIndex = 0;
            // 
            // comboBox_format
            // 
            this.comboBox_format.FormattingEnabled = true;
            this.comboBox_format.Items.AddRange(new object[] {
            "*.png",
            "*.jpg",
            "*.bmp"});
            this.comboBox_format.Location = new System.Drawing.Point(288, 330);
            this.comboBox_format.Name = "comboBox_format";
            this.comboBox_format.Size = new System.Drawing.Size(87, 21);
            this.comboBox_format.TabIndex = 7;
            // 
            // label_static_format
            // 
            this.label_static_format.AutoSize = true;
            this.label_static_format.Location = new System.Drawing.Point(240, 333);
            this.label_static_format.Name = "label_static_format";
            this.label_static_format.Size = new System.Drawing.Size(42, 13);
            this.label_static_format.TabIndex = 8;
            this.label_static_format.Text = "Format:";
            // 
            // FormWriteFromFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 404);
            this.Controls.Add(this.label_static_format);
            this.Controls.Add(this.comboBox_format);
            this.Controls.Add(this.groupBox_source);
            this.Controls.Add(this.button_Done);
            this.Controls.Add(this.label_static_counting);
            this.Controls.Add(this.button_write);
            this.Controls.Add(this.textBox_counting);
            this.Controls.Add(this.groupBox_destination);
            this.Controls.Add(this.groupBox_stats);
            this.Name = "FormWriteFromFile";
            this.Text = "FormMassDraw";
            this.groupBox_stats.ResumeLayout(false);
            this.groupBox_stats.PerformLayout();
            this.groupBox_destination.ResumeLayout(false);
            this.groupBox_destination.PerformLayout();
            this.groupBox_source.ResumeLayout(false);
            this.groupBox_source.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_stats_file_browse;
        private System.Windows.Forms.TextBox textBox_stats_file;
        private System.Windows.Forms.Button button_destination_folder_browse;
        private System.Windows.Forms.TextBox textBox_destination_folder;
        private System.Windows.Forms.TextBox textBox_counting;
        private System.Windows.Forms.Button button_write;
        private System.Windows.Forms.Label label_static_counting;
        private System.Windows.Forms.Button button_Done;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox_destination;
        private System.Windows.Forms.GroupBox groupBox_stats;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label_static_destination;
        private System.Windows.Forms.GroupBox groupBox_source;
        private System.Windows.Forms.Label label_static_source;
        private System.Windows.Forms.Button button_source_browse;
        private System.Windows.Forms.Label label_static_instructions;
        private System.Windows.Forms.TextBox textBox_source_folder;
        private System.Windows.Forms.ComboBox comboBox_format;
        private System.Windows.Forms.Label label_static_format;
    }
}