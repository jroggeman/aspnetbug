namespace BugRepro.Logging
{
    using Microsoft.Extensions.Logging;

    public sealed class TestLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new TestLogger();
        }

        public void Dispose()
        {
        }
    }
}
