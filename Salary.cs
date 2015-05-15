using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    class Salary
    {
        public string employeeName;
        public double basicAccount;
        public double houseRent;
        public double medicalAllowance;

        public double GetHouseRent()
        {
            return (basicAccount/100)*houseRent;
        }

        public double GetMedicalAllowance()
        {
            return (basicAccount / 100) * medicalAllowance;
        }

        public double GetTotalBalance()
        {
            return basicAccount + GetHouseRent() + GetMedicalAllowance();
        }
    }
}
