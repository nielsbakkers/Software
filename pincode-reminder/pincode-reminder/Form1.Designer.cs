namespace pincode_reminder
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
            this.textBoxGebruikersnaam = new System.Windows.Forms.TextBox();
            this.textBoxWachtwoord = new System.Windows.Forms.TextBox();
            this.labelGebruikersnaam = new System.Windows.Forms.Label();
            this.labelWachtwoord = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelGoed = new System.Windows.Forms.Label();
            this.labelFout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxGebruikersnaam
            // 
            this.textBoxGebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGebruikersnaam.Location = new System.Drawing.Point(167, 35);
            this.textBoxGebruikersnaam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGebruikersnaam.Name = "textBoxGebruikersnaam";
            this.textBoxGebruikersnaam.Size = new System.Drawing.Size(103, 23);
            this.textBoxGebruikersnaam.TabIndex = 0;
            // 
            // textBoxWachtwoord
            // 
            this.textBoxWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWachtwoord.Location = new System.Drawing.Point(167, 73);
            this.textBoxWachtwoord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxWachtwoord.Name = "textBoxWachtwoord";
            this.textBoxWachtwoord.Size = new System.Drawing.Size(103, 23);
            this.textBoxWachtwoord.TabIndex = 1;
            this.textBoxWachtwoord.UseSystemPasswordChar = true;
            this.textBoxWachtwoord.TextChanged += new System.EventHandler(this.textBoxWachtwoord_TextChanged);
            // 
            // labelGebruikersnaam
            // 
            this.labelGebruikersnaam.AutoSize = true;
            this.labelGebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGebruikersnaam.Location = new System.Drawing.Point(37, 36);
            this.labelGebruikersnaam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGebruikersnaam.Name = "labelGebruikersnaam";
            this.labelGebruikersnaam.Size = new System.Drawing.Size(122, 18);
            this.labelGebruikersnaam.TabIndex = 2;
            this.labelGebruikersnaam.Text = "Gebruikersnaam:";
            this.labelGebruikersnaam.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelWachtwoord
            // 
            this.labelWachtwoord.AutoSize = true;
            this.labelWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWachtwoord.Location = new System.Drawing.Point(62, 74);
            this.labelWachtwoord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWachtwoord.Name = "labelWachtwoord";
            this.labelWachtwoord.Size = new System.Drawing.Size(97, 18);
            this.labelWachtwoord.TabIndex = 3;
            this.labelWachtwoord.Text = "Wachtwoord:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(309, 64);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(91, 29);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Toon pincode";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelGoed
            // 
            this.labelGoed.AutoSize = true;
            this.labelGoed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoed.Location = new System.Drawing.Point(82, 112);
            this.labelGoed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGoed.Name = "labelGoed";
            this.labelGoed.Size = new System.Drawing.Size(336, 22);
            this.labelGoed.TabIndex = 5;
            this.labelGoed.Text = "Wachtwoord correct, de pincode is: 1472";
            this.labelGoed.Visible = false;
            // 
            // labelFout
            // 
            this.labelFout.AutoSize = true;
            this.labelFout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFout.ForeColor = System.Drawing.Color.Red;
            this.labelFout.Location = new System.Drawing.Point(67, 133);
            this.labelFout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFout.Name = "labelFout";
            this.labelFout.Size = new System.Drawing.Size(367, 44);
            this.labelFout.TabIndex = 6;
            this.labelFout.Text = "Gebruikersnaam of wachtwoord niet correct, \r\nprobeer het opnieuw.";
            this.labelFout.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 194);
            this.Controls.Add(this.labelFout);
            this.Controls.Add(this.labelGoed);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelWachtwoord);
            this.Controls.Add(this.labelGebruikersnaam);
            this.Controls.Add(this.textBoxWachtwoord);
            this.Controls.Add(this.textBoxGebruikersnaam);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Pincode-reminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGebruikersnaam;
        private System.Windows.Forms.TextBox textBoxWachtwoord;
        private System.Windows.Forms.Label labelGebruikersnaam;
        private System.Windows.Forms.Label labelWachtwoord;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelGoed;
        private System.Windows.Forms.Label labelFout;
    }
}

