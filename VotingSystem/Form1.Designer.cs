namespace VotingSystem
{
    partial class FormVoting
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
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.lblOIB = new System.Windows.Forms.Label();
            this.cbBoxOption = new System.Windows.Forms.ComboBox();
            this.txtOption = new System.Windows.Forms.Label();
            this.btnVote = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblForSum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAgainstSum = new System.Windows.Forms.Label();
            this.lblAbstainedSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(25, 50);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(203, 22);
            this.txtOIB.TabIndex = 0;
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Location = new System.Drawing.Point(22, 22);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(66, 16);
            this.lblOIB.TabIndex = 1;
            this.lblOIB.Text = "Enter OIB:";
            // 
            // cbBoxOption
            // 
            this.cbBoxOption.FormattingEnabled = true;
            this.cbBoxOption.Items.AddRange(new object[] {
            "FOR",
            "AGAINST",
            "ABSTAINED"});
            this.cbBoxOption.Location = new System.Drawing.Point(25, 121);
            this.cbBoxOption.Name = "cbBoxOption";
            this.cbBoxOption.Size = new System.Drawing.Size(121, 24);
            this.cbBoxOption.TabIndex = 2;
            // 
            // txtOption
            // 
            this.txtOption.AutoSize = true;
            this.txtOption.Location = new System.Drawing.Point(22, 96);
            this.txtOption.Name = "txtOption";
            this.txtOption.Size = new System.Drawing.Size(97, 16);
            this.txtOption.TabIndex = 3;
            this.txtOption.Text = "Choose option:";
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(153, 121);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(75, 23);
            this.btnVote.TabIndex = 4;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vote results:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "FOR:";
            // 
            // lblForSum
            // 
            this.lblForSum.AutoSize = true;
            this.lblForSum.Location = new System.Drawing.Point(366, 50);
            this.lblForSum.Name = "lblForSum";
            this.lblForSum.Size = new System.Drawing.Size(14, 16);
            this.lblForSum.TabIndex = 7;
            this.lblForSum.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "AGAINST:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "ABSTAINED:";
            // 
            // lblAgainstSum
            // 
            this.lblAgainstSum.AutoSize = true;
            this.lblAgainstSum.Location = new System.Drawing.Point(366, 83);
            this.lblAgainstSum.Name = "lblAgainstSum";
            this.lblAgainstSum.Size = new System.Drawing.Size(14, 16);
            this.lblAgainstSum.TabIndex = 11;
            this.lblAgainstSum.Text = "0";
            // 
            // lblAbstainedSum
            // 
            this.lblAbstainedSum.AutoSize = true;
            this.lblAbstainedSum.Location = new System.Drawing.Point(366, 121);
            this.lblAbstainedSum.Name = "lblAbstainedSum";
            this.lblAbstainedSum.Size = new System.Drawing.Size(14, 16);
            this.lblAbstainedSum.TabIndex = 12;
            this.lblAbstainedSum.Text = "0";
            // 
            // FormVoting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 170);
            this.Controls.Add(this.lblAbstainedSum);
            this.Controls.Add(this.lblAgainstSum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblForSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.txtOption);
            this.Controls.Add(this.cbBoxOption);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.lblOIB);
            this.Name = "FormVoting";
            this.Text = "Voting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.ComboBox cbBoxOption;
        private System.Windows.Forms.Label txtOption;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblForSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAgainstSum;
        private System.Windows.Forms.Label lblAbstainedSum;
    }
}

