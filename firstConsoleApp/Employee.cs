using System;
using System.Collections.Generic;
using System.Text;

namespace firstConsoleApp
{
    class Employee
    {
        // employee fields
        public string employeeName;
        public int employeeId;
        public int employeePayrate = 0;

        public Employee (string name, int id, int payrate)
        {
            employeeName = name;
            employeeId = id;
            employeePayrate = payrate;
        }

        public int GetYearlySalary()
        {
            return employeePayrate * 12;
        }

    }  
}
