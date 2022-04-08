using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlineLibrary
{
    public class Deadline
    {
        public static string UpdateTime(DateTime deadline)
        {
            string result;
            TimeSpan interval = deadline.Subtract(DateTime.Now);
            if (deadline.CompareTo(DateTime.Now) > 0)
                result = interval.ToString(@"dd") + " days " + interval.ToString(@"hh\:mm\:ss");
            else
                result = "Время вышло";
            return result;
        }
    }
}
