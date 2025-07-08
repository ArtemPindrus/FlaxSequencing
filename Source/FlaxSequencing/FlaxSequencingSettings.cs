using System;
using System.Collections.Generic;
using FlaxEngine;
using Sequencing;

namespace FlaxSequencing;

/// <summary>
/// FlaxSequencingSettings class.
/// </summary>
public class FlaxSequencingSettings
{
    /// <summary>
    /// Whether to skip events in <see cref="Sequence"/> in shipped/cooked games.
    /// </summary>
    public bool skipInShipped;
}
