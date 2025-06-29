using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlaxEngine;
using Sequencing;

namespace FlaxSequencing;

/// <summary>
/// SetScriptState Script.
/// </summary>
public class SetScriptState : SequenceEvent
{
    [Serialize]
    [ShowInEditor]
    private Script script;

    [Serialize]
    [ShowInEditor]
    private bool state;

    public override Task Play() {
        script.Enabled = state;

        return Task.CompletedTask;
    }

    public override void ToEndState() {
        script.Enabled = state;
    }
}
