using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlaxEngine;
using Sequencing;

namespace FlaxSequencing;

/// <summary>
/// SetPositionEvent Script.
/// </summary>
public class SetPositionEvent : SequenceEvent {
    [Serialize]
    [ShowInEditor]
    private Actor actor;

    [Serialize]
    [ShowInEditor]
    private Vector3 position;

    public override Task Play() {
        actor.Position = position;

        return Task.CompletedTask;
    }

    public override void ToEndState() {
        actor.Position = position;
    }
}
