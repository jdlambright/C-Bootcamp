using System;
using System.Collections.Generic;
using System.Text;

namespace firstConsoleApp
{
    class Employee
    {
        // declaring fields
        public string employeeName = "";
        public int employeeStoreId = -1;
        public int employeePayRate = 0;

        // employee constructor
        public Employee(string name, int storeId, int payRate)
        {
            employeeName = name;
            employeeStoreId = storeId;
            employeePayRate = payRate;
        }

        public int GetYearlySalary()
        {
            return employeePayRate * 12;
        }

    }  
}
