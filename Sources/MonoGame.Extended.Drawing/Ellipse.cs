﻿using JetBrains.Annotations;
using Microsoft.Xna.Framework;

namespace MonoGame.Extended.Drawing;

[PublicAPI]
public struct Ellipse
{

    public Vector2 Point { get; set; }

    public float RadiusX { get; set; }

    public float RadiusY { get; set; }

}
