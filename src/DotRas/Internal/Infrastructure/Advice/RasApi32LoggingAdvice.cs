﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using DotRas.Diagnostics;
using DotRas.Diagnostics.Events;
using DotRas.Internal.Interop;
using static DotRas.Internal.Interop.ExternDll;
using static DotRas.Internal.Interop.NativeMethods;
using static DotRas.Internal.Interop.Ras;

namespace DotRas.Internal.Infrastructure.Advice
{
    internal class RasApi32LoggingAdvice : LoggingAdvice<IRasApi32>, IRasApi32
    {
        public RasApi32LoggingAdvice(IRasApi32 attachedObject, IEventLoggingPolicy eventLoggingPolicy)
            : base(attachedObject, eventLoggingPolicy)
        {
        }

        public int RasClearConnectionStatistics(IntPtr hRasConn)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = AttachedObject.RasClearConnectionStatistics(hRasConn);
            stopwatch.Stop();

            var callEvent = new PInvokeInt32CallCompletedTraceEvent
            {
                DllName = RasApi32Dll,
                Duration = stopwatch.Elapsed,
                MethodName = nameof(RasClearConnectionStatistics),
                Result = result
            };

            callEvent.Args.Add(nameof(hRasConn), hRasConn);

            LogVerbose(callEvent);
            return result;
        }

        public int RasConnectionNotification(IntPtr hRasConn, SafeHandle hEvent, RASCN dwFlags)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = AttachedObject.RasConnectionNotification(hRasConn, hEvent, dwFlags);
            stopwatch.Stop();

            var callEvent = new PInvokeInt32CallCompletedTraceEvent
            {
                DllName = RasApi32Dll,
                Duration = stopwatch.Elapsed,
                MethodName = nameof(RasConnectionNotification),
                Result = result
            };

            callEvent.Args.Add(nameof(hRasConn), hRasConn);
            callEvent.Args.Add(nameof(hEvent), hEvent);
            callEvent.Args.Add(nameof(dwFlags), dwFlags);

            LogVerbose(callEvent);
            return result;
        }

        public int RasEnumConnections(RASCONN[] lpRasConn, ref int lpCb, ref int lpConnections)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = AttachedObject.RasEnumConnections(lpRasConn, ref lpCb, ref lpConnections);
            stopwatch.Stop();

            var callEvent = new PInvokeInt32CallCompletedTraceEvent
            {
                DllName = RasApi32Dll,
                Duration = stopwatch.Elapsed,
                MethodName = nameof(RasEnumConnections),
                Result = result
            };

            callEvent.Args.Add(nameof(lpRasConn), lpRasConn);
            callEvent.OutArgs.Add(nameof(lpCb), lpCb);
            callEvent.OutArgs.Add(nameof(lpConnections), lpConnections);

            LogVerbose(callEvent);
            return result;
        }

        public int RasDial(ref RASDIALEXTENSIONS lpRasDialExtensions, string lpszPhoneBook, ref RASDIALPARAMS lpRasDialParams, NotifierType dwNotifierType, RasDialFunc2 lpvNotifier, out IntPtr lphRasConn)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = AttachedObject.RasDial(ref lpRasDialExtensions, lpszPhoneBook, ref lpRasDialParams, dwNotifierType, lpvNotifier, out lphRasConn);
            stopwatch.Stop();

            var callEvent = new PInvokeInt32CallCompletedTraceEvent
            {
                DllName = RasApi32Dll,
                Duration = stopwatch.Elapsed,
                MethodName = nameof(RasDial),
                Result = result,
            };

            callEvent.Args.Add(nameof(lpRasDialExtensions), lpRasDialExtensions);
            callEvent.Args.Add(nameof(lpszPhoneBook), lpszPhoneBook);
            callEvent.Args.Add(nameof(lpRasDialParams), lpRasDialParams);
            callEvent.Args.Add(nameof(dwNotifierType), dwNotifierType);
            callEvent.Args.Add(nameof(lpvNotifier), lpvNotifier);
            callEvent.OutArgs.Add(nameof(lphRasConn), lphRasConn);

            LogVerbose(callEvent);
            return result;
        }

        public void RasFreeEapUserIdentity(EapCredential pRasEapUserIdentity)
        {
            var stopwatch = Stopwatch.StartNew();
            AttachedObject.RasFreeEapUserIdentity(pRasEapUserIdentity);
            stopwatch.Stop();

            var callEvent = new PInvokeVoidCallCompletedTraceEvent
            {
                DllName = RasApi32Dll,
                Duration = stopwatch.Elapsed,
                MethodName = nameof(RasFreeEapUserIdentity)
            };

            callEvent.Args.Add(nameof(pRasEapUserIdentity), pRasEapUserIdentity.Handle);

            LogVerbose(callEvent);
        }

        public int RasGetConnectStatus(IntPtr hRasConn, ref RASCONNSTATUS lpRasConnStatus)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = AttachedObject.RasGetConnectStatus(hRasConn, ref lpRasConnStatus);
            stopwatch.Stop();

            var callEvent = new PInvokeInt32CallCompletedTraceEvent
            {
                DllName = RasApi32Dll,
                Duration = stopwatch.Elapsed,
                MethodName = nameof(RasDial),
                Result = result,
            };

            callEvent.Args.Add(nameof(hRasConn), hRasConn);
            callEvent.OutArgs.Add(nameof(lpRasConnStatus), lpRasConnStatus);

            LogVerbose(callEvent);
            return result;
        }

        public int RasGetCredentials(string lpszPhoneBook, string lpszEntryName, ref RASCREDENTIALS lpCredentials)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = AttachedObject.RasGetCredentials(lpszPhoneBook, lpszEntryName, ref lpCredentials);
            stopwatch.Stop();

            var callEvent = new PInvokeInt32CallCompletedTraceEvent
            {
                DllName = RasApi32Dll,
                Duration = stopwatch.Elapsed,
                MethodName = nameof(RasGetCredentials),
                Result = result,
            };

            callEvent.Args.Add(nameof(lpszPhoneBook), lpszPhoneBook);
            callEvent.Args.Add(nameof(lpszEntryName), lpszEntryName);
            callEvent.OutArgs.Add(nameof(lpCredentials), lpCredentials);

            LogVerbose(callEvent);
            return result;
        }

        public int RasGetEapUserIdentity(string pszPhoneBook, string pszEntry, RASEAPF dwFlags, IntPtr hWnd, out EapCredential ppRasEapUserIdentity)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = AttachedObject.RasGetEapUserIdentity(pszPhoneBook, pszEntry, dwFlags, hWnd, out ppRasEapUserIdentity);
            stopwatch.Stop();

            var callEvent = new PInvokeInt32CallCompletedTraceEvent
            {
                DllName = RasApi32Dll,
                Duration = stopwatch.Elapsed,
                MethodName = nameof(RasGetEapUserIdentity),
                Result = result,
            };

            callEvent.Args.Add(nameof(pszPhoneBook), pszPhoneBook);
            callEvent.Args.Add(nameof(pszEntry), pszEntry);
            callEvent.Args.Add(nameof(dwFlags), dwFlags);
            callEvent.Args.Add(nameof(hWnd), hWnd);
            callEvent.OutArgs.Add(nameof(ppRasEapUserIdentity), ppRasEapUserIdentity.Handle);

            LogVerbose(callEvent);
            return result;
        }

        public int RasGetEntryDialParams(string lpszPhoneBook, ref RASDIALPARAMS lpDialParams, out bool lpfPassword)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = AttachedObject.RasGetEntryDialParams(lpszPhoneBook, ref lpDialParams, out lpfPassword);
            stopwatch.Stop();

            var callEvent = new PInvokeInt32CallCompletedTraceEvent
            {
                DllName = RasApi32Dll,
                Duration = stopwatch.Elapsed,
                MethodName = nameof(RasGetEntryDialParams),
                Result = result,
            };

            callEvent.Args.Add(nameof(lpszPhoneBook), lpszPhoneBook);
            callEvent.OutArgs.Add(nameof(lpDialParams), lpDialParams);
            callEvent.OutArgs.Add(nameof(lpfPassword), lpfPassword);

            LogVerbose(callEvent);
            return result;
        }

        public int RasGetErrorString(int uErrorValue, StringBuilder lpszErrorString, int cBufSize)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = AttachedObject.RasGetErrorString(uErrorValue, lpszErrorString, cBufSize);
            stopwatch.Stop();

            var callEvent = new PInvokeInt32CallCompletedTraceEvent
            {
                DllName = RasApi32Dll,
                Duration = stopwatch.Elapsed,
                MethodName = nameof(RasGetErrorString),
                Result = result
            };

            callEvent.Args.Add(nameof(uErrorValue), uErrorValue);
            callEvent.Args.Add(nameof(lpszErrorString), lpszErrorString);
            callEvent.Args.Add(nameof(cBufSize), cBufSize);

            LogVerbose(callEvent);
            return result;
        }

        public int RasGetConnectionStatistics(IntPtr hRasConn, ref RAS_STATS lpStatistics)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = AttachedObject.RasGetConnectionStatistics(hRasConn, ref lpStatistics);
            stopwatch.Stop();

            var callEvent = new PInvokeInt32CallCompletedTraceEvent
            {
                DllName = RasApi32Dll,
                Duration = stopwatch.Elapsed,
                MethodName = nameof(RasGetConnectionStatistics),
                Result = result
            };

            callEvent.Args.Add(nameof(hRasConn), hRasConn);
            callEvent.OutArgs.Add(nameof(lpStatistics), lpStatistics);

            LogVerbose(callEvent);
            return result;
        }

        public int RasHangUp(IntPtr hRasConn)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = AttachedObject.RasHangUp(hRasConn);
            stopwatch.Stop();

            var callEvent = new PInvokeInt32CallCompletedTraceEvent
            {
                DllName = RasApi32Dll,
                Duration = stopwatch.Elapsed,
                MethodName = nameof(RasHangUp),
                Result = result
            };

            callEvent.Args.Add(nameof(hRasConn), hRasConn);

            LogVerbose(callEvent);
            return result;
        }

        public int RasValidateEntryName(string lpszPhoneBook, string lpszEntryName)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = AttachedObject.RasValidateEntryName(lpszPhoneBook, lpszEntryName);
            stopwatch.Stop();

            var callEvent = new PInvokeInt32CallCompletedTraceEvent
            {
                DllName = RasApi32Dll,
                Duration = stopwatch.Elapsed,
                MethodName = nameof(RasValidateEntryName),
                Result = result
            };

            callEvent.Args.Add(nameof(lpszPhoneBook), lpszPhoneBook);
            callEvent.Args.Add(nameof(lpszEntryName), lpszEntryName);

            LogVerbose(callEvent);
            return result;
        }
    }
}