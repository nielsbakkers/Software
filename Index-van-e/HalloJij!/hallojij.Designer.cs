namespace HalloJij_
{
    partial class hallojij
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
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.geslachtBox = new System.Windows.Forms.GroupBox();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rdVrouw = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.geslachtBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(146, 104);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 0;
            // 
            // geslachtBox
            // 
            this.geslachtBox.Controls.Add(this.rbMan);
            this.geslachtBox.Controls.Add(this.rdVrouw);
            this.geslachtBox.Location = new System.Drawing.Point(49, 143);
            this.geslachtBox.Name = "geslachtBox";
            this.geslachtBox.Size = new System.Drawing.Size(117, 92);
            this.geslachtBox.TabIndex = 1;
            this.geslachtBox.TabStop = false;
            this.geslachtBox.Text = "Geslacht";
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(17, 30);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(46, 17);
            this.rbMan.TabIndex = 1;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rdVrouw
            // 
            this.rdVrouw.AutoSize = true;
            this.rdVrouw.Checked = true;
            this.rdVrouw.Location = new System.Drawing.Point(18, 53);
            this.rdVrouw.Name = "rdVrouw";
            this.rdVrouw.Size = new System.Drawing.Size(55, 17);
            this.rdVrouw.TabIndex = 0;
            this.rdVrouw.TabStop = true;
            this.rdVrouw.Text = "Vrouw";
            this.rdVrouw.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(128, 267);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Maak groet";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(46, 39);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(185, 39);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Geef uw voor en achternaam op. \r\nVink vervolgens uw geslacht aan. \r\nDruk op de bu" +
    "tton en u wordt gegroet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Voor- achternaam:";
            // 
            // hallojij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.geslachtBox);
            this.Controls.Add(this.txtNaam);
            this.Name = "hallojij";
            this.Text = "Hallo jij!";
            this.geslachtBox.ResumeLayout(false);
            this.geslachtBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.GroupBox geslachtBox;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.RadioButton rdVrouw;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label1;
    }
}

