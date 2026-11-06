using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDemo
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; }
        public MessageEventArgs(string message) 
        {
            Message = message;
        }
    }
}
