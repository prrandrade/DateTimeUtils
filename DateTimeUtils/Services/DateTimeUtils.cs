namespace DateTimeUtils.Services
{
    using System;
    using Interefaces;

    public class DateTimeUtils : IDateTimeUtils
    {
        public DateTime MinValue() => DateTime.MinValue;
        public DateTime MaxValue() => DateTime.MaxValue;
        public DateTime Now() => DateTime.Now;
        public DateTime UtcNow() => DateTime.UtcNow;
        public DateTime Today() => DateTime.Today;
    }
}
