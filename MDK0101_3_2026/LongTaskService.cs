using System;
using System.Collections.Generic;
using System.Text;

namespace MDK0101_3_2026
{
    internal class LongTaskService
    {
        public void Work(int steps, Action<int> onProgress, Func<bool> isCancelled)
        {
            for(int i = 0; i < steps; i++)
            {
                if (isCancelled())
                    return;
                Thread.Sleep(500); //задержка текущего потока в 0,5 сек
                onProgress(i * 100 / steps);
            }
        }
    }
}
