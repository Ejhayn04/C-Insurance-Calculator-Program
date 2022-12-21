//K2714
//CIS-199-01-4228
//10/20/2022
// This code calulates for both health and car insurance
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form_Program2 : Form
    {
        public Form_Program2()
        {
            InitializeComponent();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {

            //Establishing my variables/formulas to shorten programming time
            double HC_EPO = 100.00;
            double HC_PPO = 75.00;
            double HC_HDP = 25.00;
            double AC_Full = 115.00;
            double AC_Liability = 60.00;
            double lb_HCPY =0, lb_CCCPY =0;
            int lb_age, lb_car;



            if (int.TryParse(tb_enterage.Text, out lb_age) == false ||lb_age <= 0)//Prompting the user for their input regarding their age
            {
                MessageBox.Show("Input Valid Age");// displaying an error if their age is less than 0
            }

            
            if (int.TryParse(tb_Year.Text, out lb_car) == false || lb_car <= 0 || lb_car >= 2030)//Prompting the user for their input regarding their car manufacture year
            {
                MessageBox.Show("Invalid Manufacture Year Entered");//Displaying error if the users input is not within the required range set
            }
           
            if (combo_Hc.SelectedIndex == -1) //Displaying an error if the user does not click on any of the combo boxes
            {
                MessageBox.Show("Please select a combo box");
                lb_HCPY = 0;
            }
            if (combo_Hc.SelectedIndex == 0) //If user clicks on EPO, this sets the users health insurance type to EPO
            {
                lb_HCPY = HC_EPO;
            }
            else if (combo_Hc.SelectedIndex == 1)  //If user clicks on PPO, this sets the users health insurance type to PPO
   
                {
                lb_HCPY = HC_PPO;
            }
            else if (combo_Hc.SelectedIndex == 2) //If user clicks on HDP, this sets the users health insurance type to HDP
            {
                lb_HCPY = HC_HDP;
            }
            if (combo_carCov.SelectedIndex == -1) //Displaying an error if the user does not click on any of the combo boxes
            {
                MessageBox.Show("Please select a combo box");
            }
            if (combo_carCov.SelectedIndex == 0) //If user clicks on Full Coverage, this sets the users auto insurance type to Full
            {
                lb_CCCPY = AC_Full;
            }
            else if (combo_carCov.SelectedIndex == 1) //If user clicks on Liability Coverage, this sets the users auto insurance type to Liability
            {
                lb_CCCPY = AC_Liability;
            }
            if (radioSmoke_yes.Checked == false && radioSmoke_No.Checked == false) // If the user does not click on either of the check boxes, this will display an error
            {
                MessageBox.Show("Please select yes or no");
            }
            else if (combo_Hc.SelectedIndex != 4 && radioSmoke_yes.Checked != false) // If the user clicked on one of the combo boxes and selected yes to smoke, this will add 30 dollars to their total health premium
            {
                lb_HCPY += 30;
            }
            if (radioYear_Yes.Checked == false && radioYear_No.Checked == false) // If the user does not click on either of the check boxes, this will display an error
            {
                MessageBox.Show("Please select yes or no");
            }
            else if (combo_carCov.SelectedIndex != 2 && radioYear_Yes.Checked != false)  // If the user clicked on one of the combo boxes and selected yes to have been in a car accident, this will add 30 percent to their total auto premium
            {
                lb_CCCPY *= 1.3;
            }
            if (combo_carCov.SelectedIndex != 3) // If the user is under the age of 25, this will code for a 10 dollar extra charge to be added to their Health Premium
            {
                if (lb_age <= 25)
                {
                    lb_CCCPY += 10;
                }
            }
            if (lb_car >= 2012) // If the user's car's manufacturing year is older than 2012, this will add an extra 15 dollar charge to their auto premium
            {
                lb_CCCPY += 15;
            }

            //Calculating each premium * 12 months
            lb_HCPY = lb_HCPY * 12;
            lb_CCCPY = lb_CCCPY * 12;

           //Assigning locations for my calculations
            lb_HealthCost.Text = lb_HCPY.ToString("C");
            lb_CarCost.Text = lb_CCCPY.ToString("C");
            lb_TotalOp.Text = (lb_HCPY + lb_CCCPY).ToString("C");

        }

      
        
    }
}
