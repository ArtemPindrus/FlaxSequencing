using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlaxEngine;
using Sequencing;

namespace FlaxSequencing;

/// <summary>
/// ChangeMultipleActiveEvent Script.
/// </summary>
public class ChangeMultipleActiveEvent : SequenceEvent
{
    [Serialize]
    [ShowInEditor]
    private Actor[] actors;

    [Serialize]
    [ShowInEditor]
    private bool state;

    public override Task Play() {
        foreach (var a in actors) {
            a.IsActive = state;
        }

        return Task.CompletedTask;
    }

    public override void ToEndState() {
        foreach (var a in actors) {
            a.IsActive = state;
        }
    }
}
