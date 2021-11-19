using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPayroll
{
    class Solution
    {
        public double CalNetSalary(double grossPay, double contributions, double deductions)
        {
            double netPay = grossPay - (contributions + deductions);
            return netPay;
        }
        public double GetDailyRate(string position)
        {
            double rate = 0.00;
            if (position.ToLower() == "manager")
            {
                rate = 520.00;
            }else if (position.ToLower() == "staff")
            {
                rate = 380.00;
            }else if (position.ToLower() == "clerk")
            {
                rate = 160.00;
            }
            else
            {
                Console.WriteLine("It seems you would like to enter rate yourself ");
                Console.WriteLine("Enter Rate Manually");
                string rateinit = Console.ReadLine();
                double newnum;
                if (double.TryParse(rateinit, out newnum) == true)
                {
                    rate = newnum;
                }
                else
                {
                    Console.WriteLine("You need to enter Rate as number");
                    string rateinit2 = Console.ReadLine();
                    rate = Convert.ToDouble(rateinit2);
                }
                   
            }
            return rate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the solution class;
            Solution solution = new Solution();

            //Get the position;
            Console.WriteLine("Enter position");
            string position = Console.ReadLine();

            //Get the daily rate;
            double DailyRate = solution.GetDailyRate(position);
            Console.Write("DailyRate: ");
            Console.WriteLine(DailyRate);
            //contributions;
            Console.WriteLine("Contributions");
            //get sss;
            Console.WriteLine("Input SSS");
            string sss = Console.ReadLine();
            double sssContribution = Convert.ToDouble(sss);

            //get pag-Ibig
            Console.WriteLine("Input your Pag-Ibig");
            string pagIbig = Console.ReadLine();
            double pagIbigContribution = Convert.ToDouble(pagIbig);

            //get PhilHealth
            Console.WriteLine("Input your Philhealth");
            string philHealth = Console.ReadLine();
            double philHealthContribution = Convert.ToDouble(philHealth);

            //get total contributions
            double contributions = sssContribution + pagIbigContribution + philHealthContribution;

            //get deductions
            Console.WriteLine("Input Deductions");
            string deduction = Console.ReadLine();
            double deductions = Convert.ToDouble(deduction);

            //get man days
            Console.WriteLine("Input Man Days");
            string manDay = Console.ReadLine();
            double manDays = Convert.ToDouble(manDay);

            //Gross pay
            //Console.WriteLine("Gross Pay");
            double grossPay = manDays * DailyRate;
            double netPay = solution.CalNetSalary(grossPay,contributions,deductions);
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //Results
            Console.WriteLine("Results");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Employee Information");
            Console.WriteLine(" ");
            Console.Write("Position: ");
            Console.WriteLine(position);
            Console.Write("Daily Rate: ");
            Console.WriteLine(DailyRate);
            Console.WriteLine(" ");
            Console.WriteLine("Contributions:");
            Console.Write("SSS: "); ;
            Console.WriteLine(sssContribution);
            Console.Write("PAG-IBIG: "); 
            Console.WriteLine(pagIbigContribution);
            Console.Write("PhilHealth: ");
            Console.WriteLine(philHealthContribution);
            Console.Write("Total Contributions: ");
            Console.WriteLine(contributions);
            Console.WriteLine(" ");
            Console.Write("Deduction: ");
            Console.WriteLine(deductions);


            //gross and net pay
            Console.WriteLine(" ");
            Console.Write("Gross Pay : ");
            Console.WriteLine(grossPay);
            Console.WriteLine(" ");
            Console.Write("Net Pay : ");
            Console.WriteLine(netPay);
               

        }
    }
}
