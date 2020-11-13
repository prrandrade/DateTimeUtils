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
        public void FromBinary()
        {
            // arrange
            var dateTime = DateTime.UtcNow;
            var dateTimeUtils = new DateTimeUtils();

            // act
            var date = dateTimeUtils.FromBinary(dateTime.ToBinary());

            // assert
            Assert.Equal(dateTime, date);
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
        public void NowToBinary()
        {
            // arrange
            var dateTimeUtils = new DateTimeUtils();

            // act
            var now = dateTimeUtils.NowToBinary();

            // assert
            Assert.Equal(DateTime.Now, DateTime.FromBinary(now), TimeSpan.FromMilliseconds(1));
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
        public void UtcNowToBinary()
        {
            // arrange
            var dateTimeUtils = new DateTimeUtils();

            // act
            var now = dateTimeUtils.UtcNowToBinary();

            // assert
            Assert.Equal(DateTime.UtcNow, DateTime.FromBinary(now), TimeSpan.FromMilliseconds(1));
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

        [Fact]
        public void TodayToBinary()
        {
            // arrange
            var dateTimeUtils = new DateTimeUtils();

            // act
            var now = dateTimeUtils.TodayToBinary();

            // assert
            Assert.Equal(DateTime.Today, DateTime.FromBinary(now), TimeSpan.FromMilliseconds(1));
        }
    }
}
