
namespace BIT706_Assessment_3_Sean_Coster_5068788
{
    partial class FormAddAccount
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.AccountsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountsBox
            // 
            this.AccountsBox.Controls.Add(this.Omni);
            this.AccountsBox.Controls.Add(this.Investment);
            this.AccountsBox.Controls.Add(this.Everyday);
            this.AccountsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsBox.Location = new System.Drawing.Point(22, 135);
            this.AccountsBox.Name = "AccountsBox";
            this.AccountsBox.Size = new System.Drawing.Size(200, 126);
            this.AccountsBox.TabIndex = 4;
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
            // 
            // Everyday
            // 
            this.Everyday.AutoSize = true;
            this.Everyday.Location = new System.Drawing.Point(7, 27);
            this.Everyday.Name = "Everyday";
            this.Everyday.Size = new System.Drawing.Size(170, 24);
            this.Everyday.TabIndex = 0;
            this.Everyday.TabStop = true;
            this.Everyday.Text = "Everyday Account";
            this.Everyday.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(22, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 48);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(202, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 48);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.AccountsBox);
            this.Name = "FormAddAccount";
            this.Text = "FormAddAccount";
            this.Controls.SetChildIndex(this.labelTitle, 0);
            this.Controls.SetChildIndex(this.labelSubTitle, 0);
            this.Controls.SetChildIndex(this.AccountsBox, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.AccountsBox.ResumeLayout(false);
            this.AccountsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AccountsBox;
        private System.Windows.Forms.RadioButton Omni;
        private System.Windows.Forms.RadioButton Investment;
        private System.Windows.Forms.RadioButton Everyday;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}