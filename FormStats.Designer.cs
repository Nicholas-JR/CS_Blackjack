namespace N_Roach_CPT_185_Final_Project
{
    partial class FormStats
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
            this.playerStatsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.handsPlayedLabel = new System.Windows.Forms.Label();
            this.handsWonLabel = new System.Windows.Forms.Label();
            this.rtpLabel = new System.Windows.Forms.Label();
            this.balanceWageredLabel = new System.Windows.Forms.Label();
            this.highestBalanceLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerStatsLabel
            // 
            this.playerStatsLabel.AutoSize = true;
            this.playerStatsLabel.Font = new System.Drawing.Font("Engravers MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerStatsLabel.Location = new System.Drawing.Point(153, 22);
            this.playerStatsLabel.Name = "playerStatsLabel";
            this.playerStatsLabel.Size = new System.Drawing.Size(522, 56);
            this.playerStatsLabel.TabIndex = 1;
            this.playerStatsLabel.Text = "Session Stats";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(334, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close Stats";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hands Played: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "hands won: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "current rtp: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "balance wagered: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "highest session balance:";
            // 
            // handsPlayedLabel
            // 
            this.handsPlayedLabel.BackColor = System.Drawing.Color.RosyBrown;
            this.handsPlayedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.handsPlayedLabel.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handsPlayedLabel.Location = new System.Drawing.Point(413, 111);
            this.handsPlayedLabel.Name = "handsPlayedLabel";
            this.handsPlayedLabel.Size = new System.Drawing.Size(236, 22);
            this.handsPlayedLabel.TabIndex = 8;
            // 
            // handsWonLabel
            // 
            this.handsWonLabel.BackColor = System.Drawing.Color.RosyBrown;
            this.handsWonLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.handsWonLabel.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handsWonLabel.Location = new System.Drawing.Point(413, 154);
            this.handsWonLabel.Name = "handsWonLabel";
            this.handsWonLabel.Size = new System.Drawing.Size(238, 24);
            this.handsWonLabel.TabIndex = 9;
            // 
            // rtpLabel
            // 
            this.rtpLabel.BackColor = System.Drawing.Color.RosyBrown;
            this.rtpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtpLabel.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtpLabel.Location = new System.Drawing.Point(413, 199);
            this.rtpLabel.Name = "rtpLabel";
            this.rtpLabel.Size = new System.Drawing.Size(238, 24);
            this.rtpLabel.TabIndex = 10;
            // 
            // balanceWageredLabel
            // 
            this.balanceWageredLabel.BackColor = System.Drawing.Color.RosyBrown;
            this.balanceWageredLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceWageredLabel.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceWageredLabel.Location = new System.Drawing.Point(413, 246);
            this.balanceWageredLabel.Name = "balanceWageredLabel";
            this.balanceWageredLabel.Size = new System.Drawing.Size(238, 24);
            this.balanceWageredLabel.TabIndex = 11;
            // 
            // highestBalanceLabel
            // 
            this.highestBalanceLabel.BackColor = System.Drawing.Color.RosyBrown;
            this.highestBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highestBalanceLabel.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestBalanceLabel.Location = new System.Drawing.Point(413, 289);
            this.highestBalanceLabel.Name = "highestBalanceLabel";
            this.highestBalanceLabel.Size = new System.Drawing.Size(238, 24);
            this.highestBalanceLabel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "?";
            this.toolTip1.SetToolTip(this.label6, "RTP (Return to Player)\r\nThis is the average percentage of your bets that are retu" +
        "rned to you.");
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.highestBalanceLabel);
            this.Controls.Add(this.balanceWageredLabel);
            this.Controls.Add(this.rtpLabel);
            this.Controls.Add(this.handsWonLabel);
            this.Controls.Add(this.handsPlayedLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playerStatsLabel);
            this.HelpButton = true;
            this.Name = "FormStats";
            this.Text = "FormStats";
            this.Load += new System.EventHandler(this.FormStats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label playerStatsLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label handsPlayedLabel;
        private System.Windows.Forms.Label handsWonLabel;
        private System.Windows.Forms.Label rtpLabel;
        private System.Windows.Forms.Label balanceWageredLabel;
        private System.Windows.Forms.Label highestBalanceLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
    }
}