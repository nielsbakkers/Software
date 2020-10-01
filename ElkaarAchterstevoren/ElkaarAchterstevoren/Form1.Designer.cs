namespace ElkaarAchterstevoren
{
    partial class FormElkaarAchterstevoren
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.lblUitleg = new System.Windows.Forms.Label();
            this.lblUitlegAntwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(408, 69);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(84, 31);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(302, 71);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 24);
            this.txtInput.TabIndex = 1;
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntwoord.Location = new System.Drawing.Point(167, 69);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(58, 15);
            this.lblAntwoord.TabIndex = 2;
            this.lblAntwoord.Text = "antwoord";
            // 
            // lblUitleg
            // 
            this.lblUitleg.AutoSize = true;
            this.lblUitleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUitleg.Location = new System.Drawing.Point(24, 12);
            this.lblUitleg.Name = "lblUitleg";
            this.lblUitleg.Size = new System.Drawing.Size(424, 40);
            this.lblUitleg.TabIndex = 3;
            this.lblUitleg.Text = "Voer één woord in en klik op Check. \r\nEr wordt nu gekeken of het woord omgedraaid" +
    " hetzelfde is.";
            // 
            // lblUitlegAntwoord
            // 
            this.lblUitlegAntwoord.AutoSize = true;
            this.lblUitlegAntwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUitlegAntwoord.Location = new System.Drawing.Point(25, 69);
            this.lblUitlegAntwoord.Name = "lblUitlegAntwoord";
            this.lblUitlegAntwoord.Size = new System.Drawing.Size(136, 15);
            this.lblUitlegAntwoord.TabIndex = 4;
            this.lblUitlegAntwoord.Text = "Is het woordt hetzelfde?";
            // 
            // FormElkaarAchterstevoren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 142);
            this.Controls.Add(this.lblUitlegAntwoord);
            this.Controls.Add(this.lblUitleg);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCheck);
            this.Name = "FormElkaarAchterstevoren";
            this.Text = "Elkaar Achterstevoren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblAntwoord;
        private System.Windows.Forms.Label lblUitleg;
        private System.Windows.Forms.Label lblUitlegAntwoord;
    }
}

