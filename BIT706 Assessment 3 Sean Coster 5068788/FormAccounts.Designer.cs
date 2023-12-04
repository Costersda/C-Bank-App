
namespace BIT706_Assessment_3_Sean_Coster_5068788
{
    partial class FormAccounts
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
            this.AccountsBox = new System.Windows.Forms.GroupBox();
            this.Omni = new System.Windows.Forms.RadioButton();
            this.Investment = new System.Windows.Forms.RadioButton();
            this.Everyday = new System.Windows.Forms.RadioButton();
            this.DepositBox = new System.Windows.Forms.GroupBox();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WithdrawBox = new System.Windows.Forms.GroupBox();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.textBoxWithdraw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CalculateInterestBox = new System.Windows.Forms.GroupBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountDetailsBox = new System.Windows.Forms.GroupBox();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.AccountsBox.SuspendLayout();
            this.DepositBox.SuspendLayout();
            this.WithdrawBox.SuspendLayout();
            this.CalculateInterestBox.SuspendLayout();
            this.AccountDetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSubTitle
            // 
            this.labelSubTitle.Location = new System.Drawing.Point(137, 83);
            // 
            // AccountsBox
            // 
            this.AccountsBox.Controls.Add(this.Omni);
            this.AccountsBox.Controls.Add(this.Investment);
            this.AccountsBox.Controls.Add(this.Everyday);
            this.AccountsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsBox.Location = new System.Drawing.Point(25, 132);
            this.AccountsBox.Name = "AccountsBox";
            this.AccountsBox.Size = new System.Drawing.Size(200, 126);
            this.AccountsBox.TabIndex = 1;
            this.AccountsBox.TabStop = false;
            this.AccountsBox.Text = "Accounts";
            // 
            // Omni
            // 
            this.Omni.AutoSize = true;
            this.Omni.Location = new System.Drawing.Point(7, 88);
            this.Omni.Name = "Omni";
            this.Omni.Size = new System.Drawing.Size(139, 24);
            this.Omni.TabIndex = 2;
            this.Omni.TabStop = true;
            this.Omni.Text = "Omni Account";
            this.Omni.UseVisualStyleBackColor = true;
            this.Omni.CheckedChanged += new System.EventHandler(this.Omni_CheckedChanged);
            // 
            // Investment
            // 
            this.Investment.AutoSize = true;
            this.Investment.Location = new System.Drawing.Point(7, 57);
            this.Investment.Name = "Investment";
            this.Investment.Size = new System.Drawing.Size(187, 24);
            this.Investment.TabIndex = 1;
            this.Investment.TabStop = true;
            this.Investment.Text = "Investment Account";
            this.Investment.UseVisualStyleBackColor = true;
            this.Investment.CheckedChanged += new System.EventHandler(this.Investment_CheckedChanged);
            // 
            // Everyday
            // 
            this.Everyday.AutoSize = true;
            this.Everyday.Location = new System.Drawing.Point(7, 26);
            this.Everyday.Name = "Everyday";
            this.Everyday.Size = new System.Drawing.Size(170, 24);
            this.Everyday.TabIndex = 0;
            this.Everyday.TabStop = true;
            this.Everyday.Text = "Everyday Account";
            this.Everyday.UseVisualStyleBackColor = true;
            this.Everyday.CheckedChanged += new System.EventHandler(this.Everyday_CheckedChanged);
            // 
            // DepositBox
            // 
            this.DepositBox.Controls.Add(this.buttonDeposit);
            this.DepositBox.Controls.Add(this.textBoxDeposit);
            this.DepositBox.Controls.Add(this.label3);
            this.DepositBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositBox.Location = new System.Drawing.Point(258, 132);
            this.DepositBox.Name = "DepositBox";
            this.DepositBox.Size = new System.Drawing.Size(200, 126);
            this.DepositBox.TabIndex = 3;
            this.DepositBox.TabStop = false;
            this.DepositBox.Text = "Deposit";
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.Location = new System.Drawing.Point(11, 82);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(100, 31);
            this.buttonDeposit.TabIndex = 2;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxDeposit.Location = new System.Drawing.Point(11, 50);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(100, 26);
            this.textBoxDeposit.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount:";
            // 
            // WithdrawBox
            // 
            this.WithdrawBox.Controls.Add(this.buttonWithdraw);
            this.WithdrawBox.Controls.Add(this.textBoxWithdraw);
            this.WithdrawBox.Controls.Add(this.label4);
            this.WithdrawBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawBox.Location = new System.Drawing.Point(474, 132);
            this.WithdrawBox.Name = "WithdrawBox";
            this.WithdrawBox.Size = new System.Drawing.Size(200, 126);
            this.WithdrawBox.TabIndex = 4;
            this.WithdrawBox.TabStop = false;
            this.WithdrawBox.Text = "Withdraw";
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdraw.Location = new System.Drawing.Point(11, 82);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(100, 31);
            this.buttonWithdraw.TabIndex = 2;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = false;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // textBoxWithdraw
            // 
            this.textBoxWithdraw.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxWithdraw.Location = new System.Drawing.Point(11, 50);
            this.textBoxWithdraw.Name = "textBoxWithdraw";
            this.textBoxWithdraw.Size = new System.Drawing.Size(100, 26);
            this.textBoxWithdraw.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amount:";
            // 
            // CalculateInterestBox
            // 
            this.CalculateInterestBox.Controls.Add(this.buttonCalculate);
            this.CalculateInterestBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateInterestBox.Location = new System.Drawing.Point(697, 132);
            this.CalculateInterestBox.Name = "CalculateInterestBox";
            this.CalculateInterestBox.Size = new System.Drawing.Size(200, 126);
            this.CalculateInterestBox.TabIndex = 5;
            this.CalculateInterestBox.TabStop = false;
            this.CalculateInterestBox.Text = "Calculate Interest";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(38, 45);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(115, 46);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output:";
            // 
            // AccountDetailsBox
            // 
            this.AccountDetailsBox.Controls.Add(this.buttonDisplay);
            this.AccountDetailsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountDetailsBox.Location = new System.Drawing.Point(25, 280);
            this.AccountDetailsBox.Name = "AccountDetailsBox";
            this.AccountDetailsBox.Size = new System.Drawing.Size(200, 126);
            this.AccountDetailsBox.TabIndex = 8;
            this.AccountDetailsBox.TabStop = false;
            this.AccountDetailsBox.Text = "Display Account Details";
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(46, 47);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(115, 46);
            this.buttonDisplay.TabIndex = 2;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = false;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(258, 308);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(639, 95);
            this.listBoxOutput.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gold;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(735, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(168, 65);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(945, 422);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.AccountDetailsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalculateInterestBox);
            this.Controls.Add(this.WithdrawBox);
            this.Controls.Add(this.DepositBox);
            this.Controls.Add(this.AccountsBox);
            this.Name = "FormAccounts";
            this.Text = "Account Manager";
            this.Controls.SetChildIndex(this.AccountsBox, 0);
            this.Controls.SetChildIndex(this.DepositBox, 0);
            this.Controls.SetChildIndex(this.WithdrawBox, 0);
            this.Controls.SetChildIndex(this.CalculateInterestBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.AccountDetailsBox, 0);
            this.Controls.SetChildIndex(this.listBoxOutput, 0);
            this.Controls.SetChildIndex(this.labelTitle, 0);
            this.Controls.SetChildIndex(this.labelSubTitle, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.AccountsBox.ResumeLayout(false);
            this.AccountsBox.PerformLayout();
            this.DepositBox.ResumeLayout(false);
            this.DepositBox.PerformLayout();
            this.WithdrawBox.ResumeLayout(false);
            this.WithdrawBox.PerformLayout();
            this.CalculateInterestBox.ResumeLayout(false);
            this.AccountDetailsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox AccountsBox;
        private System.Windows.Forms.RadioButton Omni;
        private System.Windows.Forms.RadioButton Investment;
        private System.Windows.Forms.RadioButton Everyday;
        private System.Windows.Forms.GroupBox DepositBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.GroupBox WithdrawBox;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.TextBox textBoxWithdraw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox CalculateInterestBox;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox AccountDetailsBox;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button btnBack;
    }
}

