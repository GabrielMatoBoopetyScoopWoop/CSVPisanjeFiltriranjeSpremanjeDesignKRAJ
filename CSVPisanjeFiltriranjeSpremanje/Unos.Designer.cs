namespace CSVPisanjeFiltriranjeSpremanje
{
    partial class Unos
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
            this.ImeTextBox = new System.Windows.Forms.TextBox();
            this.PrezimeTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UnosButton = new System.Windows.Forms.Button();
            this.ZavrsiButton = new System.Windows.Forms.Button();
            this.RazredComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ImeTextBox
            // 
            this.ImeTextBox.Location = new System.Drawing.Point(12, 62);
            this.ImeTextBox.Name = "ImeTextBox";
            this.ImeTextBox.Size = new System.Drawing.Size(380, 20);
            this.ImeTextBox.TabIndex = 0;
            // 
            // PrezimeTextBox
            // 
            this.PrezimeTextBox.Location = new System.Drawing.Point(12, 101);
            this.PrezimeTextBox.Name = "PrezimeTextBox";
            this.PrezimeTextBox.Size = new System.Drawing.Size(380, 20);
            this.PrezimeTextBox.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(12, 140);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(380, 20);
            this.EmailTextBox.TabIndex = 2;
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(9, 46);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(24, 13);
            this.Ime.TabIndex = 4;
            this.Ime.Text = "Ime";
            this.Ime.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Razred";
            // 
            // UnosButton
            // 
            this.UnosButton.BackColor = System.Drawing.SystemColors.Menu;
            this.UnosButton.Location = new System.Drawing.Point(12, 233);
            this.UnosButton.Name = "UnosButton";
            this.UnosButton.Size = new System.Drawing.Size(380, 54);
            this.UnosButton.TabIndex = 8;
            this.UnosButton.Text = "Unos";
            this.UnosButton.UseVisualStyleBackColor = false;
            this.UnosButton.Click += new System.EventHandler(this.UnosButton_Click);
            // 
            // ZavrsiButton
            // 
            this.ZavrsiButton.BackColor = System.Drawing.SystemColors.Menu;
            this.ZavrsiButton.Location = new System.Drawing.Point(12, 293);
            this.ZavrsiButton.Name = "ZavrsiButton";
            this.ZavrsiButton.Size = new System.Drawing.Size(380, 54);
            this.ZavrsiButton.TabIndex = 9;
            this.ZavrsiButton.Text = "Zavrsi";
            this.ZavrsiButton.UseVisualStyleBackColor = false;
            this.ZavrsiButton.Click += new System.EventHandler(this.ZavrsiButton_Click);
            // 
            // RazredComboBox
            // 
            this.RazredComboBox.FormattingEnabled = true;
            this.RazredComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.RazredComboBox.Location = new System.Drawing.Point(13, 180);
            this.RazredComboBox.Name = "RazredComboBox";
            this.RazredComboBox.Size = new System.Drawing.Size(379, 21);
            this.RazredComboBox.TabIndex = 10;
            // 
            // Unos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 360);
            this.Controls.Add(this.RazredComboBox);
            this.Controls.Add(this.ZavrsiButton);
            this.Controls.Add(this.UnosButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PrezimeTextBox);
            this.Controls.Add(this.ImeTextBox);
            this.Name = "Unos";
            this.Text = "Unos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImeTextBox;
        private System.Windows.Forms.TextBox PrezimeTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UnosButton;
        private System.Windows.Forms.Button ZavrsiButton;
        private System.Windows.Forms.ComboBox RazredComboBox;
    }
}