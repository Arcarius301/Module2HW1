using System;
using System.IO;

namespace Module2HW1
{
    public class Starter
    {
        private Actions _actions = new Actions();
        public void Run()
        {
            var random = new Random();
            var logger = Logger.Instance;
            Result result = null;

            for (int i = 0; i <= 100; i++)
            {
                switch (random.Next(1, 4))
                {
                    case 1:
                        result = _actions.FirstMethod();
                        break;
                    case 2:
                        result = _actions.SecondMethod();
                        break;
                    case 3:
                        result = _actions.ThirdMethod();
                        break;
                }

                if (!result.Status)
                {
                    logger.LogInformation(EventLevel.Error, $"Action failed by a reason: {result.Message}");
                }
            }

            File.WriteAllText("log.txt", logger.GetLog());
        }
    }
}
