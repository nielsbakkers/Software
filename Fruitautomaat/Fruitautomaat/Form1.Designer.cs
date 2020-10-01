namespace Fruitautomaat
{
    partial class Ffruitautomaat
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
            this.components = new System.ComponentModel.Container();
            this.pbOne = new System.Windows.Forms.PictureBox();
            this.pbTwo = new System.Windows.Forms.PictureBox();
            this.pbThree = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThree)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOne
            // 
            this.pbOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOne.ErrorImage = null;
            this.pbOne.Location = new System.Drawing.Point(50, 96);
            this.pbOne.Name = "pbOne";
            this.pbOne.Size = new System.Drawing.Size(200, 200);
            this.pbOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOne.TabIndex = 0;
            this.pbOne.TabStop = false;
            // 
            // pbTwo
            // 
            this.pbTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTwo.ErrorImage = null;
            this.pbTwo.Location = new System.Drawing.Point(289, 96);
            this.pbTwo.Name = "pbTwo";
            this.pbTwo.Size = new System.Drawing.Size(200, 200);
            this.pbTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTwo.TabIndex = 1;
            this.pbTwo.TabStop = false;
            // 
            // pbThree
            // 
            this.pbThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbThree.ErrorImage = null;
            this.pbThree.Location = new System.Drawing.Point(528, 96);
            this.pbThree.Name = "pbThree";
            this.pbThree.Size = new System.Drawing.Size(200, 200);
            this.pbThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThree.TabIndex = 2;
            this.pbThree.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(354, 315);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(77, 33);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "RUN SLOT";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(45, 26);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(152, 29);
            this.lblTitel.TabIndex = 4;
            this.lblTitel.Text = "Fruitmachine";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(47, 57);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(473, 18);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Klik op de button, er worden vervolgens drie soorten fruit weergegeven.";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblWinner.Location = new System.Drawing.Point(538, 26);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(219, 55);
            this.lblWinner.TabIndex = 6;
            this.lblWinner.Text = "WINNER";
            this.lblWinner.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 200;
            // 
            // Ffruitautomaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 398);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pbThree);
            this.Controls.Add(this.pbTwo);
            this.Controls.Add(this.pbOne);
            this.Name = "Ffruitautomaat";
            this.Text = "Fruitautomaat";
            ((System.ComponentModel.ISupportInitialize)(this.pbOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOne;
        private System.Windows.Forms.PictureBox pbTwo;
        private System.Windows.Forms.PictureBox pbThree;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Timer timer;
    }
}

