using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlaxEngine;
using FlaxTasksPlugin;

namespace Sequencing;

/// <summary>
/// AudioItem Script.
/// </summary>
public class AudioEvent : SequenceEvent {
    public AudioSource source;

    public override async Task Play() {
        source.Play();

        await FlaxTasks.Delay(source.Clip.Length, DestroyedCancellationToken);
    }

    public override void ToEndState() {
        // do nothing
    }
}
