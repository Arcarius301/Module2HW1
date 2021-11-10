using System;
using System.Reflection;

namespace Module2HW1
{
    public class Actions
    {
        private Logger _logger = Logger.Instance;
        public Result FirstMethod()
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            _logger.LogInformation(EventLevel.Info, $"Start method: {m.Name}");
            return new Result() { Status = true };
        }

        public Result SecondMethod()
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            _logger.LogInformation(EventLevel.Warning, $"Skipped logic in method: {m.Name}");
            return new Result() { Status = true };
        }

        public Result ThirdMethod()
        {
            return new Result() { Status = false, Message = "I broke a logic" };
        }
    }
}
