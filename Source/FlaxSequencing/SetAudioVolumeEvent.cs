using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlaxEngine;
using Sequencing;

namespace FlaxSequencing;

/// <summary>
/// SetAudioVolumeEvent Script.
/// </summary>
public class SetAudioVolumeEvent : SequenceEvent {
    [Serialize]
    [ShowInEditor]
    private AudioSource source;

    [Serialize]
    [ShowInEditor]
    private float volume;

    public override Task Play() {
        source.Volume = volume;

        return Task.CompletedTask;
    }

    public override void ToEndState() {
        source.Volume = volume;
    }
}
