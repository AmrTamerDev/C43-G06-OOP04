using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Duration
    {
        #region Attributes
        private int hours;
        private int minutes;
        private int seconds;
        #endregion

        #region Properties
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        public int Minutes
            { get { return minutes; } set { minutes = value; } }

        public int Seconds
            { get { return seconds; } set { seconds = value; } }
        #endregion

        #region Constructor
        public Duration(int Hours, int Minutes, int Sconds)
        {
            hours = Hours;
            minutes = Minutes;
            seconds = Sconds;
        }
        
        public Duration(int TotalSeconds)
        {
            int Remainder = 0;
            hours = TotalSeconds / 3600;
            Remainder = TotalSeconds % 3600;
            TotalSeconds /= 3600;
            minutes = Remainder / 60;
            Remainder = Remainder % 60;
            Seconds = Remainder;
        }

        public Duration()
        {

        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Hours: {hours},Minutes: {minutes},Seconds: {seconds}";
        }

        public override int GetHashCode()
        {
            return hours * minutes * seconds;
        }

        public override bool Equals(object? obj)
        {
            return (minutes == hours) && (minutes == seconds);
        }

        public static Duration operator +(Duration D1, Duration D2)
        {
            Duration D3 = new Duration();
            D3.hours = D1.hours + D2.hours;
            D3.minutes = D1.minutes + D2.minutes;
            D3.seconds = D1.seconds + D2.seconds;
            return D3;
        }

        public static Duration operator +(Duration D1, int Seconds)
        {
            Duration D3 = new Duration(Seconds);
            D3.hours = D1.hours + D3.hours;
            D3.minutes = D1.minutes + D3.minutes;
            D3.seconds = D1.seconds + D3.seconds;
            return D3;
        }

        public static Duration operator +(int Seconds, Duration D1)
        {
            Duration D3 = new Duration(Seconds);
            D3.hours = D1.hours + D3.hours;
            D3.minutes = D1.minutes + D3.minutes;
            D3.seconds = D1.seconds + D3.seconds;
            return D3;
        }

        public static Duration operator ++(Duration D1)
        {
            return new Duration()
            {
                hours = D1.hours,
                minutes = D1.minutes + 1,
                seconds = D1.seconds
            };
        }

        public static Duration operator --(Duration D1)
        {
            return new Duration()
            {
                hours = D1?.hours ?? 0,
                minutes = D1? .minutes ?? 0 - 1,
                seconds = D1? .seconds ?? 0
            };
        }
        public static Duration operator -(Duration D1, Duration D2)
        {
            Duration D3 = new Duration();
            D3.hours = D1?.hours??0 - D2?.hours??0;
            D3.minutes = D1?.minutes??0 - D2?.minutes??0;
            D3.seconds = D1?.seconds??0 - D2?.seconds??0;
            return D3;
        }
        public static bool operator >(Duration D1, Duration D2)
        {
            if (D1.Hours > D2.Hours)
                return true;
            else if (D1.Minutes > D2.Minutes)
                return true;
            else if (D1.Seconds > D2.Seconds)
                return true;
            else return false;
        }
        public static bool operator <(Duration D1, Duration D2)
        {
            if (D1.Hours <= D2.Hours)
                return true;
            else if (D1.Minutes < D2.Minutes)
                return true;
            else if (D1.Seconds < D2.Seconds)
                return true;
            else return false;
        }

        public static bool operator >=(Duration D1, Duration D2)
        {
            if (D1.Hours >= D2.Hours)
                return true;
            else if (D1.Minutes >= D2.Minutes)
                return true;
            else if (D1.Seconds >= D2.Seconds)
                return true;
            else return false;
        }
        public static bool operator <=(Duration D1, Duration D2)
        {
            if (D1.Hours <= D2.Hours)
                return true;
            else if (D1.Minutes <= D2.Minutes)
                return true;
            else if (D1.Seconds <= D2.Seconds)
                return true;
            else return false;
        }
        #endregion
    }
}
