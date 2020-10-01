namespace MaalDrie
{
    partial class FmaalDrie
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
            this.btnSom = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTextBox = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.antwoordenBox = new System.Windows.Forms.GroupBox();
            this.antwoordenList = new System.Windows.Forms.ListBox();
            this.antwoordenBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSom
            // 
            this.btnSom.Location = new System.Drawing.Point(205, 80);
            this.btnSom.Name = "btnSom";
            this.btnSom.Size = new System.Drawing.Size(112, 31);
            this.btnSom.TabIndex = 8;
            this.btnSom.Text = "Vermenigvuldig";
            this.btnSom.UseVisualStyleBackColor = true;
            this.btnSom.Click += new System.EventHandler(this.btnSom_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(23, 51);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(268, 36);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.Text = "Het ingevoerde getal wordt automatisch\r\nvermenigvuldigd.";
            // 
            // lblTextBox
            // 
            this.lblTextBox.AutoSize = true;
            this.lblTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextBox.Location = new System.Drawing.Point(23, 25);
            this.lblTextBox.Name = "lblTextBox";
            this.lblTextBox.Size = new System.Drawing.Size(121, 18);
            this.lblTextBox.TabIndex = 9;
            this.lblTextBox.Text = "Voer een getal in:";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(150, 25);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 23);
            this.txtB.TabIndex = 7;
            // 
            // antwoordenBox
            // 
            this.antwoordenBox.Controls.Add(this.antwoordenList);
            this.antwoordenBox.Location = new System.Drawing.Point(340, 25);
            this.antwoordenBox.Name = "antwoordenBox";
            this.antwoordenBox.Size = new System.Drawing.Size(169, 172);
            this.antwoordenBox.TabIndex = 6;
            this.antwoordenBox.TabStop = false;
            this.antwoordenBox.Text = "antwoorden";
            // 
            // antwoordenList
            // 
            this.antwoordenList.FormattingEnabled = true;
            this.antwoordenList.Location = new System.Drawing.Point(6, 19);
            this.antwoordenList.Name = "antwoordenList";
            this.antwoordenList.Size = new System.Drawing.Size(148, 147);
            this.antwoordenList.TabIndex = 0;
            // 
            // FmaalDrie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 274);
            this.Controls.Add(this.btnSom);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTextBox);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.antwoordenBox);
            this.Name = "FmaalDrie";
            this.Text = "MaalDrie";
            this.antwoordenBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSom;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTextBox;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.GroupBox antwoordenBox;
        private System.Windows.Forms.ListBox antwoordenList;
    }
}

