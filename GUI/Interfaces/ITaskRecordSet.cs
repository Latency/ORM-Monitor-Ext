﻿// ****************************************************************************
// Project:  GUI
// File:     ITaskRecordSet.cs
// Author:   Latency McLaughlin
// Date:     08/28/2020
// ****************************************************************************
// ReSharper disable InconsistentNaming

using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using AsyncTask.Interfaces;

namespace ORM_Monitor.Interfaces
{
    /// <summary>
    ///     IServiceTask
    /// </summary>
    public interface ITaskRecordSet : ITaskInfo
    {
        /// <summary>
        ///     ID
        /// </summary>
        int ID { get; set; }

        /// <summary>
        ///     Description
        /// </summary>
        string Description { get; set; }

        /// <summary>
        ///     Priority
        /// </summary>
        int Priority { get; set; }

        /// <summary>
        ///     Progress
        /// </summary>
        ushort Progress { get; set; }

        /// <summary>
        ///     Status
        /// </summary>
        TaskStatus Status { get; set; }

        /// <summary>
        ///     Action
        /// </summary>
        Button Action { get; set; }

        /// <summary>
        ///     Date
        /// </summary>
        DateTime? Date { get; set; }

        /// <summary>
        ///     Tag
        /// </summary>
        object Tag { get; set; }
    }
}