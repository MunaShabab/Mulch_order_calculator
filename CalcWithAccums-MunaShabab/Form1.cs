using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWithAccums_MunaShabab
{
    public partial class Form1 : Form
    {
        //Author:Muna Shabab
        //ID:624191
        //date:9-29-19
        //Goal:to calculate amount of mulch and price for each order and to accumulate the amount and total price
        //for multiple orders
        //also to keep a count of the number of orders
        //and provide a clear button to start over completely


        //declare fields and initialize them
        private const decimal CUBIC_FEET_TO_YARD = 27m;
        private const decimal MULCH_PRICE = 17m;
        private decimal ttlCubicFeet = 0m;
        private decimal ttlCubicYrd = 0m;
        private decimal ttlCost = 0m;
        private decimal ordersCnt = 0m;
        private const int TRK_CAP = 4;
        private decimal remTrkCap = 0m;


        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declare variables to hold the values
                decimal lengthFt = 0m;
                decimal widthFt = 0m;
                decimal heightFt = 0m;
                decimal crrntCubicFt = 0m;
                decimal crrntCubicYrd = 0m;
                decimal crrntOrderPrice = 0m;

                //get the value for th evariables from the text boxes
                lengthFt = decimal.Parse(lengthTextBox.Text);
                widthFt = decimal.Parse(widthTextBox.Text);
                heightFt = decimal.Parse(heightTextBox.Text);

                //calculate the values to display in the current order
                crrntCubicFt = lengthFt * widthFt * heightFt;
                crrntCubicYrd = crrntCubicFt / CUBIC_FEET_TO_YARD;
                crrntOrderPrice = crrntCubicYrd * MULCH_PRICE;

                //Accumulate the values in the field variables
                ttlCubicFeet += crrntCubicFt;
                ttlCubicYrd += crrntCubicYrd;
                ttlCost += crrntOrderPrice;
                remTrkCap = TRK_CAP - ttlCubicYrd;

                //increase the number of orders by 1
                ordersCnt += 1;

                //display the calculated and accumulated values
                crrntCubicFtLabel.Text = crrntCubicFt.ToString("n2");
                crrntCubicYrdLabel.Text = crrntCubicYrd.ToString("n2");
                crrntOrderPriceLabel.Text = crrntOrderPrice.ToString("c");
                ttlCubicFtLabel.Text = ttlCubicFeet.ToString("n2");
                ttlCubicYrdLabel.Text = ttlCubicYrd.ToString("n2");
                ttlCostLabel.Text = ttlCost.ToString("c");
                ordersCntLabel.Text = ordersCnt.ToString("n0");
                trkCapLabel.Text = TRK_CAP.ToString("n");
                orderedCbYrdLabel.Text = ttlCubicYrd.ToString("n2");
                remTrkCapLabel.Text = remTrkCap.ToString("n2");

                //show the remaining truck capacity with a light blue back color if its greater than zero
                if (remTrkCap > 0)
                {
                    remTrkCapLabel.BackColor = Color.LightBlue;

                }
                //otherwise make it red
                else
                {
                    remTrkCapLabel.BackColor = Color.Red;
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            //reset all the accumulators on the form and in memory
            ttlCubicFeet = 0m;
            ttlCubicYrd = 0m;
            ttlCost = 0m;
            ordersCnt = 0m;
            remTrkCap = 0m;

            //clear all the displayed lables
            lengthTextBox.Text = "";
            widthTextBox.Text = "";
            heightTextBox.Text = "";
            crrntCubicFtLabel.Text = "";
            crrntCubicYrdLabel.Text = "";
            crrntOrderPriceLabel.Text = "";
            ttlCubicFtLabel.Text = "";
            ttlCubicYrdLabel.Text = "";
            ttlCostLabel.Text = "";
            ordersCntLabel.Text = "";
            trkCapLabel.Text = "";
            orderedCbYrdLabel.Text = "";
            remTrkCapLabel.Text = "";
            remTrkCapLabel.BackColor = Color.White;

            

        }
    }
}
