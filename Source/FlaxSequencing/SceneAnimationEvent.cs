using System.Threading.Tasks;
using FlaxEngine;
using FlaxTasksPlugin;

namespace Sequencing;

/// <summary>
/// SceneAnimationItem Script.
/// </summary>
public class SceneAnimationEvent : SequenceEvent {
    [Serialize]
    [ShowInEditor]
    private SceneAnimationPlayer player;

    public override async Task Play() {
        player.Play();

        await FlaxTasks.Delay(player.Animation.Duration, DestroyedCancellationToken);
    }

    public override void ToEndState() {
        player.Tick(player.Animation.Duration);
    }
}
