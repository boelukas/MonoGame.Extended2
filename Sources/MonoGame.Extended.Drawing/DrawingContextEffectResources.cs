﻿using MonoGame.Extended.Drawing.Effects;

namespace MonoGame.Extended.Drawing;

internal sealed class DrawingContextEffectResources
{

    internal DrawingContextEffectResources(DrawingContext drawingContext)
    {
        SolidColorBrush = EffectResource.CreateSolidColorBrushEffectResource(drawingContext);
        LinearGradientBrush = EffectResource.CreateLinearGradientBrushEffectResource(drawingContext);
    }

    internal EffectResource SolidColorBrush { get; }

    internal EffectResource LinearGradientBrush { get; }

}
