﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HangFireDemo.Core
{
    public class HangfireCounter : IHangfireCounter
    {
        public int counter {get; set;}
        public int limit { get; set; }

        public int GetLimit()
        {
            return limit;
        }

        public void AddCounter()
        {
            counter++;
        }

        public void ResetCounter()
        {
            counter = 0;
        }

        public int GetCounter()
        {
            return counter;
        }
    }
}
