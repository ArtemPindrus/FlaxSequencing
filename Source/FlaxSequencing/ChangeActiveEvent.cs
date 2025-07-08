using System.Threading.Tasks;
using FlaxEngine;
using Sequencing;

namespace FlaxSequencing;

/// <summary>
/// ChangeActiveEvent Script.
/// </summary>
public class ChangeActiveEvent : SequenceEvent {
    [Serialize]
    [ShowInEditor]
    private Actor actor;

    [Serialize]
    [ShowInEditor]
    private bool state;

    public override Task Play() {
        actor.IsActive = state;

        return Task.CompletedTask;
    }

    public override void ToEndState() {
        actor.IsActive = state;
    }
}
