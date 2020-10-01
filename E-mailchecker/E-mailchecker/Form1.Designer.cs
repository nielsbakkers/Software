namespace E_mailchecker
{
    partial class Femail
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOne = new System.Windows.Forms.CheckBox();
            this.cbTwo = new System.Windows.Forms.CheckBox();
            this.cbThree = new System.Windows.Forms.CheckBox();
            this.cbFour = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(174, 72);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voer uw e-mail in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(619, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Voer uw email in en klik vervolgens op de button. Er wordt gecontrolleerd of het " +
    "een juist email is.";
            // 
            // cbOne
            // 
            this.cbOne.AutoSize = true;
            this.cbOne.Location = new System.Drawing.Point(21, 36);
            this.cbOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbOne.Name = "cbOne";
            this.cbOne.Size = new System.Drawing.Size(255, 21);
            this.cbOne.TabIndex = 3;
            this.cbOne.Text = "Er moet een punt in de string zitten.";
            this.cbOne.UseVisualStyleBackColor = true;
            // 
            // cbTwo
            // 
            this.cbTwo.AutoSize = true;
            this.cbTwo.Location = new System.Drawing.Point(21, 65);
            this.cbTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTwo.Name = "cbTwo";
            this.cbTwo.Size = new System.Drawing.Size(298, 21);
            this.cbTwo.TabIndex = 4;
            this.cbTwo.Text = "Er moet een @-symbool in de string zitten.";
            this.cbTwo.UseVisualStyleBackColor = true;
            // 
            // cbThree
            // 
            this.cbThree.AutoSize = true;
            this.cbThree.Location = new System.Drawing.Point(21, 94);
            this.cbThree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbThree.Name = "cbThree";
            this.cbThree.Size = new System.Drawing.Size(284, 21);
            this.cbThree.TabIndex = 5;
            this.cbThree.Text = "De punt moet na het @-symbool komen.";
            this.cbThree.UseVisualStyleBackColor = true;
            // 
            // cbFour
            // 
            this.cbFour.AutoSize = true;
            this.cbFour.Location = new System.Drawing.Point(21, 123);
            this.cbFour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFour.Name = "cbFour";
            this.cbFour.Size = new System.Drawing.Size(379, 21);
            this.cbFour.TabIndex = 6;
            this.cbFour.Text = "De string moet een valide domein bevatten op het eind.";
            this.cbFour.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbOne);
            this.groupBox1.Controls.Add(this.cbFour);
            this.groupBox1.Controls.Add(this.cbTwo);
            this.groupBox1.Controls.Add(this.cbThree);
            this.groupBox1.Location = new System.Drawing.Point(33, 121);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(421, 172);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checker";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(372, 72);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 28);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "check e-mail";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Femail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 395);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Femail";
            this.Text = "E-mail Checker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbOne;
        private System.Windows.Forms.CheckBox cbTwo;
        private System.Windows.Forms.CheckBox cbThree;
        private System.Windows.Forms.CheckBox cbFour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheck;
    }
}

