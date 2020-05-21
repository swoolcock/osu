// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Graphics;
using osuTK.Graphics;

namespace osu.Game.Beatmaps.Formats
{
    public interface IHasComboColours
    {
        /// <summary>
        /// Retrieves the list of combo colours for presentation only.
        /// </summary>
        IReadOnlyList<Colour4> ComboColours { get; }

        /// <summary>
        /// Adds combo colours to the list.
        /// </summary>
        void AddComboColours(params Colour4[] colours);
    }
}
