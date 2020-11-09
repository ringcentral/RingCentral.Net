using System;

namespace RingCentral.Net.Debug
{
    public class DebugOptions
    {
        public static readonly DebugOptions DefaultInstance = new DebugOptions();
        public Action<string> loggingAction = Console.WriteLine;
    }
}