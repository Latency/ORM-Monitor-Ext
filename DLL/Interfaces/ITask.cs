﻿// ****************************************************************************
// Project:  AsyncTask
// File:     ITask.cs
// Author:   Latency McLaughlin
// Date:     08/24/2020
// ****************************************************************************

namespace AsyncTask.Interfaces
{
    public interface ITask
    {
        ILogger Logger { get; set; }
        void Cancel(bool throwOnFirstException = false);
    }
}