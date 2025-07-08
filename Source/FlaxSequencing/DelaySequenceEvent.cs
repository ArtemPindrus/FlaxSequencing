using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlaxEngine;
using FlaxTasksPlugin;
using Sequencing;

namespace FlaxSequencing;

/// <summary>
/// DelaySequenceEvent Script.
/// </summary>
public class DelaySequenceEvent : SequenceEvent {
    /// <summary>
    /// Delayed time in seconds. Don't forget to set <see cref="ShouldBeAwaited"/> to true!
    /// </summary>
    [Serialize]
    [ShowInEditor]
    private float time;

    public override async Task Play() {
        await FlaxTasks.Delay(time, DestroyedCancellationToken);
    }

    public override void ToEndState() {
        // do nothing
    }
}
