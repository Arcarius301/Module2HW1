using System;
using System.Reflection;

namespace Module2HW1
{
    public class Actions
    {
        private readonly Logger _logger = Logger.Instance;
        public Result FirstMethod()
        {
            _logger.LogInformation(EventLevel.Info, $"Start method: {nameof(FirstMethod)}");
            return new Result() { Status = true };
        }

        public Result SecondMethod()
        {
            _logger.LogInformation(EventLevel.Warning, $"Skipped logic in method: {nameof(SecondMethod)}");
            return new Result() { Status = true };
        }

        public Result ThirdMethod()
        {
            return new Result() { Message = "I broke a logic" };
        }
    }
}
