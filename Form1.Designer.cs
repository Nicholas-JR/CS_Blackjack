namespace N_Roach_CPT_185_Final_Project
{
    partial class gameForm
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
            this.hitBtn = new System.Windows.Forms.Button();
            this.dealBtn = new System.Windows.Forms.Button();
            this.standBtn = new System.Windows.Forms.Button();
            this.betAmountLabel = new System.Windows.Forms.Label();
            this.betAmountTextBox = new System.Windows.Forms.TextBox();
            this.quitBtn = new System.Windows.Forms.Button();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.doubleBtn = new System.Windows.Forms.Button();
            this.dealerCardsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.playerCardsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.stimulusBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hitBtn
            // 
            this.hitBtn.BackColor = System.Drawing.Color.Firebrick;
            this.hitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hitBtn.Font = new System.Drawing.Font("Engravers MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitBtn.Location = new System.Drawing.Point(551, 496);
            this.hitBtn.Name = "hitBtn";
            this.hitBtn.Size = new System.Drawing.Size(158, 71);
            this.hitBtn.TabIndex = 0;
            this.hitBtn.Text = "Hit";
            this.hitBtn.UseVisualStyleBackColor = false;
            this.hitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dealBtn
            // 
            this.dealBtn.BackColor = System.Drawing.Color.Firebrick;
            this.dealBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dealBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dealBtn.Font = new System.Drawing.Font("Engravers MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealBtn.Location = new System.Drawing.Point(464, 496);
            this.dealBtn.Name = "dealBtn";
            this.dealBtn.Size = new System.Drawing.Size(158, 71);
            this.dealBtn.TabIndex = 1;
            this.dealBtn.Text = "DEAL";
            this.dealBtn.UseVisualStyleBackColor = false;
            this.dealBtn.Click += new System.EventHandler(this.dealBtn_Click);
            // 
            // standBtn
            // 
            this.standBtn.BackColor = System.Drawing.Color.Firebrick;
            this.standBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.standBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standBtn.Font = new System.Drawing.Font("Engravers MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standBtn.Location = new System.Drawing.Point(379, 496);
            this.standBtn.Name = "standBtn";
            this.standBtn.Size = new System.Drawing.Size(166, 71);
            this.standBtn.TabIndex = 2;
            this.standBtn.Text = "STAND";
            this.standBtn.UseVisualStyleBackColor = false;
            this.standBtn.Click += new System.EventHandler(this.standBtn_Click);
            // 
            // betAmountLabel
            // 
            this.betAmountLabel.AutoSize = true;
            this.betAmountLabel.BackColor = System.Drawing.Color.Firebrick;
            this.betAmountLabel.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betAmountLabel.Location = new System.Drawing.Point(441, 436);
            this.betAmountLabel.Name = "betAmountLabel";
            this.betAmountLabel.Size = new System.Drawing.Size(203, 25);
            this.betAmountLabel.TabIndex = 3;
            this.betAmountLabel.Text = "BET AMOUNT";
            // 
            // betAmountTextBox
            // 
            this.betAmountTextBox.BackColor = System.Drawing.Color.Firebrick;
            this.betAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.betAmountTextBox.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betAmountTextBox.Location = new System.Drawing.Point(467, 464);
            this.betAmountTextBox.Name = "betAmountTextBox";
            this.betAmountTextBox.Size = new System.Drawing.Size(155, 26);
            this.betAmountTextBox.TabIndex = 4;
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.Firebrick;
            this.quitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitBtn.Font = new System.Drawing.Font("Engravers MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(927, 562);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(147, 57);
            this.quitBtn.TabIndex = 5;
            this.quitBtn.Text = "MENU";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.BackColor = System.Drawing.Color.Firebrick;
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(12, 562);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(304, 57);
            this.balanceLabel.TabIndex = 6;
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // doubleBtn
            // 
            this.doubleBtn.BackColor = System.Drawing.Color.Firebrick;
            this.doubleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doubleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doubleBtn.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubleBtn.Location = new System.Drawing.Point(464, 573);
            this.doubleBtn.Name = "doubleBtn";
            this.doubleBtn.Size = new System.Drawing.Size(158, 38);
            this.doubleBtn.TabIndex = 8;
            this.doubleBtn.Text = "DOUBLE";
            this.doubleBtn.UseVisualStyleBackColor = false;
            this.doubleBtn.Click += new System.EventHandler(this.doubleBtn_Click);
            // 
            // dealerCardsPanel
            // 
            this.dealerCardsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(89)))), ((int)(((byte)(40)))));
            this.dealerCardsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dealerCardsPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dealerCardsPanel.Location = new System.Drawing.Point(12, 12);
            this.dealerCardsPanel.Name = "dealerCardsPanel";
            this.dealerCardsPanel.Size = new System.Drawing.Size(1079, 171);
            this.dealerCardsPanel.TabIndex = 11;
            this.dealerCardsPanel.WrapContents = false;
            // 
            // playerCardsPanel
            // 
            this.playerCardsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(89)))), ((int)(((byte)(40)))));
            this.playerCardsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerCardsPanel.Location = new System.Drawing.Point(12, 189);
            this.playerCardsPanel.Name = "playerCardsPanel";
            this.playerCardsPanel.Size = new System.Drawing.Size(1079, 171);
            this.playerCardsPanel.TabIndex = 12;
            // 
            // stimulusBtn
            // 
            this.stimulusBtn.BackColor = System.Drawing.Color.Firebrick;
            this.stimulusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stimulusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stimulusBtn.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stimulusBtn.Location = new System.Drawing.Point(12, 510);
            this.stimulusBtn.Name = "stimulusBtn";
            this.stimulusBtn.Size = new System.Drawing.Size(304, 43);
            this.stimulusBtn.TabIndex = 13;
            this.stimulusBtn.Text = "COLLECT STIMULUS CHECK";
            this.stimulusBtn.UseVisualStyleBackColor = false;
            this.stimulusBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1103, 642);
            this.Controls.Add(this.stimulusBtn);
            this.Controls.Add(this.playerCardsPanel);
            this.Controls.Add(this.dealerCardsPanel);
            this.Controls.Add(this.doubleBtn);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.betAmountTextBox);
            this.Controls.Add(this.betAmountLabel);
            this.Controls.Add(this.standBtn);
            this.Controls.Add(this.dealBtn);
            this.Controls.Add(this.hitBtn);
            this.Name = "gameForm";
            this.Text = "C# BlackJack";
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hitBtn;
        private System.Windows.Forms.Button dealBtn;
        private System.Windows.Forms.Button standBtn;
        private System.Windows.Forms.Label betAmountLabel;
        private System.Windows.Forms.TextBox betAmountTextBox;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button doubleBtn;
        private System.Windows.Forms.FlowLayoutPanel dealerCardsPanel;
        private System.Windows.Forms.FlowLayoutPanel playerCardsPanel;
        private System.Windows.Forms.Button stimulusBtn;
    }
}

