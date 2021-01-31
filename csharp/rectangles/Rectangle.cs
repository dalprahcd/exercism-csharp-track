using System;

namespace Exercism.CSharp.Solutions.RectanglesExercise
{
    public class Rectangle : IEquatable<Rectangle>
    {
        public Rectangle(Vertex one, Vertex two, Vertex three, Vertex four)
        {
            One = one;
            Two = two;
            Three = three;
            Four = four;
        }

        public Vertex One { get; }
        public Vertex Two { get; }
        public Vertex Three { get; }
        public Vertex Four { get; }

        public bool Equals(Rectangle other) =>
            other != null
            && One == other.One
            && Two == other.Two
            && Three == other.Three
            && Four == other.Four;

        public override bool Equals(object obj) =>
            Equals(obj as Rectangle);

        public override int GetHashCode() =>
            (One, Two, Three, Four).GetHashCode();

        public static bool operator==(Rectangle rectangle1, Rectangle rectangle2) =>
            rectangle1.Equals(rectangle2);

        public static bool operator!=(Rectangle rectangle1, Rectangle rectangle2) =>
            !rectangle1.Equals(rectangle2);
    }
}