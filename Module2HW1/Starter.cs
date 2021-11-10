using System;
using System.IO;

namespace Module2HW1
{
    public class Starter
    {
        public void Run()
        {
            Random random = new Random();
            Logger logger = Logger.Instance;
            Actions actions = new Actions();
            Result result = new Result();

            for (int i = 1; i <= 100; i++)
            {
                switch (random.Next(1, 4))
                {
                    case 1:
                        result = actions.FirstMethod();
                        break;
                    case 2:
                        result = actions.SecondMethod();
                        break;
                    case 3:
                        result = actions.ThirdMethod();
                        break;
                }

                if (result.Status.Equals(false))
                {
                    logger.LogInformation(EventLevel.Error, $"Action failed by a reason: {result.Message}");
                }
            }

            File.WriteAllText("log.txt", logger.GetLog());
        }
    }
}
