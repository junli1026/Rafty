namespace Rafty.UnitTests
{
    using Log;
    using Xunit;

    public class Tests
    {
        [Fact]
        public void ShouldApplyLog()
        {
            var log = new InMemoryLog();
            log.Apply(new LogEntry("test", typeof(string), 1, 1));
        }
    }
}