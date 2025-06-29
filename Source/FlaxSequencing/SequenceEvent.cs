using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlaxEngine;
using FlaxTasksPlugin;

namespace Sequencing;

/// <summary>
/// SequenceItem Script.
/// </summary>
public abstract class SequenceEvent : TaskScript
{
    [Serialize]
    [ShowInEditor]
    public bool IsDebugOnly { get; protected set; }

    [Serialize]
    [ShowInEditor]
    public bool ShouldBeAwaited { get; protected set; } = true;

    public abstract Task Play();

    /// <summary>
    /// Bring scene to the end state of sequence item.
    /// </summary>
    public abstract void ToEndState();
}
