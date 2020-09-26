using System.Collections.Generic;
using System.IO;

namespace Exercism.CSharp.Solutions.TournamentExercise
{
    public static class Tournament
    {
        public static void Tally(Stream inStream, Stream outStream)
        {
            var tallyResult = TallyParsingService.ReadTallyResult(inStream);
            var tallyResultLines = new List<string>
            {
                TallyStringBuilder.BuildHeader()
            };

            foreach (var team in tallyResult)
            {
                tallyResultLines.Add(TallyStringBuilder.BuildTeam(team));
            }

            outStream.WriteLine(string.Join('\n', tallyResultLines));
        }
    }
}