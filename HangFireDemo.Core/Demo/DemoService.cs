using System;

namespace HangFireDemo.Core
{
    public interface IDemoService
    {
        void RunDemoTask();

    }
    public class DemoService : IDemoService
    {
        private IHangfireCounter _hangfireCounter;
        public DemoService(IHangfireCounter hangfireCounter)
        {
            _hangfireCounter = hangfireCounter;
        }
        public void RunDemoTask()
        {
            //if (_hangfireCounter.GetCounter() < _hangfireCounter.GetLimit())
            //{
            //    Console.WriteLine($"MSSQL server is being accessed. Counter: {_hangfireCounter.GetCounter()}.");
            //    _hangfireCounter.AddCounter();
            //}
            //else
            //{
            //    Console.WriteLine($"Clearing the event session buffer. Counter: {_hangfireCounter.GetCounter()}.");
            //    _hangfireCounter.ResetCounter();
            //}

            Console.WriteLine($"MSSQL server is being accessed. Counter: {_hangfireCounter.GetCounter()}, Limit: {_hangfireCounter.GetLimit()}");
            _hangfireCounter.AddCounter();
        }
    }
}
