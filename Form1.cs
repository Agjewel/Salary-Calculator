using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void showSalaryButton_Click(object sender, EventArgs e)
        {
            Salary aSalary=new Salary();
            aSalary.employeeName = EmployeeNameTextBox.Text;
            //aSalary.basicAccount = BasicAccountTextBox.Text;
            aSalary.basicAccount = Convert.ToDouble(BasicAccountTextBox.Text);

            aSalary.houseRent = Convert.ToDouble(HouseRentTextBox.Text);

            aSalary.medicalAllowance = Convert.ToDouble(MedicalTextBox.Text);

            //showSalaryButton.Text = Convert.ToString(aSalary.basicAccount + aSalary.GetHouseRent() + aSalary.GetMedicalAllowance());

           
            //MessageBox.Show(aSalary.employeeName + " " + "your salary is" +" "+  Convert.ToString(aSalary.basicAccount + aSalary.GetHouseRent() + aSalary.GetMedicalAllowance()));
            MessageBox.Show(Convert.ToString(aSalary.GetTotalBalance()));
        }

    }
}
