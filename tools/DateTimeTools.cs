using System;

namespace SharedCore.tools
{
    public static class DateTimeTools
    {
        public static DateTime DateTimeSetHourToZero(DateTime dateTimeOriginal)
        {
            DateTime DatetimeResult = new DateTime(dateTimeOriginal.Year,dateTimeOriginal.Month,dateTimeOriginal.Day,0,0,0);
            return DatetimeResult.ToUniversalTime();

        }


        public static DateTime DateTimeSetHourTo2359(DateTime dateTimeOriginal)
        {
            DateTime DatetimeResult = new DateTime(dateTimeOriginal.Year,dateTimeOriginal.Month,dateTimeOriginal.Day,23,59,59);
            return DatetimeResult.ToUniversalTime();

        }    

        private static DateTime NormalizeDateTimeUTC(DateTime dt)
        {
            DateTime dtUTC = dt.ToUniversalTime();
            return new DateTime (dtUTC.Year,dtUTC.Month,dtUTC.Day,dtUTC.Hour,dtUTC.Minute,0);
        } 


        public static bool CompareDateTime(DateTime dt1 , DateTime dt2 )
        {
            dt1 = NormalizeDateTimeUTC(dt1);
            dt2 = NormalizeDateTimeUTC(dt2);

            return (dt1 == dt2);
        }

        public static DateTime? DateTimeBetween(DateTime dtbase , DateTime dt1, DateTime dt2)
        {

            if (NormalizeDateTimeUTC(dtbase) >= NormalizeDateTimeUTC(dt1) 
                && NormalizeDateTimeUTC(dtbase) <= NormalizeDateTimeUTC(dt2))
                return dtbase;
            else    
                return null;

        }

        public static string ConvertDateToString(DateTime dateBase) => dateBase.ToLocalTime().ToString("g");

        public static string ConvertDateToString(DateTime? dateBase) {
            if (dateBase.HasValue)
                return ConvertDateToString(dateBase.Value);
            else
                return "";    
        }


        
    }
}