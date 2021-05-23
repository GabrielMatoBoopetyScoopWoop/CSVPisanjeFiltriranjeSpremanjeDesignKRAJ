namespace CSVPisanjeFiltriranjeSpremanje
{
    partial class Pregled
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
            this.UcitajButton = new System.Windows.Forms.Button();
            this.TekstKutija = new System.Windows.Forms.RichTextBox();
            this.FiltrirajButton = new System.Windows.Forms.Button();
            this.OdustaniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UcitajButton
            // 
            this.UcitajButton.Location = new System.Drawing.Point(12, 12);
            this.UcitajButton.Name = "UcitajButton";
            this.UcitajButton.Size = new System.Drawing.Size(130, 23);
            this.UcitajButton.TabIndex = 0;
            this.UcitajButton.Text = "Učitaj dokument";
            this.UcitajButton.UseVisualStyleBackColor = true;
            this.UcitajButton.Click += new System.EventHandler(this.UcitajButton_Click);
            // 
            // TekstKutija
            // 
            this.TekstKutija.Location = new System.Drawing.Point(12, 41);
            this.TekstKutija.Name = "TekstKutija";
            this.TekstKutija.ReadOnly = true;
            this.TekstKutija.Size = new System.Drawing.Size(402, 338);
            this.TekstKutija.TabIndex = 3;
            this.TekstKutija.Text = "";
            // 
            // FiltrirajButton
            // 
            this.FiltrirajButton.Location = new System.Drawing.Point(148, 12);
            this.FiltrirajButton.Name = "FiltrirajButton";
            this.FiltrirajButton.Size = new System.Drawing.Size(130, 23);
            this.FiltrirajButton.TabIndex = 4;
            this.FiltrirajButton.Text = "Filtriraj";
            this.FiltrirajButton.UseVisualStyleBackColor = true;
            this.FiltrirajButton.Click += new System.EventHandler(this.FiltrirajButton_Click);
            // 
            // OdustaniButton
            // 
            this.OdustaniButton.Location = new System.Drawing.Point(284, 12);
            this.OdustaniButton.Name = "OdustaniButton";
            this.OdustaniButton.Size = new System.Drawing.Size(130, 23);
            this.OdustaniButton.TabIndex = 5;
            this.OdustaniButton.Text = "Odustani";
            this.OdustaniButton.UseVisualStyleBackColor = true;
            this.OdustaniButton.Click += new System.EventHandler(this.OdustaniButton_Click);
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 391);
            this.Controls.Add(this.OdustaniButton);
            this.Controls.Add(this.FiltrirajButton);
            this.Controls.Add(this.TekstKutija);
            this.Controls.Add(this.UcitajButton);
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UcitajButton;
        private System.Windows.Forms.RichTextBox TekstKutija;
        private System.Windows.Forms.Button FiltrirajButton;
        private System.Windows.Forms.Button OdustaniButton;
    }
}