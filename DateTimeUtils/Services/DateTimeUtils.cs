namespace DateTimeUtils.Services
{
    using System;
    using Interfaces;

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
        /// Retrieves a DateTime value with Kind form a long value
        /// </summary>
        /// <param name="value">Original long value</param>
        /// <returns>DateTime with Kind</returns>
        public DateTime FromBinary(long value) => DateTime.FromBinary(value);

        #region DateTime Now

        /// <summary>
        /// Retrieves <see cref="DateTime.MinValue"/> value.
        /// </summary>
        /// <returns>DateTime Minimum Value</returns>
        public DateTime Now() => DateTime.Now;

        /// <summary>
        /// Retrieves <see cref="DateTime.Now"/> converted to long value.
        /// </summary>
        /// <returns>DateTime Now ToBinary() value</returns>
        public long NowToBinary() => DateTime.Now.ToBinary();

        #endregion

        #region DateTime UtcNow

        /// <summary>
        /// Retrieves <see cref="DateTime.MinValue"/> value.
        /// </summary>
        /// <returns>DateTime Minimum Value</returns>
        public DateTime UtcNow() => DateTime.UtcNow;

        /// <summary>
        /// Retrieves <see cref="DateTime.UtcNow"/> converted to long value.
        /// </summary>
        /// <returns>DateTime UtcNow ToBinary() value</returns>
        public long UtcNowToBinary() => DateTime.UtcNow.ToBinary();

        #endregion

        #region DateTime Today

        /// <summary>
        /// Retrieves <see cref="DateTime.MinValue"/> value.
        /// </summary>
        /// <returns>DateTime Minimum Value</returns>
        public DateTime Today() => DateTime.Today;

        /// <summary>
        /// Retrieves <see cref="DateTime.Today"/> converted to long value.
        /// </summary>
        /// <returns>DateTime Today ToBinary() value</returns>
        public long TodayToBinary() => DateTime.Today.ToBinary();

        #endregion
    }
}
