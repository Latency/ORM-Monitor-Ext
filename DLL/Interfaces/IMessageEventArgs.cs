﻿// ****************************************************************************
// Project:  AsyncTask
// File:     IMessageEventArgs.cs
// Author:   Latency McLaughlin
// Date:     08/24/2020
// ****************************************************************************

using System;

namespace AsyncTask.Interfaces
{
    public interface IMessageEventArgs
    {
        string Message { get; set; }
        Exception Exception { get; set; }
    }
}