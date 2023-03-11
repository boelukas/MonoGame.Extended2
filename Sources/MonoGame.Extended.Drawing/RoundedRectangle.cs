﻿using JetBrains.Annotations;
using Microsoft.Xna.Framework;

namespace MonoGame.Extended.Drawing;

[PublicAPI]
public struct RoundedRectangle
{

    public RectangleF Rectangle { get; set; }

    public float RadiusX { get; set; }

    public float RadiusY { get; set; }

}
