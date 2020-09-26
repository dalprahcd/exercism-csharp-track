using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exercism.CSharp.Solutions.TournamentExercise
{
    internal static class StreamExtensions
    {
        internal static Stream WriteLine(this Stream stream, string line, Encoding encoding = default)
        {
            if (encoding == default)
            {
                encoding = new UTF8Encoding();
            }

            var bytes = encoding.GetBytes(line);

            stream.Write(bytes, 0, bytes.Length);

            return stream;
        }

        internal static IEnumerable<string> ReadLines(this Stream stream, Encoding encoding = default)
        {
            if (encoding == default)
            {
                encoding = new UTF8Encoding();
            }

            using var streamReader = new StreamReader(stream, encoding);

            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                yield return line;
            }
        }
    }
}