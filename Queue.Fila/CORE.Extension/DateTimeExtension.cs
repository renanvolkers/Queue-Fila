using System;
using TimeZoneConverter;

namespace CORE.Extension
{
    public static class DateTimeExtension
    {
        public const string SouthAmericaStandardTime = "E. South America Standard Time";
        public static readonly TimeZoneInfo SouthAmericaStandardTimeTimeZone = TZConvert.GetTimeZoneInfo(SouthAmericaStandardTime);

        public static DateTime NowBrasiliaTimeZone(this DateTime value) =>
            TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, SouthAmericaStandardTimeTimeZone);

        public static DateTime ToBrasiliaTimeZone(this DateTime value) =>
            TimeZoneInfo.ConvertTimeFromUtc(value.ToUniversalTime(), SouthAmericaStandardTimeTimeZone);
    }
}
