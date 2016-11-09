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
        {
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

            }

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

            
        }

        public decimal GetCost(decimal milage, decimal mpg, decimal price)
        {
            decimal totalCost = 0;
            totalCost = (milage / mpg) * price;
            return totalCost;
        }

    }
}
