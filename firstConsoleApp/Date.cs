using System;
using System.Collections.Generic;
using System.Text;

namespace firstConsoleApp
{
    class Date
    {
        public int month =-1;
        public int day=-1;
        public int year=-1;

        public Date( int m, int d, int y)
        {
            month = m;
            day = d;
            year = y;
        }

        public void SetDate(int m, int d, int y)
        {
            month = m;
            day = d;
            year = y;

        }
    }
}
