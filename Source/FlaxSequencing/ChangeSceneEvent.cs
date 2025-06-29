using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlaxEngine;
using Sequencing;

namespace FlaxSequencing;

/// <summary>
/// ChangeSceneEvent Script.
/// </summary>
public class ChangeSceneEvent : SequenceEvent {
    [Serialize]
    [ShowInEditor]
    private SceneReference scene;

    public override Task Play() {
        Level.ChangeSceneAsync(scene);

        return Task.CompletedTask;
    }

    public override void ToEndState() {
        Level.ChangeSceneAsync(scene);
    }
}
