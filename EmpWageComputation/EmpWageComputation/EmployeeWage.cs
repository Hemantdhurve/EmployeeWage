﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public static class EmployeeWage
    {

        //When using switch case define constants in class

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int Emp_Rate_Per_Hr = 20;
        public const int Number_Of_Working_Days = 20;
        public const int Max_Hr_In_Month = 100;
        public static void EmpWageTotalWorkingDays()
        {
           
            //variables
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;

            //Using while loop to iterate/check the condition is satisfied or not

            while (totalEmpHrs <= Max_Hr_In_Month && totalWorkingDays < Number_Of_Working_Days)
            {

                totalWorkingDays++;

                //random function is to create random numbers
                Random random = new Random();

                int empCheck = random.Next(0, 3);      //range from 0 to 2

                //use Switch case statement to get employee wage
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;              //we can also use it totalEmpWage=totalEmpHrs+empHrs
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);

            }
            totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hr;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}
