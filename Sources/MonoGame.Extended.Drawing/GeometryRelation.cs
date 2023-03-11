﻿using JetBrains.Annotations;

namespace MonoGame.Extended.Drawing;

[PublicAPI]
public enum GeometryRelation
{

    Unknown = 0,
    Disjoint = 1,
    IsContained = 2,
    Contains = 3,
    Overlap = 4,

}
