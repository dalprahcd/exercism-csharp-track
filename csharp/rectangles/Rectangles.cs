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
                        yield return new Vertex(row, col);
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
            rectangle.One.X == rectangle.Two.X
            && rectangle.One.Y == rectangle.Three.Y
            && rectangle.Three.X == rectangle.Four.X
            && rectangle.Two.Y == rectangle.Four.Y;

        private static bool HasCompleteSides(this Rectangle rectangle, string[] text) =>
            rectangle.IsTopValid(text)
            && rectangle.IsBottomValid(text)
            && rectangle.IsLeftSideValid(text)
            && rectangle.IsRightSideValid(text);

        private static bool IsTopValid(this Rectangle rectangle, string[] text)
        {
            if (rectangle.One.X - rectangle.Two.X > 0)
            {
                var row = rectangle.One.Y;
                return text[row].All(c => c == TopBottomIdentifier);
            }
            else
            {
                return true;
            }
        }

        private static bool IsBottomValid(this Rectangle rectangle, string[] text)
        {
            if (rectangle.Three.X - rectangle.Four.X > 0)
            {
                var row = rectangle.One.Y;
                return text[row].All(c => c == TopBottomIdentifier);
            }
            else
            {
                return true;
            }
        }

        private static bool IsLeftSideValid(this Rectangle rectangle, string[] text)
        {
            if (rectangle.One.Y - rectangle.Three.Y > 0)
            {
                var col = rectangle.One.Y;

                return text.Select(row => row[col]).All(c => c == SidesIdentifier);
            }
            else
            {
                return true;
            }
        }

        private static bool IsRightSideValid(this Rectangle rectangle, string[] text)
        {
            if (rectangle.Two.Y - rectangle.Four.Y > 0)
            {
                var col = rectangle.Two.Y;

                return text.Select(row => row[col]).All(c => c == SidesIdentifier);
            }
            else
            {
                return true;
            }
        }
    }
}