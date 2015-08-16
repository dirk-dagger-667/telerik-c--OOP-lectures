namespace ShapesAndShit
{
    using System;
    public interface IShape
    {
        double Width { get;  }
        double Height { get; }
       double CalcSurface();
    }
}
