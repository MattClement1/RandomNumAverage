/*
* Created by: Matthew Clement
* Created on: 11-Nov-2015
* Created for: Unit #5-01
*This program generates 10 random numbers and finds the average
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

namespace RandomNumAverage
{
    public partial class frmRandomNumAverage : Form
    {
        int[] arrayOfNumbers = new int[11];

        public frmRandomNumAverage()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int counter = 0;
            double average = 0;
            this.lstNumList.Items.Clear();
            Random rnd = new Random();

            while (counter < 10)
            {   
                int num = rnd.Next(1, 11);

                arrayOfNumbers[counter] = num;

                this.lstNumList.Items.Add(num);

                average = average + num;

                counter++;
            }
            average = average / 10;
            MessageBox.Show("The average is: " + average);
        }
    }
}
