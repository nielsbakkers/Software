namespace Woorden_applicatie
{
    partial class woordenapplicatie
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
            this.gpProductenlijst = new System.Windows.Forms.GroupBox();
            this.lbOverzicht = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.gpProductenlijst.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpProductenlijst
            // 
            this.gpProductenlijst.Controls.Add(this.lbOverzicht);
            this.gpProductenlijst.Location = new System.Drawing.Point(342, 18);
            this.gpProductenlijst.Name = "gpProductenlijst";
            this.gpProductenlijst.Size = new System.Drawing.Size(201, 216);
            this.gpProductenlijst.TabIndex = 19;
            this.gpProductenlijst.TabStop = false;
            this.gpProductenlijst.Text = "woordenlijst";
            // 
            // lbOverzicht
            // 
            this.lbOverzicht.FormattingEnabled = true;
            this.lbOverzicht.Location = new System.Drawing.Point(15, 19);
            this.lbOverzicht.Name = "lbOverzicht";
            this.lbOverzicht.Size = new System.Drawing.Size(171, 186);
            this.lbOverzicht.TabIndex = 6;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(28, 18);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(288, 15);
            this.lblInfo.TabIndex = 18;
            this.lblInfo.Text = "Voer verschillende woorden toe aan de woordenlijst";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(195, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 36);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNaam
            // 
            this.txtNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaam.Location = new System.Drawing.Point(183, 52);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 23);
            this.txtNaam.TabIndex = 13;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(119, 53);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(58, 18);
            this.lblNaam.TabIndex = 11;
            this.lblNaam.Text = "Woord:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(66, 146);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(46, 17);
            this.lblError.TabIndex = 20;
            this.lblError.Text = "label1";
            this.lblError.Visible = false;
            // 
            // woordenapplicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 255);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.gpProductenlijst);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblNaam);
            this.Name = "woordenapplicatie";
            this.Text = "Woorden applicatie";
            this.gpProductenlijst.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpProductenlijst;
        private System.Windows.Forms.ListBox lbOverzicht;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblError;
    }
}

