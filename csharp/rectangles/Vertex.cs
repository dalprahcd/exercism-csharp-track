using System;

namespace Exercism.CSharp.Solutions.RectanglesExercise
{
    public class Vertex : IEquatable<Vertex>
    {
        public Vertex(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }

        public int Y { get; }

        public bool Equals(Vertex other)
        {
            if (other is null) { return false; }
            if (ReferenceEquals(this, other)) { return true; }

            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj) =>
            Equals(obj as Vertex);

        public override int GetHashCode() =>
            HashCode.Combine(X, Y);

        public static bool operator ==(Vertex vertex1, Vertex vertex2) =>
            vertex1.Equals(vertex2);

        public static bool operator !=(Vertex vertex1, Vertex vertex2) =>
            !(vertex1 == vertex2);
    }
}