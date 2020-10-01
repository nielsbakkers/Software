namespace bloeddruk_meten
{
    partial class bloedDrukmeter
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
            this.nmrLeeftijd = new System.Windows.Forms.NumericUpDown();
            this.lblLeeftijdU = new System.Windows.Forms.Label();
            this.boxGeslacht = new System.Windows.Forms.GroupBox();
            this.rbVrouw = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.boxBloeddruk = new System.Windows.Forms.GroupBox();
            this.lblBonder = new System.Windows.Forms.Label();
            this.lblBboven = new System.Windows.Forms.Label();
            this.nmrOnder = new System.Windows.Forms.NumericUpDown();
            this.nmrBoven = new System.Windows.Forms.NumericUpDown();
            this.lblNaamU = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblUitslag = new System.Windows.Forms.Label();
            this.boxUitkomst = new System.Windows.Forms.GroupBox();
            this.colorBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblNaamUitleg = new System.Windows.Forms.Label();
            this.lblLeeftijd = new System.Windows.Forms.Label();
            this.lblLeeftijdUitleg = new System.Windows.Forms.Label();
            this.lblUitslagUitleg = new System.Windows.Forms.Label();
            this.lblWarningUitleg = new System.Windows.Forms.Label();
            this.lblBloeddruk = new System.Windows.Forms.Label();
            this.lblUitleg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLeeftijd)).BeginInit();
            this.boxGeslacht.SuspendLayout();
            this.boxBloeddruk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrOnder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBoven)).BeginInit();
            this.boxUitkomst.SuspendLayout();
            this.SuspendLayout();
            // 
            // nmrLeeftijd
            // 
            this.nmrLeeftijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrLeeftijd.Location = new System.Drawing.Point(156, 139);
            this.nmrLeeftijd.Name = "nmrLeeftijd";
            this.nmrLeeftijd.Size = new System.Drawing.Size(42, 21);
            this.nmrLeeftijd.TabIndex = 0;
            // 
            // lblLeeftijdU
            // 
            this.lblLeeftijdU.AutoSize = true;
            this.lblLeeftijdU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeeftijdU.Location = new System.Drawing.Point(46, 141);
            this.lblLeeftijdU.Name = "lblLeeftijdU";
            this.lblLeeftijdU.Size = new System.Drawing.Size(104, 15);
            this.lblLeeftijdU.TabIndex = 1;
            this.lblLeeftijdU.Text = "Voer de leeftijd in:";
            // 
            // boxGeslacht
            // 
            this.boxGeslacht.Controls.Add(this.rbVrouw);
            this.boxGeslacht.Controls.Add(this.rbMan);
            this.boxGeslacht.Location = new System.Drawing.Point(49, 175);
            this.boxGeslacht.Name = "boxGeslacht";
            this.boxGeslacht.Size = new System.Drawing.Size(88, 70);
            this.boxGeslacht.TabIndex = 2;
            this.boxGeslacht.TabStop = false;
            this.boxGeslacht.Text = "Geslacht";
            // 
            // rbVrouw
            // 
            this.rbVrouw.AutoSize = true;
            this.rbVrouw.Location = new System.Drawing.Point(3, 47);
            this.rbVrouw.Name = "rbVrouw";
            this.rbVrouw.Size = new System.Drawing.Size(55, 17);
            this.rbVrouw.TabIndex = 1;
            this.rbVrouw.TabStop = true;
            this.rbVrouw.Text = "Vrouw";
            this.rbVrouw.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(3, 24);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(46, 17);
            this.rbMan.TabIndex = 0;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // boxBloeddruk
            // 
            this.boxBloeddruk.Controls.Add(this.lblBonder);
            this.boxBloeddruk.Controls.Add(this.lblBboven);
            this.boxBloeddruk.Controls.Add(this.nmrOnder);
            this.boxBloeddruk.Controls.Add(this.nmrBoven);
            this.boxBloeddruk.Location = new System.Drawing.Point(49, 262);
            this.boxBloeddruk.Name = "boxBloeddruk";
            this.boxBloeddruk.Size = new System.Drawing.Size(264, 79);
            this.boxBloeddruk.TabIndex = 3;
            this.boxBloeddruk.TabStop = false;
            this.boxBloeddruk.Text = "Bloeddruk";
            // 
            // lblBonder
            // 
            this.lblBonder.AutoSize = true;
            this.lblBonder.Location = new System.Drawing.Point(13, 49);
            this.lblBonder.Name = "lblBonder";
            this.lblBonder.Size = new System.Drawing.Size(108, 13);
            this.lblBonder.TabIndex = 5;
            this.lblBonder.Text = "Bloeddruk Onderdruk";
            // 
            // lblBboven
            // 
            this.lblBboven.AutoSize = true;
            this.lblBboven.Location = new System.Drawing.Point(13, 26);
            this.lblBboven.Name = "lblBboven";
            this.lblBboven.Size = new System.Drawing.Size(110, 13);
            this.lblBboven.TabIndex = 4;
            this.lblBboven.Text = "Bloeddruk Bovendruk";
            // 
            // nmrOnder
            // 
            this.nmrOnder.Location = new System.Drawing.Point(129, 42);
            this.nmrOnder.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmrOnder.Name = "nmrOnder";
            this.nmrOnder.Size = new System.Drawing.Size(120, 20);
            this.nmrOnder.TabIndex = 1;
            // 
            // nmrBoven
            // 
            this.nmrBoven.Location = new System.Drawing.Point(129, 19);
            this.nmrBoven.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmrBoven.Name = "nmrBoven";
            this.nmrBoven.Size = new System.Drawing.Size(120, 20);
            this.nmrBoven.TabIndex = 0;
            // 
            // lblNaamU
            // 
            this.lblNaamU.AutoSize = true;
            this.lblNaamU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaamU.Location = new System.Drawing.Point(46, 104);
            this.lblNaamU.Name = "lblNaamU";
            this.lblNaamU.Size = new System.Drawing.Size(44, 15);
            this.lblNaamU.TabIndex = 4;
            this.lblNaamU.Text = "Naam:";
            // 
            // txtNaam
            // 
            this.txtNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaam.Location = new System.Drawing.Point(96, 104);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(367, 247);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 37);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Bereken";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblUitslag
            // 
            this.lblUitslag.AutoSize = true;
            this.lblUitslag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUitslag.Location = new System.Drawing.Point(188, 120);
            this.lblUitslag.Name = "lblUitslag";
            this.lblUitslag.Size = new System.Drawing.Size(57, 15);
            this.lblUitslag.TabIndex = 7;
            this.lblUitslag.Text = "<uitslag>";
            // 
            // boxUitkomst
            // 
            this.boxUitkomst.Controls.Add(this.colorBox);
            this.boxUitkomst.Controls.Add(this.label1);
            this.boxUitkomst.Controls.Add(this.lblWarning);
            this.boxUitkomst.Controls.Add(this.lblNaam);
            this.boxUitkomst.Controls.Add(this.lblNaamUitleg);
            this.boxUitkomst.Controls.Add(this.lblLeeftijd);
            this.boxUitkomst.Controls.Add(this.lblLeeftijdUitleg);
            this.boxUitkomst.Controls.Add(this.lblUitslagUitleg);
            this.boxUitkomst.Controls.Add(this.lblWarningUitleg);
            this.boxUitkomst.Controls.Add(this.lblUitslag);
            this.boxUitkomst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUitkomst.Location = new System.Drawing.Point(341, 21);
            this.boxUitkomst.Name = "boxUitkomst";
            this.boxUitkomst.Size = new System.Drawing.Size(404, 195);
            this.boxUitkomst.TabIndex = 8;
            this.boxUitkomst.TabStop = false;
            this.boxUitkomst.Text = "Uitslag";
            // 
            // colorBox
            // 
            this.colorBox.Enabled = false;
            this.colorBox.Location = new System.Drawing.Point(198, 84);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(31, 23);
            this.colorBox.TabIndex = 18;
            this.colorBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Het geslacht van de patient is:";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(188, 143);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(65, 15);
            this.lblWarning.TabIndex = 16;
            this.lblWarning.Text = "<warning>";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(188, 29);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(53, 15);
            this.lblNaam.TabIndex = 13;
            this.lblNaam.Text = "<naam>";
            // 
            // lblNaamUitleg
            // 
            this.lblNaamUitleg.AutoSize = true;
            this.lblNaamUitleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaamUitleg.Location = new System.Drawing.Point(23, 29);
            this.lblNaamUitleg.Name = "lblNaamUitleg";
            this.lblNaamUitleg.Size = new System.Drawing.Size(152, 15);
            this.lblNaamUitleg.TabIndex = 12;
            this.lblNaamUitleg.Text = "De naam van de patient is:";
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.AutoSize = true;
            this.lblLeeftijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeeftijd.Location = new System.Drawing.Point(188, 57);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(57, 15);
            this.lblLeeftijd.TabIndex = 11;
            this.lblLeeftijd.Text = "<leeftijd>";
            // 
            // lblLeeftijdUitleg
            // 
            this.lblLeeftijdUitleg.AutoSize = true;
            this.lblLeeftijdUitleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeeftijdUitleg.Location = new System.Drawing.Point(23, 57);
            this.lblLeeftijdUitleg.Name = "lblLeeftijdUitleg";
            this.lblLeeftijdUitleg.Size = new System.Drawing.Size(156, 15);
            this.lblLeeftijdUitleg.TabIndex = 10;
            this.lblLeeftijdUitleg.Text = "De leeftijd van de patient is:";
            // 
            // lblUitslagUitleg
            // 
            this.lblUitslagUitleg.AutoSize = true;
            this.lblUitslagUitleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUitslagUitleg.Location = new System.Drawing.Point(23, 120);
            this.lblUitslagUitleg.Name = "lblUitslagUitleg";
            this.lblUitslagUitleg.Size = new System.Drawing.Size(145, 15);
            this.lblUitslagUitleg.TabIndex = 9;
            this.lblUitslagUitleg.Text = "Bloeddruk uitslag patient:";
            // 
            // lblWarningUitleg
            // 
            this.lblWarningUitleg.AutoSize = true;
            this.lblWarningUitleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningUitleg.Location = new System.Drawing.Point(112, 143);
            this.lblWarningUitleg.Name = "lblWarningUitleg";
            this.lblWarningUitleg.Size = new System.Drawing.Size(56, 15);
            this.lblWarningUitleg.TabIndex = 8;
            this.lblWarningUitleg.Text = "Warning:";
            // 
            // lblBloeddruk
            // 
            this.lblBloeddruk.AutoSize = true;
            this.lblBloeddruk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloeddruk.Location = new System.Drawing.Point(25, 20);
            this.lblBloeddruk.Name = "lblBloeddruk";
            this.lblBloeddruk.Size = new System.Drawing.Size(156, 22);
            this.lblBloeddruk.TabIndex = 9;
            this.lblBloeddruk.Text = "Bloeddruk meter";
            // 
            // lblUitleg
            // 
            this.lblUitleg.AutoSize = true;
            this.lblUitleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUitleg.Location = new System.Drawing.Point(35, 50);
            this.lblUitleg.Name = "lblUitleg";
            this.lblUitleg.Size = new System.Drawing.Size(264, 30);
            this.lblUitleg.TabIndex = 10;
            this.lblUitleg.Text = "Voer de benodigde gegevens in om een uitslag\r\nte krijgen over de bloeddruk van de" +
    " patient.";
            // 
            // bloedDrukmeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.lblUitleg);
            this.Controls.Add(this.lblBloeddruk);
            this.Controls.Add(this.boxUitkomst);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblNaamU);
            this.Controls.Add(this.boxBloeddruk);
            this.Controls.Add(this.boxGeslacht);
            this.Controls.Add(this.lblLeeftijdU);
            this.Controls.Add(this.nmrLeeftijd);
            this.Name = "bloedDrukmeter";
            this.Text = "Bloeddruk meter";
            ((System.ComponentModel.ISupportInitialize)(this.nmrLeeftijd)).EndInit();
            this.boxGeslacht.ResumeLayout(false);
            this.boxGeslacht.PerformLayout();
            this.boxBloeddruk.ResumeLayout(false);
            this.boxBloeddruk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrOnder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBoven)).EndInit();
            this.boxUitkomst.ResumeLayout(false);
            this.boxUitkomst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrLeeftijd;
        private System.Windows.Forms.Label lblLeeftijdU;
        private System.Windows.Forms.GroupBox boxGeslacht;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.RadioButton rbVrouw;
        private System.Windows.Forms.GroupBox boxBloeddruk;
        private System.Windows.Forms.Label lblBonder;
        private System.Windows.Forms.Label lblBboven;
        private System.Windows.Forms.NumericUpDown nmrOnder;
        private System.Windows.Forms.NumericUpDown nmrBoven;
        private System.Windows.Forms.Label lblNaamU;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblUitslag;
        private System.Windows.Forms.GroupBox boxUitkomst;
        private System.Windows.Forms.Label lblWarningUitleg;
        private System.Windows.Forms.Label lblUitslagUitleg;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblNaamUitleg;
        private System.Windows.Forms.Label lblLeeftijd;
        private System.Windows.Forms.Label lblLeeftijdUitleg;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button colorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBloeddruk;
        private System.Windows.Forms.Label lblUitleg;
    }
}

