namespace hetgoedegetal
{
    partial class Raadhetgetal
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
            this.getallenList = new System.Windows.Forms.ListBox();
            this.listBox = new System.Windows.Forms.GroupBox();
            this.btnRaad = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.intInput = new System.Windows.Forms.NumericUpDown();
            this.listBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intInput)).BeginInit();
            this.SuspendLayout();
            // 
            // getallenList
            // 
            this.getallenList.FormattingEnabled = true;
            this.getallenList.Location = new System.Drawing.Point(4, 17);
            this.getallenList.Margin = new System.Windows.Forms.Padding(2);
            this.getallenList.Name = "getallenList";
            this.getallenList.Size = new System.Drawing.Size(154, 108);
            this.getallenList.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.Controls.Add(this.getallenList);
            this.listBox.Location = new System.Drawing.Point(313, 21);
            this.listBox.Margin = new System.Windows.Forms.Padding(2);
            this.listBox.Name = "listBox";
            this.listBox.Padding = new System.Windows.Forms.Padding(2);
            this.listBox.Size = new System.Drawing.Size(162, 130);
            this.listBox.TabIndex = 1;
            this.listBox.TabStop = false;
            this.listBox.Text = "Geraden getallen";
            // 
            // btnRaad
            // 
            this.btnRaad.Location = new System.Drawing.Point(176, 103);
            this.btnRaad.Margin = new System.Windows.Forms.Padding(2);
            this.btnRaad.Name = "btnRaad";
            this.btnRaad.Size = new System.Drawing.Size(123, 28);
            this.btnRaad.TabIndex = 0;
            this.btnRaad.Text = "Getal trekken";
            this.btnRaad.UseVisualStyleBackColor = true;
            this.btnRaad.Click += new System.EventHandler(this.btnRaad_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(21, 35);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(209, 40);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Voer een willekeurig getal in:\r\nTussen de 1 en 10.\r\n";
            // 
            // intInput
            // 
            this.intInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intInput.Location = new System.Drawing.Point(237, 35);
            this.intInput.Margin = new System.Windows.Forms.Padding(2);
            this.intInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.intInput.Name = "intInput";
            this.intInput.Size = new System.Drawing.Size(62, 24);
            this.intInput.TabIndex = 3;
            this.intInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intInput.Click += new System.EventHandler(this.input_Changed);
            // 
            // Raadhetgetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 202);
            this.Controls.Add(this.intInput);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnRaad);
            this.Controls.Add(this.listBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Raadhetgetal";
            this.Text = "Raad het getal";
            this.listBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox getallenList;
        private System.Windows.Forms.GroupBox listBox;
        private System.Windows.Forms.Button btnRaad;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.NumericUpDown intInput;
    }
}

