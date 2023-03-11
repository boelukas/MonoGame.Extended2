﻿using JetBrains.Annotations;
using Microsoft.Xna.Framework;

namespace MonoGame.Extended.Drawing;

[PublicAPI]
public struct RadialGradientBrushProperties
{

    public Vector2 Center { get; set; }

    public Vector2 GradientOriginOffset { get; set; }

    public float RadiusX { get; set; }

    public float RadiusY { get; set; }

}
