using System;
using System.Globalization;

namespace VNetDev.WmiQueryableCore.WqlTranslator.Extensions
{
    internal static class DateTimeExtension
    {
        // Reference: 
        public static string ToDmtf(this DateTime date)
        {
            string str;
            var utcOffset = TimeZoneInfo.Local.GetUtcOffset(date);
            var ticks = utcOffset.Ticks / 0x23c34600;
            var format = (IFormatProvider) CultureInfo.InvariantCulture.GetFormat(typeof(int));
            if (Math.Abs(ticks) <= 0x3e7)
            {
                if (utcOffset.Ticks < 0)
                {
                    var str1 = ticks.ToString(format);
                    str = string.Concat("-", str1.Substring(1, str1.Length - 1).PadLeft(3, '0'));
                }
                else
                {
                    var num = utcOffset.Ticks / 0x23c34600;
                    str = string.Concat("+", num.ToString(format).PadLeft(3, '0'));
                }
            }
            else
            {
                date = date.ToUniversalTime();
                str = "+000";
            }

            var year = date.Year;
            var str2 = year.ToString(format).PadLeft(4, '0');
            var month = date.Month;
            str2 = string.Concat(str2, month.ToString(format).PadLeft(2, '0'));
            var day = date.Day;
            str2 = string.Concat(str2, day.ToString(format).PadLeft(2, '0'));
            var hour = date.Hour;
            str2 = string.Concat(str2, hour.ToString(format).PadLeft(2, '0'));
            var minute = date.Minute;
            str2 = string.Concat(str2, minute.ToString(format).PadLeft(2, '0'));
            var second = date.Second;
            str2 = string.Concat(str2, second.ToString(format).PadLeft(2, '0'));
            str2 = string.Concat(str2, ".");
            var dateTime = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, 0);
            var ticks1 = (date.Ticks - dateTime.Ticks) * 0x3e8 / 0x2710;
            var str3 = ticks1.ToString((IFormatProvider) CultureInfo.InvariantCulture.GetFormat(typeof(long)));
            if (str3.Length > 6)
            {
                str3 = str3.Substring(0, 6);
            }

            str2 = string.Concat(str2, str3.PadLeft(6, '0'));
            str2 = string.Concat(str2, str);
            return str2;
        }
    }
}