using System;
using System.Collections.Generic;
using System.Text;

namespace HangFireDemo.Core
{
    public interface IHangfireCounter
    {
        int GetLimit();
        int GetCounter();
        void AddCounter();
        void ResetCounter();
    }
}
