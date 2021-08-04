
namespace UpBets
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBankroll = new System.Windows.Forms.Label();
            this.txtBankroll = new System.Windows.Forms.TextBox();
            this.lblBetType = new System.Windows.Forms.Label();
            this.ddlBetType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblBankroll
            // 
            this.lblBankroll.AutoSize = true;
            this.lblBankroll.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBankroll.Location = new System.Drawing.Point(12, 9);
            this.lblBankroll.Name = "lblBankroll";
            this.lblBankroll.Size = new System.Drawing.Size(87, 25);
            this.lblBankroll.TabIndex = 0;
            this.lblBankroll.Text = "Bankroll";
            // 
            // txtBankroll
            // 
            this.txtBankroll.Location = new System.Drawing.Point(122, 10);
            this.txtBankroll.Name = "txtBankroll";
            this.txtBankroll.Size = new System.Drawing.Size(51, 23);
            this.txtBankroll.TabIndex = 1;
            this.txtBankroll.Text = "500";
            this.txtBankroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBetType
            // 
            this.lblBetType.AutoSize = true;
            this.lblBetType.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBetType.Location = new System.Drawing.Point(12, 59);
            this.lblBetType.Name = "lblBetType";
            this.lblBetType.Size = new System.Drawing.Size(88, 25);
            this.lblBetType.TabIndex = 2;
            this.lblBetType.Text = "Bet Type";
            // 
            // ddlBetType
            // 
            this.ddlBetType.Enabled = false;
            this.ddlBetType.FormattingEnabled = true;
            this.ddlBetType.Location = new System.Drawing.Point(122, 60);
            this.ddlBetType.Name = "ddlBetType";
            this.ddlBetType.Size = new System.Drawing.Size(198, 23);
            this.ddlBetType.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 617);
            this.Controls.Add(this.ddlBetType);
            this.Controls.Add(this.lblBetType);
            this.Controls.Add(this.txtBankroll);
            this.Controls.Add(this.lblBankroll);
            this.Name = "frmMain";
            this.Text = "Up Bets";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBankroll;
        private System.Windows.Forms.TextBox txtBankroll;
        private System.Windows.Forms.Label lblBetType;
        private System.Windows.Forms.ComboBox ddlBetType;
    }
}

