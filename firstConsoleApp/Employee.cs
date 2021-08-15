using System;
using System.Collections.Generic;
using System.Text;

namespace firstConsoleApp
{
    class Employee
    {
        //employee class fields

        public int employeeID;
        public string firstName;
        public string lastName;
        public decimal payRate;
        public bool isHourly = true;
        public int hoursThisPeriod;
        public int payPeriodsPerYear = 52;

        //employee class methods

        // sets the primary field with values
        public void SetEmployeeInfo(int empId, string fName, string lName, decimal pRate)
        {
            employeeID = empId;
            firstName = fName;
            lastName = lName;
            payRate = pRate;
        }

        // returns a string contain the employees full name
        public string GetFullName()
        {
            return $"{firstName} {lastName}";
        }

        //returns a decimal containing the calculated pay for the current pay period
        public decimal CalculatePay()
        {
            decimal calculatePay;

            if (isHourly)
            {
                calculatePay = hoursThisPeriod * payRate;
            }
            else
            {
                calculatePay = payRate / payPeriodsPerYear;
            }

            return calculatePay;
        }

        // sets the hours for the current pay period and reutrns a decimal containing the calculated pay

        public decimal CalculatePay(int workHours)
        {
            hoursThisPeriod = workHours;
            return CalculatePay();
        }

        // static method that returns the calculated pay for the provided hours and payrate

        public static decimal CalculateHourlyPay(int workHours, decimal payRate)
        {
            return workHours * payRate;
        }







    }
}
