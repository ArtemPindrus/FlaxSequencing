using System.Collections.Generic;
using System.Threading.Tasks;
using FlaxEngine;

namespace Sequencing;

/// <summary>
/// Sequence Script.
/// </summary>
public class Sequence : Script
{
    [Serialize]
    [ShowInEditor]
    private bool playOnStart;

    [Serialize]
    [ShowInEditor]
    private int tickUntil = -1;

    [Serialize]
    [ReadOnly]
    private List<SequenceEvent> sequenceItems;

    [ShowInEditor]
    [ReadOnly]
    private SequenceEvent? currentlyPlaying;

    public override async void OnStart() {
        sequenceItems = new();

        foreach (var c in Actor.Children) {
            if (c.TryGetScript(out SequenceEvent si)) sequenceItems.Add(si);
        }

        BringToEndState(tickUntil);

        Play(tickUntil + 1, sequenceItems.Count - 1);
    }

    /// <summary>
    /// Bring to the end state of sequence when <paramref name="index"/> item finishes.
    /// </summary>
    /// <param name="index"></param>
    public void BringToEndState(int index) {
        for (int i = 0; i <= index; i++) {
            sequenceItems[i].ToEndState();
        }
    }

    public async Task Play(int startIndex, int endIndex) {
        for (int i = startIndex; i <= endIndex; i++) {
            var item = sequenceItems[i];

            if (item.IsDebugOnly && !Engine.IsEditor) continue;

            currentlyPlaying = item;

            var task = item.Play();
            if (item.ShouldBeAwaited) await task;
        }

        currentlyPlaying = null;
    }
}
