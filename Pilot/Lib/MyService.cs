using System;
namespace Pilot.Lib
{
    public class MyService : IMyService
    {
        public MyService()
        {
        }

        public String Run()
        {
            return "Running...";
        }
    }
}
