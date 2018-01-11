namespace ChaoticCardWriter
{
    partial class FormCoordAdjust
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
            this.button_x_minus = new System.Windows.Forms.Button();
            this.button_x_plus = new System.Windows.Forms.Button();
            this.labe_x_static = new System.Windows.Forms.Label();
            this.label_y_static = new System.Windows.Forms.Label();
            this.button_y_plus = new System.Windows.Forms.Button();
            this.button_y_minus = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox_x_value = new System.Windows.Forms.TextBox();
            this.textBox_y_value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_x_minus
            // 
            this.button_x_minus.Location = new System.Drawing.Point(34, 12);
            this.button_x_minus.Name = "button_x_minus";
            this.button_x_minus.Size = new System.Drawing.Size(20, 20);
            this.button_x_minus.TabIndex = 0;
            this.button_x_minus.Text = "-";
            this.button_x_minus.UseVisualStyleBackColor = true;
            this.button_x_minus.Click += new System.EventHandler(this.button_x_minus_Click);
            // 
            // button_x_plus
            // 
            this.button_x_plus.Location = new System.Drawing.Point(101, 12);
            this.button_x_plus.Name = "button_x_plus";
            this.button_x_plus.Size = new System.Drawing.Size(20, 20);
            this.button_x_plus.TabIndex = 1;
            this.button_x_plus.Text = "+";
            this.button_x_plus.UseVisualStyleBackColor = true;
            this.button_x_plus.Click += new System.EventHandler(this.button_x_plus_Click);
            // 
            // labe_x_static
            // 
            this.labe_x_static.AutoSize = true;
            this.labe_x_static.Location = new System.Drawing.Point(14, 16);
            this.labe_x_static.Name = "labe_x_static";
            this.labe_x_static.Size = new System.Drawing.Size(14, 13);
            this.labe_x_static.TabIndex = 3;
            this.labe_x_static.Text = "X";
            // 
            // label_y_static
            // 
            this.label_y_static.AutoSize = true;
            this.label_y_static.Location = new System.Drawing.Point(14, 42);
            this.label_y_static.Name = "label_y_static";
            this.label_y_static.Size = new System.Drawing.Size(14, 13);
            this.label_y_static.TabIndex = 7;
            this.label_y_static.Text = "Y";
            // 
            // button_y_plus
            // 
            this.button_y_plus.Location = new System.Drawing.Point(101, 38);
            this.button_y_plus.Name = "button_y_plus";
            this.button_y_plus.Size = new System.Drawing.Size(20, 20);
            this.button_y_plus.TabIndex = 5;
            this.button_y_plus.Text = "+";
            this.button_y_plus.UseVisualStyleBackColor = true;
            this.button_y_plus.Click += new System.EventHandler(this.button_y_plus_Click);
            // 
            // button_y_minus
            // 
            this.button_y_minus.Location = new System.Drawing.Point(34, 38);
            this.button_y_minus.Name = "button_y_minus";
            this.button_y_minus.Size = new System.Drawing.Size(20, 20);
            this.button_y_minus.TabIndex = 4;
            this.button_y_minus.Text = "-";
            this.button_y_minus.UseVisualStyleBackColor = true;
            this.button_y_minus.Click += new System.EventHandler(this.button_y_minus_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(12, 67);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(60, 23);
            this.button_OK.TabIndex = 8;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(78, 67);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(60, 23);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_x_value
            // 
            this.textBox_x_value.Location = new System.Drawing.Point(60, 12);
            this.textBox_x_value.Name = "textBox_x_value";
            this.textBox_x_value.Size = new System.Drawing.Size(35, 20);
            this.textBox_x_value.TabIndex = 10;
            this.textBox_x_value.Text = "0";
            this.textBox_x_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_y_value
            // 
            this.textBox_y_value.Location = new System.Drawing.Point(60, 38);
            this.textBox_y_value.Name = "textBox_y_value";
            this.textBox_y_value.Size = new System.Drawing.Size(35, 20);
            this.textBox_y_value.TabIndex = 11;
            this.textBox_y_value.Text = "0";
            this.textBox_y_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormCoordAdjust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 102);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_y_static);
            this.Controls.Add(this.button_y_plus);
            this.Controls.Add(this.button_y_minus);
            this.Controls.Add(this.labe_x_static);
            this.Controls.Add(this.button_x_plus);
            this.Controls.Add(this.button_x_minus);
            this.Controls.Add(this.textBox_y_value);
            this.Controls.Add(this.textBox_x_value);
            this.MaximumSize = new System.Drawing.Size(165, 141);
            this.Name = "FormCoordAdjust";
            this.Text = "Chaotic Card Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_x_minus;
        private System.Windows.Forms.Button button_x_plus;
        private System.Windows.Forms.Label labe_x_static;
        private System.Windows.Forms.Label label_y_static;
        private System.Windows.Forms.Button button_y_plus;
        private System.Windows.Forms.Button button_y_minus;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox_x_value;
        private System.Windows.Forms.TextBox textBox_y_value;
    }
}