using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.RectanglesExercise
{
    public static class Rectangles
    {
        private const char VertexIdentifier = '+';
        private const char TopBottomIdentifier = '-';
        private const char SidesIdentifier = '|';

        /*
        *   Not the most performatic solution, but it gets the job done.
        *   If performance is a must, better use another algorithm.
        */
        public static int Count(string[] rows) =>
            ExtractVertices(rows)
            .Combinations(4)
            .ExtractRectangles()
            .ValidateRectangles()
            .Distinct()
            .Count(rectangle => rectangle.HasCompleteSides(rows));

        private static IEnumerable<Vertex> ExtractVertices(string[] text)
        {
            for (int row = 0; row < text.Length; row++)
            {
                for (int col = 0; col < text[row].Length; col++)
                {
                    if (text[row][col] == VertexIdentifier)
                    {
                        yield return new Vertex(col, row);
                    }
                }
            }
        }

        private static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> elements, int k) =>
            k == 0
                ? new[] { new T[0] }
                : elements.SelectMany((e, i) => elements.Skip(i + 1).Combinations(k - 1).Select(c => (new[] { e }).Concat(c)));

        private static IEnumerable<Rectangle> ExtractRectangles(this IEnumerable<IEnumerable<Vertex>> groupOfVertices)
        {
            foreach (var vertices in groupOfVertices)
            {
                var one = vertices.ElementAt(0);
                var two = vertices.ElementAt(1);
                var three = vertices.ElementAt(2);
                var four = vertices.ElementAt(3);

                yield return new Rectangle(one, two, three, four);
            }
        }

        private static IEnumerable<Rectangle> ValidateRectangles(this IEnumerable<Rectangle> rectangles) =>
            rectangles.Where(IsValidRectangle);

        private static bool IsValidRectangle(this Rectangle rectangle) =>
            rectangle.One.Y == rectangle.Two.Y
            && rectangle.One.X == rectangle.Three.X
            && rectangle.Three.Y == rectangle.Four.Y
            && rectangle.Two.X == rectangle.Four.X;

        private static bool HasCompleteSides(this Rectangle rectangle, string[] text) =>
            rectangle.IsTopValid(text)
            && rectangle.IsBottomValid(text)
            && rectangle.IsLeftSideValid(text)
            && rectangle.IsRightSideValid(text);

        private static bool IsTopValid(this Rectangle rectangle, string[] text)
        {
            var length = rectangle.Two.X - rectangle.One.X;
            if (length > 0)
            {
                var row = rectangle.One.Y;

                return text[row]
                .Skip(rectangle.One.X + 1)
                .Take(length - 1)
                .All(c => c == TopBottomIdentifier || c == VertexIdentifier);
            }
            else
            {
                return true;
            }
        }

        private static bool IsBottomValid(this Rectangle rectangle, string[] text)
        {
            var length = rectangle.Four.X - rectangle.Three.X;
            if (length > 0)
            {
                var row = rectangle.Three.Y;

                return text[row]
                .Skip(rectangle.Three.X + 1)
                .Take(length - 1)
                .All(c => c == TopBottomIdentifier || c == VertexIdentifier);
            }
            else
            {
                return true;
            }
        }

        private static bool IsLeftSideValid(this Rectangle rectangle, string[] text)
        {
            var length = rectangle.Three.Y - rectangle.One.Y;
            if (length > 0)
            {
                var col = rectangle.One.X;

                return text
                .Select(row => row[col])
                .Skip(rectangle.One.Y + 1)
                .Take(length - 1)
                .All(c => c == SidesIdentifier || c == VertexIdentifier);
            }
            else
            {
                return true;
            }
        }

        private static bool IsRightSideValid(this Rectangle rectangle, string[] text)
        {
            var length = rectangle.Four.Y - rectangle.Two.Y;
            if (length > 0)
            {
                var col = rectangle.Two.X;

                return text
                .Select(row => row[col])
                .Skip(rectangle.Two.Y + 1)
                .Take(length - 1)
                .All(c => c == SidesIdentifier || c == VertexIdentifier);
            }
            else
            {
                return true;
            }
        }
    }
}