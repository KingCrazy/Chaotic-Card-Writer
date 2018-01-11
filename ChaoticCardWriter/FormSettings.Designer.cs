namespace ChaoticCardWriter
{
    partial class FormSettings
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
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.groupBox_language = new System.Windows.Forms.GroupBox();
            this.groupBox_language.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_language
            // 
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.Items.AddRange(new object[] {
            "Test",
            "Bob"});
            this.comboBox_language.Location = new System.Drawing.Point(6, 19);
            this.comboBox_language.Name = "comboBox_language";
            this.comboBox_language.Size = new System.Drawing.Size(182, 21);
            this.comboBox_language.TabIndex = 0;
            this.comboBox_language.SelectedIndexChanged += new System.EventHandler(this.comboBox_language_SelectedIndexChanged);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(111, 93);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // groupBox_language
            // 
            this.groupBox_language.Controls.Add(this.comboBox_language);
            this.groupBox_language.Location = new System.Drawing.Point(12, 12);
            this.groupBox_language.Name = "groupBox_language";
            this.groupBox_language.Size = new System.Drawing.Size(195, 57);
            this.groupBox_language.TabIndex = 2;
            this.groupBox_language.TabStop = false;
            this.groupBox_language.Text = "Localization";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 128);
            this.Controls.Add(this.groupBox_language);
            this.Controls.Add(this.button_OK);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.groupBox_language.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_language;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.GroupBox groupBox_language;
    }
}