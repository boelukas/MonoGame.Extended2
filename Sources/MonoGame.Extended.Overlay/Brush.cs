﻿using SkiaSharp;

namespace MonoGame.Extended.Overlay;

public abstract class Brush : DisposableBase, IPaintProvider
{

    internal abstract SKPaint Paint { get; }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            Paint.Dispose();
        }
    }

    SKPaint IPaintProvider.Paint => Paint;

}
