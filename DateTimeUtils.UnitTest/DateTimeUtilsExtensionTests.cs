namespace DateTimeUtils.UnitTest
{
    using Interefaces;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class DateTimeUtilsExtensionTests
    {
        [Fact]
        public void AddDateTimeUtils()
        {
            // arrange
            var services = new ServiceCollection();

            // act
            services.AddDateTimeUtils();
            var container = services.BuildServiceProvider();
            var service1 = container.GetService<IDateTimeUtils>();
            var service2 = container.GetService<IDateTimeUtils>();

            // assert
            Assert.NotNull(container.GetService<IDateTimeUtils>());
            Assert.Equal(service1, service2);
        }
    }
}
