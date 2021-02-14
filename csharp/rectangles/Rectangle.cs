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

        public bool Equals(Rectangle other)
        {
            if (other is null) { return false; }
            if (ReferenceEquals(this, other)) { return true; }

            return One == other.One
            && Two == other.Two
            && Three == other.Three
            && Four == other.Four;
        }

        public override bool Equals(object obj) =>
            Equals(obj as Rectangle);

        public override int GetHashCode() =>
            HashCode.Combine(One, Two, Three, Four);

        public static bool operator==(Rectangle rectangle1, Rectangle rectangle2) =>
            rectangle1.Equals(rectangle2);

        public static bool operator!=(Rectangle rectangle1, Rectangle rectangle2) =>
            !(rectangle1 == rectangle2);
    }
}