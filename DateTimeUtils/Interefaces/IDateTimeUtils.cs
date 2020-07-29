namespace DateTimeUtils.Interefaces
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
        /// Retrieves <see cref="DateTime.Now"/> value.
        /// </summary>
        /// <returns>DateTime Now Value</returns>
        public DateTime Now();

        /// <summary>
        /// Retrieves <see cref="DateTime.UtcNow"/> value.
        /// </summary>
        /// <returns>DateTime UtcNow Value</returns>
        public DateTime UtcNow();

        /// <summary>
        /// Retrieves <see cref="DateTime.Today"/> value.
        /// </summary>
        /// <returns>DateTime Today Value</returns>
        public DateTime Today();
    }
}
