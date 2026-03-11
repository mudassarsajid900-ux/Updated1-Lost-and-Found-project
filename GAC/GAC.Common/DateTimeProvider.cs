namespace GAC.Common
{
    public readonly record struct DateTimeProvider
    {
        public static DateTime QatarDateTimeNow
        {
            get
            {
               
                var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Arab Standard Time");
                DateTime qatarDateTime = TimeZoneInfo.ConvertTimeFromUtc(TimeProvider.System.GetUtcNow().DateTime, timeZoneInfo);
                return qatarDateTime;
            }
        }
    }
}
