// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Graphics;
using osuTK.Graphics;

namespace osu.Game.Online.Multiplayer.RoomStatuses
{
    public class RoomStatusOpen : RoomStatus
    {
        public override string Message => @"Welcoming Players";
        public override Colour4 GetAppropriateColour(OsuColour colours) => colours.GreenLight;
    }
}
