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
    [Serialize]
    [ShowInEditor]
    private AudioSource source;

    [Serialize]
    [ShowInEditor]
    private float timeDelta;

    [Serialize]
    [ShowInEditor]
    private bool enableSource;

    public override async Task Play() {
        if (enableSource) source.IsActive = true;

        source.Play();

        await FlaxTasks.Delay(source.Clip.Length + timeDelta, DestroyedCancellationToken);
    }

    public override void ToEndState() {
        // do nothing
        if (enableSource) source.IsActive = true;

        if (source.IsLooping) source.Play();
    }
}
