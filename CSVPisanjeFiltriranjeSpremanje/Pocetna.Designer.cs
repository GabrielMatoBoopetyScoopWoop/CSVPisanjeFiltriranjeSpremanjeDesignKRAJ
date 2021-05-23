namespace CSVPisanjeFiltriranjeSpremanje
{
    partial class Pocetna
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
            this.PrikazButton = new System.Windows.Forms.Button();
            this.UnosButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PrikazButton
            // 
            this.PrikazButton.BackColor = System.Drawing.SystemColors.Menu;
            this.PrikazButton.Location = new System.Drawing.Point(12, 279);
            this.PrikazButton.Name = "PrikazButton";
            this.PrikazButton.Size = new System.Drawing.Size(385, 54);
            this.PrikazButton.TabIndex = 2;
            this.PrikazButton.Text = "Prikaz";
            this.PrikazButton.UseVisualStyleBackColor = false;
            this.PrikazButton.Click += new System.EventHandler(this.PrikazButton_Click);
            // 
            // UnosButton
            // 
            this.UnosButton.BackColor = System.Drawing.SystemColors.Menu;
            this.UnosButton.Location = new System.Drawing.Point(12, 219);
            this.UnosButton.Name = "UnosButton";
            this.UnosButton.Size = new System.Drawing.Size(385, 54);
            this.UnosButton.TabIndex = 3;
            this.UnosButton.Text = "Unos";
            this.UnosButton.UseVisualStyleBackColor = false;
            this.UnosButton.Click += new System.EventHandler(this.UnosTextBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSVPisanjeFiltriranjeSpremanje.Properties.Resources.CSV_Transformer_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 341);
            this.Controls.Add(this.UnosButton);
            this.Controls.Add(this.PrikazButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pocetna";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PrikazButton;
        private System.Windows.Forms.Button UnosButton;
    }
}

