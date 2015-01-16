using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBL.CPS.UTILS
{

    static public class DateTimeUtils
    {

        static public DateTime GetNow()
        {
            var myTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            var currentDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, myTimeZone);
            return currentDateTime;
        }

        static public DateTime GetToday()
        {
            return GetNow().Date;
        }

    }



}
