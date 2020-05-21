﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Graphics;
using osu.Framework.Utils;
using osuTK.Graphics;

namespace osu.Game.Rulesets.Catch.Objects.Drawables
{
    public class DrawableBanana : DrawableFruit
    {
        public DrawableBanana(Banana h)
            : base(h)
        {
        }

        private Colour4? colour;

        protected override Colour4 GetComboColour(IReadOnlyList<Colour4> comboColours)
        {
            // override any external colour changes with banananana
            return colour ??= getBananaColour();
        }

        protected override void UpdateInitialTransforms()
        {
            base.UpdateInitialTransforms();

            const float end_scale = 0.6f;
            const float random_scale_range = 1.6f;

            ScaleContainer.ScaleTo(HitObject.Scale * (end_scale + random_scale_range * RNG.NextSingle()))
                          .Then().ScaleTo(HitObject.Scale * end_scale, HitObject.TimePreempt);

            ScaleContainer.RotateTo(getRandomAngle())
                          .Then()
                          .RotateTo(getRandomAngle(), HitObject.TimePreempt);

            float getRandomAngle() => 180 * (RNG.NextSingle() * 2 - 1);
        }

        private Colour4 getBananaColour()
        {
            switch (RNG.Next(0, 3))
            {
                default:
                    return new Colour4(255, 240, 0, 255);

                case 1:
                    return new Colour4(255, 192, 0, 255);

                case 2:
                    return new Colour4(214, 221, 28, 255);
            }
        }
    }
}
