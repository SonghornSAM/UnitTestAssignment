using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    class LeapYearChecker
    {
        public string IsLeapYear()
        {
            var year = GetYear();
            return  (year % 4 == 0) ?
                        ((year % 100 == 0) ?
                            ((year % 400 == 0) ?
                                $"{year} is a leap year" :
                            $"{year} is not a leap year") :
                        $"{year} is a leap year") :
                     $"{year} is not a leap year";
        }
        protected virtual int GetYear()
        {
            return DateTime.Now.Year;
        }
    }
}
