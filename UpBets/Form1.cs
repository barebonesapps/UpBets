using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpBets
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FillDDList();
            //Set the bet type to red/black
            ddlBetType.SelectedIndex = 0;
        }

        private void FillDDList()
        {
            //DropDownList1.Items.Add(new ListItem("All Record"));
            ddlBetType.Items.Add("Red/Black");
            ddlBetType.Items.Add("Low/High");
            ddlBetType.Items.Add("Even/Odd");
            ddlBetType.Items.Add("Dozen");
            ddlBetType.Items.Add("Column");
            ddlBetType.Items.Add("Double Street");            
            ddlBetType.Items.Add("Corner");
            ddlBetType.Items.Add("Street");
            ddlBetType.Items.Add("Split");
            ddlBetType.Items.Add("Straight-Up");
        }

        private void ddlBetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlBetType.SelectedItem != null)
            {
                string selectedItem = ddlBetType.SelectedItem.ToString();
                //MessageBox.Show(selectedItem, "y", MessageBoxButtons.OK);
                switch (selectedItem)
                {
                    case "Red/Black":
                        txtBetDest.Text = string.Format("Red/Black{0}Place bet on either red or black{0}Payout 1:1{0}American Roulette Odds 47.40%{0}European Roulette Odds 48.60%", Environment.NewLine);
                        break;
                    case "Low/High":
                        txtBetDest.Text = string.Format("Low/High{0}Any number from 1-18 / Any number from 19-36{0}Payout 1:1{0}American Roulette Odds 47.40%{0}European Roulette Odds 48.60%", Environment.NewLine);
                        break;
                    case "Even/Odd":
                        txtBetDest.Text = string.Format("Even/Odd{0}Any even numbers / Any odd numbers{0}Payout 1:1{0}American Roulette Odds 47.40%{0}European Roulette Odds 48.60%", Environment.NewLine);
                        break;
                    case "Dozen":
                        txtBetDest.Text = string.Format("Dozen{0}Payout 2:1{0}The first dozen (1-12) second dozen (13-24) or third dozen (25-36){0}American Roulette Odds 31.60%{0}European Roulette Odds 32.40%", Environment.NewLine);
                        break;
                    case "Column":
                        txtBetDest.Text = string.Format("Column{0}Payout 2:1{0}One of the three rows of numbers on the roulette table (3-36), (2-35), (1-34){0}American Roulette Odds 31.60%{0}European Roulette Odds 32.40%", Environment.NewLine);
                        break;
                    case "Double Street":
                        txtBetDest.Text = string.Format("Double Street{0}Payout 5:1{0}Any six numbers that create two lines (i.e., 1, 2, 3, 4, 5, 6){0}American Roulette Odds 15.80%{0}European Roulette Odds 16.20%", Environment.NewLine);
                        break;
                    case "Corner":
                        txtBetDest.Text = string.Format("Corner{0}Payout 8:1{0}Four numbers in a square layout (i.e., 13, 14, 16, 17){0}American Roulette Odds 10.50%{0}European Roulette Odds 10.80%", Environment.NewLine);
                        break;
                    case "Street":
                        txtBetDest.Text = string.Format("Street{0}Payout 11:1{0}Any three numbers in a line (i.e., 21, 20, 19){0}American Roulette Odds 7.90%{0}European Roulette Odds 8.10%", Environment.NewLine);
                        break;
                    case "Split":
                        txtBetDest.Text = string.Format("Split{0}Payout 17:1{0}Any two numbers (i.e., 7 and 12){0}American Roulette Odds 5.30%{0}European Roulette Odds 5.40%", Environment.NewLine);
                        break;
                    case "Straight-Up":
                        txtBetDest.Text = string.Format("Straight-Up{0}Any single number (i.e., 8 or 15){0}Payout 35:1{0}American Roulette Odds 2.60%{0}European Roulette Odds 2.70%", Environment.NewLine);
                        break;
                }
            }
        }
    }
}
