namespace Worpengenerator
{
    partial class worpengenerator
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
            this.rb = new System.Windows.Forms.ListBox();
            this.instellingenBox = new System.Windows.Forms.GroupBox();
            this.lblOgen = new System.Windows.Forms.Label();
            this.ogen = new System.Windows.Forms.NumericUpDown();
            this.lblWorpen = new System.Windows.Forms.Label();
            this.btnGooi = new System.Windows.Forms.Button();
            this.worpen = new System.Windows.Forms.NumericUpDown();
            this.resultaatBox = new System.Windows.Forms.GroupBox();
            this.lblLaagst = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.lnlH = new System.Windows.Forms.Label();
            this.lblHoogst = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aantal = new System.Windows.Forms.Label();
            this.instellingenBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worpen)).BeginInit();
            this.resultaatBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb
            // 
            this.rb.FormattingEnabled = true;
            this.rb.Location = new System.Drawing.Point(14, 40);
            this.rb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(204, 160);
            this.rb.TabIndex = 0;
            // 
            // instellingenBox
            // 
            this.instellingenBox.Controls.Add(this.lblOgen);
            this.instellingenBox.Controls.Add(this.ogen);
            this.instellingenBox.Controls.Add(this.lblWorpen);
            this.instellingenBox.Controls.Add(this.btnGooi);
            this.instellingenBox.Controls.Add(this.worpen);
            this.instellingenBox.Location = new System.Drawing.Point(26, 26);
            this.instellingenBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.instellingenBox.Name = "instellingenBox";
            this.instellingenBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.instellingenBox.Size = new System.Drawing.Size(224, 136);
            this.instellingenBox.TabIndex = 1;
            this.instellingenBox.TabStop = false;
            this.instellingenBox.Text = "Instellingen";
            // 
            // lblOgen
            // 
            this.lblOgen.AutoSize = true;
            this.lblOgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgen.Location = new System.Drawing.Point(17, 70);
            this.lblOgen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOgen.Name = "lblOgen";
            this.lblOgen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOgen.Size = new System.Drawing.Size(88, 17);
            this.lblOgen.TabIndex = 4;
            this.lblOgen.Text = "Aantal ogen:";
            // 
            // ogen
            // 
            this.ogen.Location = new System.Drawing.Point(122, 71);
            this.ogen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ogen.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ogen.Name = "ogen";
            this.ogen.Size = new System.Drawing.Size(90, 20);
            this.ogen.TabIndex = 3;
            this.ogen.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lblWorpen
            // 
            this.lblWorpen.AutoSize = true;
            this.lblWorpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorpen.Location = new System.Drawing.Point(17, 39);
            this.lblWorpen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorpen.Name = "lblWorpen";
            this.lblWorpen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWorpen.Size = new System.Drawing.Size(102, 17);
            this.lblWorpen.TabIndex = 2;
            this.lblWorpen.Text = "Aantal worpen:";
            // 
            // btnGooi
            // 
            this.btnGooi.Location = new System.Drawing.Point(89, 101);
            this.btnGooi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGooi.Name = "btnGooi";
            this.btnGooi.Size = new System.Drawing.Size(122, 22);
            this.btnGooi.TabIndex = 1;
            this.btnGooi.Text = "Gooi dobbelsteen!";
            this.btnGooi.UseVisualStyleBackColor = true;
            this.btnGooi.Click += new System.EventHandler(this.button1_Click);
            // 
            // worpen
            // 
            this.worpen.Location = new System.Drawing.Point(122, 40);
            this.worpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.worpen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.worpen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.worpen.Name = "worpen";
            this.worpen.Size = new System.Drawing.Size(90, 20);
            this.worpen.TabIndex = 0;
            this.worpen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // resultaatBox
            // 
            this.resultaatBox.Controls.Add(this.lblLaagst);
            this.resultaatBox.Controls.Add(this.lblL);
            this.resultaatBox.Controls.Add(this.lnlH);
            this.resultaatBox.Controls.Add(this.lblHoogst);
            this.resultaatBox.Controls.Add(this.label7);
            this.resultaatBox.Controls.Add(this.lblTotaal);
            this.resultaatBox.Controls.Add(this.lblW);
            this.resultaatBox.Controls.Add(this.rb);
            this.resultaatBox.Location = new System.Drawing.Point(274, 26);
            this.resultaatBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultaatBox.Name = "resultaatBox";
            this.resultaatBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultaatBox.Size = new System.Drawing.Size(230, 271);
            this.resultaatBox.TabIndex = 3;
            this.resultaatBox.TabStop = false;
            this.resultaatBox.Text = "Resultaat";
            // 
            // lblLaagst
            // 
            this.lblLaagst.AutoSize = true;
            this.lblLaagst.Location = new System.Drawing.Point(174, 246);
            this.lblLaagst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLaagst.Name = "lblLaagst";
            this.lblLaagst.Size = new System.Drawing.Size(13, 13);
            this.lblLaagst.TabIndex = 8;
            this.lblLaagst.Text = "0";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(86, 246);
            this.lblL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(83, 13);
            this.lblL.TabIndex = 7;
            this.lblL.Text = "Laagst gegooid:";
            // 
            // lnlH
            // 
            this.lnlH.AutoSize = true;
            this.lnlH.Location = new System.Drawing.Point(85, 228);
            this.lnlH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnlH.Name = "lnlH";
            this.lnlH.Size = new System.Drawing.Size(85, 13);
            this.lnlH.TabIndex = 6;
            this.lnlH.Text = "Hoogst gegooid:";
            // 
            // lblHoogst
            // 
            this.lblHoogst.AutoSize = true;
            this.lblHoogst.Location = new System.Drawing.Point(174, 228);
            this.lblHoogst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoogst.Name = "lblHoogst";
            this.lblHoogst.Size = new System.Drawing.Size(13, 13);
            this.lblHoogst.TabIndex = 5;
            this.lblHoogst.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-203, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Totaal aantal ogen:";
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Location = new System.Drawing.Point(71, 212);
            this.lblTotaal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(99, 13);
            this.lblTotaal.TabIndex = 2;
            this.lblTotaal.Text = "Totaal aantal ogen:";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.Location = new System.Drawing.Point(11, 23);
            this.lblW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(51, 15);
            this.lblW.TabIndex = 1;
            this.lblW.Text = "worpen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 3;
            // 
            // aantal
            // 
            this.aantal.AutoSize = true;
            this.aantal.Location = new System.Drawing.Point(448, 238);
            this.aantal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aantal.Name = "aantal";
            this.aantal.Size = new System.Drawing.Size(13, 13);
            this.aantal.TabIndex = 3;
            this.aantal.Text = "0";
            // 
            // worpengenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 307);
            this.Controls.Add(this.aantal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultaatBox);
            this.Controls.Add(this.instellingenBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "worpengenerator";
            this.Text = "Worpengenerator";
            this.instellingenBox.ResumeLayout(false);
            this.instellingenBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worpen)).EndInit();
            this.resultaatBox.ResumeLayout(false);
            this.resultaatBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox rb;
        private System.Windows.Forms.GroupBox instellingenBox;
        private System.Windows.Forms.Label lblWorpen;
        private System.Windows.Forms.Button btnGooi;
        private System.Windows.Forms.NumericUpDown worpen;
        private System.Windows.Forms.GroupBox resultaatBox;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.Label lblOgen;
        private System.Windows.Forms.NumericUpDown ogen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label aantal;
        private System.Windows.Forms.Label lblLaagst;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lnlH;
        private System.Windows.Forms.Label lblHoogst;
        private System.Windows.Forms.Label label7;
    }
}

