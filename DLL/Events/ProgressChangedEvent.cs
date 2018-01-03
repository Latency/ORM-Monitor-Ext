﻿// **************************************************************************
// File:      ProgressChangedEvent.cs
// Solution:  ORM-Monitor
// Project:   ORM-Monitor
// Date:      01/01/2018
// Author:    Latency McLaughlin
// Copywrite: Bio-Hazard Industries - 1998-2018
// ***************************************************************************

namespace ORM_Monitor.Events {
  /// <inheritdoc />
  /// <summary>
  ///   RunningEvent - Handler handler renamed as custom type definition by composition.
  /// </summary>
  public class ProgressChangedEvent : TaskEventHandler {
    #region Constructor
    // -----------------------------------------------------------------------

    /// <inheritdoc />
    /// <summary>
    ///   Constructor
    /// </summary>
    /// <param name="taskEvent"></param>
    public ProgressChangedEvent(TaskEvent taskEvent) : base(taskEvent) { }

    // -----------------------------------------------------------------------
    #endregion Constructor


    #region Handler Method
    // -----------------------------------------------------------------------

    /// <inheritdoc />
    /// <summary>
    ///   OnCanceledEvent
    /// </summary>
    /// <param name="tea"></param>
    public override void Invoke(TaskEventArgs tea) => TaskEvent.OnProgressChanged?.Invoke(this, tea);

    // -----------------------------------------------------------------------
    #endregion Handler Method
  }
}