
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
            this.txtBetDest = new System.Windows.Forms.TextBox();
            this.btnCalcUpBets = new System.Windows.Forms.Button();
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
            this.txtBankroll.Location = new System.Drawing.Point(105, 10);
            this.txtBankroll.Name = "txtBankroll";
            this.txtBankroll.Size = new System.Drawing.Size(68, 23);
            this.txtBankroll.TabIndex = 1;
            this.txtBankroll.Text = "500";
            this.txtBankroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBetType
            // 
            this.lblBetType.AutoSize = true;
            this.lblBetType.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBetType.Location = new System.Drawing.Point(221, 8);
            this.lblBetType.Name = "lblBetType";
            this.lblBetType.Size = new System.Drawing.Size(88, 25);
            this.lblBetType.TabIndex = 2;
            this.lblBetType.Text = "Bet Type";
            // 
            // ddlBetType
            // 
            this.ddlBetType.FormattingEnabled = true;
            this.ddlBetType.Location = new System.Drawing.Point(326, 14);
            this.ddlBetType.Name = "ddlBetType";
            this.ddlBetType.Size = new System.Drawing.Size(198, 23);
            this.ddlBetType.TabIndex = 3;
            this.ddlBetType.SelectedIndexChanged += new System.EventHandler(this.ddlBetType_SelectedIndexChanged);
            // 
            // txtBetDest
            // 
            this.txtBetDest.Enabled = false;
            this.txtBetDest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBetDest.Location = new System.Drawing.Point(12, 55);
            this.txtBetDest.Multiline = true;
            this.txtBetDest.Name = "txtBetDest";
            this.txtBetDest.Size = new System.Drawing.Size(512, 139);
            this.txtBetDest.TabIndex = 4;
            // 
            // btnCalcUpBets
            // 
            this.btnCalcUpBets.BackColor = System.Drawing.Color.White;
            this.btnCalcUpBets.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcUpBets.Location = new System.Drawing.Point(178, 221);
            this.btnCalcUpBets.Name = "btnCalcUpBets";
            this.btnCalcUpBets.Size = new System.Drawing.Size(193, 39);
            this.btnCalcUpBets.TabIndex = 5;
            this.btnCalcUpBets.Text = "&Calculate";
            this.btnCalcUpBets.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 617);
            this.Controls.Add(this.btnCalcUpBets);
            this.Controls.Add(this.txtBetDest);
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
        private System.Windows.Forms.TextBox txtBetDest;
        private System.Windows.Forms.Button btnCalcUpBets;
    }
}

