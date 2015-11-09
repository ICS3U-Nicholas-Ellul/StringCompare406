/*
 * Created by: Nicholas  Ellul
 * Created on: 9-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 4-06
 * This program checks if two strings are equal.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringCompare406
{
    public partial class frmCompare : Form
    {

        public bool CompareStrings(string stringA, string stringB)
        {
            // checks if two strings are the same and returns true or false result

            string stringAUpper = stringA.ToUpper();
            string stringBUpper = stringB.ToUpper();

            if(stringAUpper == stringBUpper)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public frmCompare()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //variables

            string string1;
            string string2;
            bool result;
            
            //process
            string1 = this.txtString1.Text;
            string2 = this.txtString2.Text;

            result = CompareStrings(string1, string2);

            //output
            if(result == true)
            {
               MessageBox.Show("The words are the same");
            }
            else
            {
                MessageBox.Show("This words are different");
            }
        }
    }
}
