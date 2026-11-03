using System;
using System.Collections.Generic;
using System.Text;

namespace MDK0101_3_2026
{
    internal class LongTaskService
    {
        public void Process(int steps, Action<int> onProgress, Func<bool> isCancelled)
        {
            for(int i = 0; i< steps; i++)
            {
                if (isCancelled())
                    return;
                Thread.Sleep(1000);
                onProgress(i * 100 / steps);
            }
        }
    }
}
