namespace BinaryConverter
{
    partial class Form1
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
            this.Decimal_textbox = new System.Windows.Forms.TextBox();
            this.Binary_textbox = new System.Windows.Forms.TextBox();
            this.Hexidecimal_textbox = new System.Windows.Forms.TextBox();
            this.Decimal_radioButton = new System.Windows.Forms.RadioButton();
            this.Binary_radioButton = new System.Windows.Forms.RadioButton();
            this.Hexidecimal_radioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Decimal_textbox
            // 
            this.Decimal_textbox.Location = new System.Drawing.Point(43, 46);
            this.Decimal_textbox.Name = "Decimal_textbox";
            this.Decimal_textbox.Size = new System.Drawing.Size(134, 20);
            this.Decimal_textbox.TabIndex = 0;
            this.Decimal_textbox.TextChanged += new System.EventHandler(this.Decimal_textbox_TextChanged);
            // 
            // Binary_textbox
            // 
            this.Binary_textbox.Location = new System.Drawing.Point(43, 95);
            this.Binary_textbox.Name = "Binary_textbox";
            this.Binary_textbox.Size = new System.Drawing.Size(134, 20);
            this.Binary_textbox.TabIndex = 1;
            this.Binary_textbox.TextChanged += new System.EventHandler(this.Binary_textbox_TextChanged);
            // 
            // Hexidecimal_textbox
            // 
            this.Hexidecimal_textbox.Location = new System.Drawing.Point(43, 145);
            this.Hexidecimal_textbox.Name = "Hexidecimal_textbox";
            this.Hexidecimal_textbox.Size = new System.Drawing.Size(134, 20);
            this.Hexidecimal_textbox.TabIndex = 2;
            this.Hexidecimal_textbox.TextChanged += new System.EventHandler(this.Hexidecimal_textbox_TextChanged);
            // 
            // Decimal_radioButton
            // 
            this.Decimal_radioButton.AutoSize = true;
            this.Decimal_radioButton.Checked = true;
            this.Decimal_radioButton.Location = new System.Drawing.Point(183, 46);
            this.Decimal_radioButton.Name = "Decimal_radioButton";
            this.Decimal_radioButton.Size = new System.Drawing.Size(63, 17);
            this.Decimal_radioButton.TabIndex = 6;
            this.Decimal_radioButton.TabStop = true;
            this.Decimal_radioButton.Text = "Decimal";
            this.Decimal_radioButton.UseVisualStyleBackColor = true;
            this.Decimal_radioButton.CheckedChanged += new System.EventHandler(this.Decimal_radioButton_CheckedChanged);
            // 
            // Binary_radioButton
            // 
            this.Binary_radioButton.AutoSize = true;
            this.Binary_radioButton.Location = new System.Drawing.Point(183, 95);
            this.Binary_radioButton.Name = "Binary_radioButton";
            this.Binary_radioButton.Size = new System.Drawing.Size(54, 17);
            this.Binary_radioButton.TabIndex = 7;
            this.Binary_radioButton.TabStop = true;
            this.Binary_radioButton.Text = "Binary";
            this.Binary_radioButton.UseVisualStyleBackColor = true;
            this.Binary_radioButton.CheckedChanged += new System.EventHandler(this.Binary_radioButton_CheckedChanged);
            // 
            // Hexidecimal_radioButton
            // 
            this.Hexidecimal_radioButton.AutoSize = true;
            this.Hexidecimal_radioButton.Location = new System.Drawing.Point(183, 145);
            this.Hexidecimal_radioButton.Name = "Hexidecimal_radioButton";
            this.Hexidecimal_radioButton.Size = new System.Drawing.Size(82, 17);
            this.Hexidecimal_radioButton.TabIndex = 8;
            this.Hexidecimal_radioButton.TabStop = true;
            this.Hexidecimal_radioButton.Text = "Hexidecimal";
            this.Hexidecimal_radioButton.UseVisualStyleBackColor = true;
            this.Hexidecimal_radioButton.CheckedChanged += new System.EventHandler(this.Hexidecimal_radioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 198);
            this.Controls.Add(this.Hexidecimal_radioButton);
            this.Controls.Add(this.Binary_radioButton);
            this.Controls.Add(this.Decimal_radioButton);
            this.Controls.Add(this.Hexidecimal_textbox);
            this.Controls.Add(this.Binary_textbox);
            this.Controls.Add(this.Decimal_textbox);
            this.Name = "Form1";
            this.Text = "Decimal Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Decimal_textbox;
        private System.Windows.Forms.TextBox Binary_textbox;
        private System.Windows.Forms.TextBox Hexidecimal_textbox;
        private System.Windows.Forms.RadioButton Decimal_radioButton;
        private System.Windows.Forms.RadioButton Binary_radioButton;
        private System.Windows.Forms.RadioButton Hexidecimal_radioButton;
    }
}

