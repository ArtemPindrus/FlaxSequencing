using Flax.Build;

public class FlaxSequencingEditorTarget : GameProjectEditorTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for editor
        Modules.Add("FlaxSequencing");
        Modules.Add("FlaxSequencingEditor");
    }
}
