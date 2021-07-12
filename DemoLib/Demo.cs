using System;
using System.Reflection;

namespace DemoLib
{
    public class Demo
    {
        public static void Trace()
        {
            Console.WriteLine("Tracing...");
            Console.WriteLine($"Executing Assembly: {Assembly.GetExecutingAssembly()}");
            Console.WriteLine($"Entry Assembly: {Assembly.GetEntryAssembly()}");
            Console.WriteLine($"Calling Assembly: {Assembly.GetCallingAssembly()}");
        }
    }
}
