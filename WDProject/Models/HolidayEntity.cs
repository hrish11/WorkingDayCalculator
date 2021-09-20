using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingDay.Models
{
    public class HolidayEntity
    {
        public int Holiday_Id { get; }

        public string Holiday_Name { get; set; }

        public string Location { get; set; }

        public DateTime Holiday_Date { get; set; }
    }
}