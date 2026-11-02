using Silk.NET.Maths;

namespace System.Numerics;

internal static class RectExtensions
{
    extension<T>(Rect<T> rect)
        where T : unmanaged, INumber<T>
    {
        public static Rect<T> Gen(T num) => new(num++, num++, num++, num++);

        public Rectangle<T> Silk() => new(rect.Min.Silk(), rect.Max.Silk() - rect.Min.Silk());
    }

    extension<T>(Rectangle<T> rect)
        where T : unmanaged, INumber<T>
    {
        public Rect<T> Rect() => new(rect.Origin.Vec2(), (rect.Origin + rect.Size).Vec2());
    }
}
