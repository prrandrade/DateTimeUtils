namespace DateTimeUtils.UnitTest.Services
{
    using System;
    using DateTimeUtils.Services;
    using Xunit;

    public class DateTimeUtilsUnitTest
    {
        [Fact]
        public void MinValue()
        {
            // arrange
            var dateTimeUtils = new DateTimeUtils();

            // act
            var minDate = dateTimeUtils.MinValue();

            // assert
            Assert.Equal(DateTime.MinValue, minDate);
        }

        [Fact]
        public void MaxValue()
        {
            // arrange
            var dateTimeUtils = new DateTimeUtils();

            // act
            var maxDate = dateTimeUtils.MaxValue();

            // assert
            Assert.Equal(DateTime.MaxValue, maxDate);
        }

        [Fact]
        public void Now()
        {
            // arrange
            var dateTimeUtils = new DateTimeUtils();

            // act
            var now = dateTimeUtils.Now();

            // assert
            Assert.Equal(DateTime.Now, now, TimeSpan.FromMilliseconds(1));
        }

        [Fact]
        public void UtcNow()
        {
            // arrange
            var dateTimeUtils = new DateTimeUtils();

            // act
            var utcNow = dateTimeUtils.UtcNow();

            // assert
            Assert.Equal(DateTime.UtcNow, utcNow, TimeSpan.FromMilliseconds(1));
        }

        [Fact]
        public void Today()
        {
            // arrange
            var dateTimeUtils = new DateTimeUtils();

            // act
            var today = dateTimeUtils.Today();

            // assert
            Assert.Equal(DateTime.Today, today);
        }
    }
}
