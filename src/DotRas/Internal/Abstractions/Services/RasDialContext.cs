﻿using System;
using System.Net;
using System.Threading;
using DotRas.ExtensibleAuthentication;

namespace DotRas.Internal.Abstractions.Services
{
    internal class RasDialContext
    {
        public string PhoneBookPath { get; set; }
        public string EntryName { get; set; }
        public NetworkCredential Credentials { get; set; }
        public Action<StateChangedEventArgs> OnStateChangedCallback { get; set; }
        public RasDialerOptions Options { get; set; }
        public CancellationToken CancellationToken { get; set; }        
    }
}