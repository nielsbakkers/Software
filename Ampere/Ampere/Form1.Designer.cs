namespace Ampere
{
    partial class Ampere
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
            this.lblSpanning = new System.Windows.Forms.Label();
            this.lblStroom = new System.Windows.Forms.Label();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.nmrV = new System.Windows.Forms.NumericUpDown();
            this.nmrA = new System.Windows.Forms.NumericUpDown();
            this.lblUitleg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSpanning
            // 
            this.lblSpanning.AutoSize = true;
            this.lblSpanning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpanning.Location = new System.Drawing.Point(55, 72);
            this.lblSpanning.Name = "lblSpanning";
            this.lblSpanning.Size = new System.Drawing.Size(174, 20);
            this.lblSpanning.TabIndex = 0;
            this.lblSpanning.Text = "Vul de spanning in V in:";
            // 
            // lblStroom
            // 
            this.lblStroom.AutoSize = true;
            this.lblStroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStroom.Location = new System.Drawing.Point(71, 117);
            this.lblStroom.Name = "lblStroom";
            this.lblStroom.Size = new System.Drawing.Size(158, 20);
            this.lblStroom.TabIndex = 1;
            this.lblStroom.Text = "Vul de stroom in A in:";
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntwoord.Location = new System.Drawing.Point(55, 163);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(279, 22);
            this.lblAntwoord.TabIndex = 2;
            this.lblAntwoord.Text = "De weerstand is <antwoord> ohm";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(391, 90);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(83, 31);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Bereken";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // nmrV
            // 
            this.nmrV.DecimalPlaces = 1;
            this.nmrV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrV.Location = new System.Drawing.Point(235, 72);
            this.nmrV.Name = "nmrV";
            this.nmrV.Size = new System.Drawing.Size(120, 24);
            this.nmrV.TabIndex = 7;
            // 
            // nmrA
            // 
            this.nmrA.DecimalPlaces = 1;
            this.nmrA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrA.Location = new System.Drawing.Point(235, 113);
            this.nmrA.Name = "nmrA";
            this.nmrA.Size = new System.Drawing.Size(120, 24);
            this.nmrA.TabIndex = 8;
            // 
            // lblUitleg
            // 
            this.lblUitleg.AutoSize = true;
            this.lblUitleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUitleg.Location = new System.Drawing.Point(28, 20);
            this.lblUitleg.Name = "lblUitleg";
            this.lblUitleg.Size = new System.Drawing.Size(490, 34);
            this.lblUitleg.TabIndex = 9;
            this.lblUitleg.Text = "Vul de spanning en stroom in. \r\nKlik vervolgens op Bereken en het aantal benodigd" +
    "e ohm wordt uitgerekend.";
            // 
            // Ampere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 233);
            this.Controls.Add(this.lblUitleg);
            this.Controls.Add(this.nmrA);
            this.Controls.Add(this.nmrV);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.lblStroom);
            this.Controls.Add(this.lblSpanning);
            this.Name = "Ampere";
            this.Text = "Ampere";
            ((System.ComponentModel.ISupportInitialize)(this.nmrV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpanning;
        private System.Windows.Forms.Label lblStroom;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAntwoord;
        private System.Windows.Forms.NumericUpDown nmrV;
        private System.Windows.Forms.NumericUpDown nmrA;
        private System.Windows.Forms.Label lblUitleg;
    }
}

