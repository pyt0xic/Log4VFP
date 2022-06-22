using Log4VFP;

namespace Test
{
	internal class Program
	{
		public static LogManager LogManager = new LogManager("D:\\Work\\Log4VFP\\postgresql.config",
		"D:\\Work\\Log4VFP\\postgresql.log", "nic");
		public static void Main(string[] args)
		{
			var logger = LogManager.GetLogger("Test1");
			logger.Info("Hello World");
			logger.Error("Hello World");
			LogManager.Shutdown();
		}
	}
}