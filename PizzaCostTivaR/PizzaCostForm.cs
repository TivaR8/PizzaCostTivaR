using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 02-03-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Pizza Cost
 * This program ask the user for the diameter of a pizza and then...
 * ...calculates the cost of it.
*/

namespace PizzaCostTivaR
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double diameter, subTotal, totalCost;

            
             //Converting the diameter to a double
             diameter = double.Parse(txtUsersNumber.Text);

            //Calculating the subtotal and the total cost of the pizza
            subTotal = 0.75 + 0.99 + (diameter * 0.5);
            totalCost = subTotal * 1.13;

            //Displaying the total cost to the user
            lblCostText.Text = String.Format("${0:0.00}", totalCost);


        }
    }
}
