namespace DateTimeUtils.Services
{
    using System;
    using Interefaces;

    public class DateTimeUtils : IDateTimeUtils
    {
        /// <summary>
        /// Retrieves <see cref="DateTime.MinValue"/> value.
        /// </summary>
        /// <returns>DateTime Minimum Value</returns>
        public DateTime MinValue() => DateTime.MinValue;

        /// <summary>
        /// Retrieves <see cref="DateTime.MaxValue"/> value.
        /// </summary>
        /// <returns>DateTime Maximum Value</returns>
        public DateTime MaxValue() => DateTime.MaxValue;

        /// <summary>
        /// Retrieves <see cref="DateTime.MinValue"/> value.
        /// </summary>
        /// <returns>DateTime Minimum Value</returns>
        public DateTime Now() => DateTime.Now;

        /// <summary>
        /// Retrieves <see cref="DateTime.MinValue"/> value.
        /// </summary>
        /// <returns>DateTime Minimum Value</returns>
        public DateTime UtcNow() => DateTime.UtcNow;

        /// <summary>
        /// Retrieves <see cref="DateTime.MinValue"/> value.
        /// </summary>
        /// <returns>DateTime Minimum Value</returns>
        public DateTime Today() => DateTime.Today;
    }
}
