using System;
using FlaxEditor.Content.Settings;
using FlaxEngine;

namespace FlaxSequencing
{
    /// <summary>
    /// The sample game plugin.
    /// </summary>
    /// <seealso cref="FlaxEngine.GamePlugin" />
    public class FlaxSequencing : GamePlugin
    {
        public FlaxSequencingSettings Settings { get; private set; }

        /// <inheritdoc />
        public FlaxSequencing()
        {
            _description = new PluginDescription
            {
                Name = "FlaxSequencing",
                Category = "Other",
                Author = "ArtemPindrus",
                AuthorUrl = null,
                HomepageUrl = null,
                RepositoryUrl = "https://github.com/FlaxEngine/FlaxSequencing",
                Description = "An utility to sequence events in scene.",
                Version = new Version(),
                IsAlpha = false,
                IsBeta = false,
            };
        }

        /// <inheritdoc />
        public override void Initialize()
        {
            base.Initialize();

            var settingsAsset = Engine.GetCustomSettings("FlaxSequencingSettings");

            if (settingsAsset == null) {
                Debug.LogError("Couldn't find FlaxSequencingSettings custom settings.");
            }

            Settings = (FlaxSequencingSettings)settingsAsset.Instance;
        }

        /// <inheritdoc />
        public override void Deinitialize()
        {
            base.Deinitialize();
        }
    }
}
