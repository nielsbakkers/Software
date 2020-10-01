namespace wachtwoord_check
{
    partial class WachtwoordChecker
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
            this.boxWachtwoord = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelWachtwoord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSterkte = new System.Windows.Forms.Panel();
            this.labelSterkte = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxWachtwoord
            // 
            this.boxWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxWachtwoord.Location = new System.Drawing.Point(196, 33);
            this.boxWachtwoord.Name = "boxWachtwoord";
            this.boxWachtwoord.Size = new System.Drawing.Size(186, 28);
            this.boxWachtwoord.TabIndex = 0;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(317, 135);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(92, 38);
            this.buttonCheck.TabIndex = 1;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelWachtwoord
            // 
            this.labelWachtwoord.AutoSize = true;
            this.labelWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWachtwoord.Location = new System.Drawing.Point(37, 33);
            this.labelWachtwoord.Name = "labelWachtwoord";
            this.labelWachtwoord.Size = new System.Drawing.Size(128, 25);
            this.labelWachtwoord.TabIndex = 3;
            this.labelWachtwoord.Text = "Wachtwoord:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 102);
            this.label1.TabIndex = 4;
            this.label1.Text = "Legenda:\r\ngroen - Sterk\r\nrood - zwak\r\nzwart - zeer zwak\r\ngeel - middelmatig\r\n\r\n";
            // 
            // panelSterkte
            // 
            this.panelSterkte.Location = new System.Drawing.Point(268, 92);
            this.panelSterkte.Name = "panelSterkte";
            this.panelSterkte.Size = new System.Drawing.Size(124, 26);
            this.panelSterkte.TabIndex = 5;
            this.panelSterkte.Visible = false;
            // 
            // labelSterkte
            // 
            this.labelSterkte.AutoSize = true;
            this.labelSterkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSterkte.Location = new System.Drawing.Point(197, 92);
            this.labelSterkte.Name = "labelSterkte";
            this.labelSterkte.Size = new System.Drawing.Size(65, 20);
            this.labelSterkte.TabIndex = 0;
            this.labelSterkte.Text = "sterkte:";
            this.labelSterkte.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "sterkte:";
            this.label2.Visible = false;
            // 
            // WachtwoordChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 194);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSterkte);
            this.Controls.Add(this.panelSterkte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWachtwoord);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.boxWachtwoord);
            this.Name = "WachtwoordChecker";
            this.Text = "WachtwoordChecker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxWachtwoord;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelWachtwoord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSterkte;
        private System.Windows.Forms.Label labelSterkte;
        private System.Windows.Forms.Label label2;
    }
}

