namespace Producten
{
    partial class Fproducten
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMath = new System.Windows.Forms.Button();
            this.lbOverzicht = new System.Windows.Forms.ListBox();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gpProductenlijst = new System.Windows.Forms.GroupBox();
            this.lblTotaalPrijs = new System.Windows.Forms.Label();
            this.gpProductenlijst.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(137, 85);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(106, 18);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "Naam product:";
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijs.Location = new System.Drawing.Point(202, 118);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(41, 18);
            this.lblPrijs.TabIndex = 1;
            this.lblPrijs.Text = "Prijs:";
            // 
            // txtNaam
            // 
            this.txtNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaam.Location = new System.Drawing.Point(249, 84);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 23);
            this.txtNaam.TabIndex = 2;
            // 
            // txtPrijs
            // 
            this.txtPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrijs.Location = new System.Drawing.Point(249, 118);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(100, 23);
            this.txtPrijs.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(384, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMath
            // 
            this.btnMath.Location = new System.Drawing.Point(384, 124);
            this.btnMath.Name = "btnMath";
            this.btnMath.Size = new System.Drawing.Size(88, 36);
            this.btnMath.TabIndex = 5;
            this.btnMath.Text = "Bereken";
            this.btnMath.UseVisualStyleBackColor = true;
            this.btnMath.Click += new System.EventHandler(this.btnMath_Click);
            // 
            // lbOverzicht
            // 
            this.lbOverzicht.FormattingEnabled = true;
            this.lbOverzicht.Location = new System.Drawing.Point(15, 19);
            this.lbOverzicht.Name = "lbOverzicht";
            this.lbOverzicht.Size = new System.Drawing.Size(171, 186);
            this.lbOverzicht.TabIndex = 6;
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaal.Location = new System.Drawing.Point(413, 180);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(11, 16);
            this.lblTotaal.TabIndex = 7;
            this.lblTotaal.Text = ".";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(22, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(450, 30);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Voer een naam en een prijs van een product in. \r\nKlik vervolgens op Toevoegen om " +
    "het product toe te voegen aan de productenlijst.";
            // 
            // gpProductenlijst
            // 
            this.gpProductenlijst.Controls.Add(this.lbOverzicht);
            this.gpProductenlijst.Location = new System.Drawing.Point(491, 20);
            this.gpProductenlijst.Name = "gpProductenlijst";
            this.gpProductenlijst.Size = new System.Drawing.Size(201, 216);
            this.gpProductenlijst.TabIndex = 9;
            this.gpProductenlijst.TabStop = false;
            this.gpProductenlijst.Text = "Productenlijst";
            // 
            // lblTotaalPrijs
            // 
            this.lblTotaalPrijs.AutoSize = true;
            this.lblTotaalPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaalPrijs.Location = new System.Drawing.Point(329, 180);
            this.lblTotaalPrijs.Name = "lblTotaalPrijs";
            this.lblTotaalPrijs.Size = new System.Drawing.Size(78, 16);
            this.lblTotaalPrijs.TabIndex = 10;
            this.lblTotaalPrijs.Text = "Totaal prijs:";
            // 
            // Fproducten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 285);
            this.Controls.Add(this.lblTotaalPrijs);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.gpProductenlijst);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnMath);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.lblNaam);
            this.Name = "Fproducten";
            this.Text = "Producten";
            this.gpProductenlijst.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMath;
        private System.Windows.Forms.ListBox lbOverzicht;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox gpProductenlijst;
        private System.Windows.Forms.Label lblTotaalPrijs;
    }
}

