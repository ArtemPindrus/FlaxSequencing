using Flax.Build;

public class FlaxSequencingTarget : GameProjectTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for game
        Modules.Add("FlaxSequencing");
    }
}
