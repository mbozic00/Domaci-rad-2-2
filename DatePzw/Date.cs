using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatePzw
{
    public class Date
    {
        int dateYear, dateMonth, dateDay;
        public Date(int year, int month, int day)
        {
            dateYear = year;
            dateMonth = month;
            dateDay = day;
        }

        public string getMonthName()
        {
            switch (dateMonth)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
                default: return "Invalid month";
            }
        }

        public int getNumberOfRemainingDaysInMonth()
        {
            int remaining;

            switch (dateMonth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: remaining = 31 - dateDay; break;
                case 4:
                case 6:
                case 9:
                case 11: remaining = 30 - dateDay; break;
                case 2: if (isLeapYear() == false) remaining = 28 - dateDay; 
                        else remaining = 29 - dateDay;
                        break;
                default: remaining = -1; break;
            }

            if (remaining >= 0)
                return remaining;
            else
                return -1; //oznaka greške
        }

        public bool isLeapYear()
        {
            if (dateYear % 4 != 0)
                return false;
            else if (dateYear % 100 == 0)
            {
                if (dateYear % 400 == 0)
                    return true;
                else
                    return false;
            }
            else
                return true;
        }
    }
}
