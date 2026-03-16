namespace GAC.Common
{
    public readonly record struct DateTimeProvider
    {
        public static DateTime CurrentDateTime => DateTime.Now;
    }
}
