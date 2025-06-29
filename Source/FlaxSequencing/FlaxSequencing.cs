using System;
using FlaxEngine;

namespace FlaxSequencing
{
    /// <summary>
    /// The sample game plugin.
    /// </summary>
    /// <seealso cref="FlaxEngine.GamePlugin" />
    public class FlaxSequencing : GamePlugin
    {
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
        }

        /// <inheritdoc />
        public override void Deinitialize()
        {
            base.Deinitialize();
        }
    }
}
