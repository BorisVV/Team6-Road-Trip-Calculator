using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadTripCalculator
{
    public partial class TripCalc : Form
    {
        //Price of fuel national avg. price for each
        decimal gas = 2.20m;
        decimal diesel = 2.41m;
        decimal e85 = 2.77m;

        //Distance between cities
        double milesMpls_Chicago = 408;
        double milesMpls_LA = 1913;
        double milesMpls_Seattle = 1656;
        double milesMpls_NY = 1202;
        double milesMpls_WashDC = 1113;

        double milesLA_WashDC = 2670;
        double milesLA_NY = 2789;
        double milesLA_Seattle = 1142;
        double milesLA_Chicago = 2017;

        double milesSeattle_Chicago = 2043;
        double milesSeattle_NY = 2836;
        double milesSeattle_WashDC = 2747;

        double milesNY_Chicago = 789;
        double milesNY_WashDC = 226;

        double milesWashDC_Chicago = 697;

        double mpg = 0;


        public TripCalc()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        { //Calculate button performs calculation using the methods GetDistance and GetCost. Displays appropriate information in read-only text boxes.

            txtTripCost.Clear();
            txtDistTraveled.Clear();
            try
            {
               
                decimal mpg = Convert.ToDecimal(txtInputMPG.Text);
                txtDistTraveled.Text = Convert.ToString(GetDistance());
                decimal miles = Convert.ToDecimal(GetDistance());
                decimal price = 0;
                if (cboFuelType.SelectedItem.Equals("Gas"))
                {
                    price = gas;
                }
                if (cboFuelType.SelectedItem.Equals("Diesel"))
                {
                    price = diesel;
                }
                if (cboFuelType.SelectedItem.Equals("E85"))
                {
                    price = e85;
                }

                decimal tripCost = GetCost(miles, mpg, price);
                txtTripCost.Text = String.Format("{0:c}",tripCost);

            }
            catch
            {
                MessageBox.Show("Invalid MPG entry.", "Invalid Entry.");
                



            }
            //Displays when the estimate was generated based on the current DateTime when the calculate button was last pressed.
            label11.Visible = true;
            label11.Text = Convert.ToString(DateTime.Now);

        }

        public double GetDistance()
        //Method to determine the milage between two selected locations and be called into calculations later.
        {
            if (cboStartLoc.SelectedItem.Equals("Minneapolis") && cboDestination.SelectedItem.Equals("Chicago"))
            {
                double milage = milesMpls_Chicago;
                return milage;
            }
            if (cboStartLoc.SelectedItem.Equals("Chicago") && cboDestination.SelectedItem.Equals("Minneapolis"))
            {
                double milage = milesMpls_Chicago;
                return milage;
            }
            if (cboStartLoc.SelectedItem.Equals("Chicago") && cboDestination.SelectedItem.Equals("Los Angeles"))
            {
                double milage = milesLA_Chicago;
                return milage;
            }
            if (cboStartLoc.SelectedItem.Equals("Los Angeles") && cboDestination.SelectedItem.Equals("Chicago"))
            {
                double milage = milesLA_Chicago;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Minneapolis") && cboDestination.SelectedItem.Equals("Los Angeles"))
            {
                double milage = milesMpls_LA;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Los Angeles") && cboDestination.SelectedItem.Equals("Minneapolis"))
            {
                double milage = milesMpls_LA;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("New York") && cboDestination.SelectedItem.Equals("Los Angeles"))
            {
                double milage = milesLA_NY;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("New York") && cboDestination.SelectedItem.Equals("Minneapolis"))
            {
                double milage = milesMpls_NY;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("New York") && cboDestination.SelectedItem.Equals("Chicago"))
            {
                double milage = milesNY_Chicago;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("New York") && cboDestination.SelectedItem.Equals("Seattle"))
            {
                double milage = milesSeattle_NY;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("New York") && cboDestination.SelectedItem.Equals("Washington DC"))
            {
                double milage = milesNY_WashDC;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Minneapolis") && cboDestination.SelectedItem.Equals("Seattle"))
            {
                double milage = milesMpls_Seattle;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Minneapolis") && cboDestination.SelectedItem.Equals("New York"))
            {
                double milage = milesMpls_NY;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Minneapolis") && cboDestination.SelectedItem.Equals("Washinton DC"))
            {
                double milage = milesMpls_WashDC;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Chicago") && cboDestination.SelectedItem.Equals("New York"))
            {
                double milage = milesNY_Chicago;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Chicago") && cboDestination.SelectedItem.Equals("Washington DC"))
            {
                double milage = milesWashDC_Chicago;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Chicago") && cboDestination.SelectedItem.Equals("Seattle"))
            {
                double milage = milesSeattle_Chicago;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Los Angeles") && cboDestination.SelectedItem.Equals("New York"))
            {
                double milage = milesLA_NY;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Los Angeles") && cboDestination.SelectedItem.Equals("Washington DC"))
            {
                double milage = milesLA_WashDC;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Los Angeles") && cboDestination.SelectedItem.Equals("Seattle"))
            {
                double milage = milesLA_Seattle;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Seattle") && cboDestination.SelectedItem.Equals("Minneapolis"))
            {
                double milage = milesMpls_Seattle;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Seattle") && cboDestination.SelectedItem.Equals("Washington DC"))
            {
                double milage = milesSeattle_WashDC;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Seattle") && cboDestination.SelectedItem.Equals("Chicago"))
            {
                double milage = milesSeattle_Chicago;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Seattle") && cboDestination.SelectedItem.Equals("New York"))
            {
                double milage = milesSeattle_NY;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Seattle") && cboDestination.SelectedItem.Equals("Los Angeles"))
            {
                double milage = milesLA_Seattle;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Washington DC") && cboDestination.SelectedItem.Equals("Minneapolis"))
            {
                double milage = milesMpls_WashDC;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Washington DC") && cboDestination.SelectedItem.Equals("Seattle"))
            {
                double milage = milesSeattle_WashDC;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Washington DC") && cboDestination.SelectedItem.Equals("New York"))
            {
                double milage = milesNY_WashDC;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Washington DC") && cboDestination.SelectedItem.Equals("Los Angeles"))
            {
                double milage = milesLA_WashDC;
                return milage;
            }

            if (cboStartLoc.SelectedItem.Equals("Washington DC") && cboDestination.SelectedItem.Equals("Chicago"))
            {
                double milage = milesWashDC_Chicago;
                return milage;
            }


            else
            {
                
                return 0;
            }    
        }

        private void cboFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sets fuel price and displays in read-only box.
            decimal fuelPrice = 0;
            if (cboFuelType.SelectedItem.Equals("Gas"))
            {
                fuelPrice = gas;
                txtFuelPrice.Text = String.Format("{0:c}", fuelPrice);
            }

            if (cboFuelType.SelectedItem.Equals("Diesel"))
            {
                fuelPrice = diesel;
                txtFuelPrice.Text = String.Format("{0:c}", fuelPrice);
            }

            if (cboFuelType.SelectedItem.Equals("E85"))
            {
                fuelPrice = e85;
                txtFuelPrice.Text = String.Format("{0:c}", fuelPrice);
            }
            else
            {
                fuelPrice = 0;
            }

            //
        }

        public decimal GetCost(decimal milage, decimal mpg, decimal price)
        {
            decimal totalCost = 0;
            totalCost = (milage / mpg) * price;
            return totalCost;
        }

        private void TripCalc_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDestination_SelectedIndexChanged(object sender, EventArgs e)
        { //Data Validation for Destination
            if (cboStartLoc.SelectedItem.Equals(cboDestination.SelectedItem))
            {
                MessageBox.Show("Invalid Start/Destination Combination. Please select different starting and ending cities.", "Invalid Trip");
                cboDestination.Focus();
            }
        }

        private void cboStartLoc_SelectedIndexChanged(object sender, EventArgs e)
        { //Data Validation for Start Location
            if (cboStartLoc.SelectedItem.Equals(cboDestination.SelectedItem))
            {
                MessageBox.Show("Invalid Start/Destination Combination. Please select different starting and ending cities.", "Invalid Trip");
                cboDestination.Focus();
            }
        }

        private void txtInputMPG_TextChanged(object sender, EventArgs e)
        { //Data validation for MPG entry
            double mpg;
            if(!double.TryParse(txtInputMPG.Text, out mpg))
            {
                MessageBox.Show("Please enter a valid numeric MPG", "Invalid MPG Entry");
                txtInputMPG.Clear();
                txtInputMPG.Focus();
            }
        }
    }
}
