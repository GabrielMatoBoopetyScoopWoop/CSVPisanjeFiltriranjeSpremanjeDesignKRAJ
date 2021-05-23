namespace CSVPisanjeFiltriranjeSpremanje
{
    partial class Filtriranje
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
            this.ZavrsiButton = new System.Windows.Forms.Button();
            this.FiltrirajButton = new System.Windows.Forms.Button();
            this.RazredComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PrezimeTextBox = new System.Windows.Forms.TextBox();
            this.ImeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ZavrsiButton
            // 
            this.ZavrsiButton.BackColor = System.Drawing.SystemColors.Menu;
            this.ZavrsiButton.Location = new System.Drawing.Point(12, 290);
            this.ZavrsiButton.Name = "ZavrsiButton";
            this.ZavrsiButton.Size = new System.Drawing.Size(380, 54);
            this.ZavrsiButton.TabIndex = 10;
            this.ZavrsiButton.Text = "Zavrsi";
            this.ZavrsiButton.UseVisualStyleBackColor = false;
            this.ZavrsiButton.Click += new System.EventHandler(this.ZavrsiButton_Click);
            // 
            // FiltrirajButton
            // 
            this.FiltrirajButton.BackColor = System.Drawing.SystemColors.Menu;
            this.FiltrirajButton.Location = new System.Drawing.Point(12, 230);
            this.FiltrirajButton.Name = "FiltrirajButton";
            this.FiltrirajButton.Size = new System.Drawing.Size(380, 54);
            this.FiltrirajButton.TabIndex = 11;
            this.FiltrirajButton.Text = "Filtriraj";
            this.FiltrirajButton.UseVisualStyleBackColor = false;
            this.FiltrirajButton.Click += new System.EventHandler(this.FiltrirajButton_Click);
            // 
            // RazredComboBox
            // 
            this.RazredComboBox.FormattingEnabled = true;
            this.RazredComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.RazredComboBox.Location = new System.Drawing.Point(13, 173);
            this.RazredComboBox.Name = "RazredComboBox";
            this.RazredComboBox.Size = new System.Drawing.Size(379, 21);
            this.RazredComboBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Razred";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prezime";
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(9, 39);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(24, 13);
            this.Ime.TabIndex = 15;
            this.Ime.Text = "Ime";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(12, 133);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(380, 20);
            this.EmailTextBox.TabIndex = 14;
            // 
            // PrezimeTextBox
            // 
            this.PrezimeTextBox.Location = new System.Drawing.Point(12, 94);
            this.PrezimeTextBox.Name = "PrezimeTextBox";
            this.PrezimeTextBox.Size = new System.Drawing.Size(380, 20);
            this.PrezimeTextBox.TabIndex = 13;
            // 
            // ImeTextBox
            // 
            this.ImeTextBox.Location = new System.Drawing.Point(12, 55);
            this.ImeTextBox.Name = "ImeTextBox";
            this.ImeTextBox.Size = new System.Drawing.Size(380, 20);
            this.ImeTextBox.TabIndex = 12;
            // 
            // Filtriranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 354);
            this.Controls.Add(this.RazredComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PrezimeTextBox);
            this.Controls.Add(this.ImeTextBox);
            this.Controls.Add(this.FiltrirajButton);
            this.Controls.Add(this.ZavrsiButton);
            this.Name = "Filtriranje";
            this.Text = "Filtriranje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZavrsiButton;
        private System.Windows.Forms.Button FiltrirajButton;
        private System.Windows.Forms.ComboBox RazredComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PrezimeTextBox;
        private System.Windows.Forms.TextBox ImeTextBox;
    }
}