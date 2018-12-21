﻿using DotRas.Diagnostics;

namespace DotRas.Tests.Stubs
{
    public class BadFormatter : IFormatter<BadTraceEventWithBadFormatter>
    {
        private readonly string result;

        public BadFormatter(string result)
        {
            this.result = result;
        }

        public string Format(BadTraceEventWithBadFormatter value)
        {
            return result;
        }
    }
}