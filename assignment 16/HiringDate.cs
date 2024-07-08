using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_16
{
    internal class HiringDate
    {
        #region Attributes
        int day;
        int month;
        int year;
        #endregion

        #region Constructor
        public HiringDate(int _day, int _month, int _year)
        {
            this.day = _day;
            this.month = _month;
            this.year = _year;
        }
        #endregion

        #region Properties
        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"Day: {Day} , Month: {Month} , Year: {Year}";
        }

        public void DisplayHiringDate()
        {
            Console.WriteLine($"Day: {Day} , Month: {Month} , Year: {Year}");
        }
        #endregion
    }
}
