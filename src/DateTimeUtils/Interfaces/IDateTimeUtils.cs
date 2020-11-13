namespace DateTimeUtils.Interfaces
{
    using System;

    public interface IDateTimeUtils
    {
        /// <summary>
        /// Retrieves <see cref="DateTime.MinValue"/> value.
        /// </summary>
        /// <returns>DateTime Minimum Value</returns>
        public DateTime MinValue();

        /// <summary>
        /// Retrieves <see cref="DateTime.MaxValue"/> value.
        /// </summary>
        /// <returns>DateTime Maximum Value</returns>
        public DateTime MaxValue();

        /// <summary>
        /// Retrieves a DateTime value with Kind form a long value
        /// </summary>
        /// <param name="value">Original long value</param>
        /// <returns>DateTime with Kind</returns>
        public DateTime FromBinary(long value);

        #region DateTime Now

        /// <summary>
        /// Retrieves <see cref="DateTime.Now"/> value.
        /// </summary>
        /// <returns>DateTime Now Value</returns>
        public DateTime Now();

        /// <summary>
        /// Retrieves <see cref="DateTime.Now"/> converted to long value.
        /// </summary>
        /// <returns>DateTime Now ToBinary() value</returns>
        public long NowToBinary();

        #endregion

        #region DateTime UtcNow

        /// <summary>
        /// Retrieves <see cref="DateTime.UtcNow"/> value.
        /// </summary>
        /// <returns>DateTime UtcNow Value</returns>
        public DateTime UtcNow();

        /// <summary>
        /// Retrieves <see cref="DateTime.UtcNow"/> converted to long value.
        /// </summary>
        /// <returns>DateTime UtcNow ToBinary() value</returns>
        public long UtcNowToBinary();

        #endregion

        #region DateTime Today

        /// <summary>
        /// Retrieves <see cref="DateTime.Today"/> value.
        /// </summary>
        /// <returns>DateTime Today Value</returns>
        public DateTime Today();

        /// <summary>
        /// Retrieves <see cref="DateTime.Today"/> converted to long value.
        /// </summary>
        /// <returns>DateTime Today ToBinary() value</returns>
        public long TodayToBinary();

        #endregion
    }
}
