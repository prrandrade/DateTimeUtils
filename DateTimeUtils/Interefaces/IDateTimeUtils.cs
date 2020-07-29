namespace DateTimeUtils.Interefaces
{
    using System;

    public interface IDateTimeUtils
    {
        public DateTime MinValue();
        public DateTime MaxValue();
        public DateTime Now();
        public DateTime UtcNow();
        public DateTime Today();
    }
}
