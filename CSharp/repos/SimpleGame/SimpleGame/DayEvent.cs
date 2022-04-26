using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGame
{

    class DayEvent
    {
        public string task;
        public DateTime date;

        public DayEvent()
        {

        }

        public DayEvent(string t, DateTime dt)
        {
            date = dt;
            task = t; 
        }

        public override string ToString()
        {
            return date.Day.ToString()+"/"+date.Month.ToString() + "/" +date.Year.ToString() + " : "+task;
        }

    }
}
