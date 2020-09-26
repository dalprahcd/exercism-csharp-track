using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercism.CSharp.Solutions.TournamentExercise
{
    internal static class TallyParsingService
    {
        internal static List<Team> ReadTallyResult(Stream stream)
        {
            var tallyResult = ComputeTallyResult(stream.ReadLines());
            return CorrectOrder(tallyResult);
        }

        private static List<Team> CorrectOrder(Dictionary<string, Team> tallyResult)
        {
            return tallyResult
                    .Values
                    .OrderByDescending(t => t.Points)
                    .ThenBy(t => t.Name)
                    .ToList();
        }

        private static Dictionary<string, Team> ComputeTallyResult(IEnumerable<string> lines)
        {
            var tallyResult = new Dictionary<string, Team>();

            foreach (var line in lines)
            {
                var infos = line.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

                var firstTeamName = infos[0];
                var secondTeamName = infos[1];
                var matchResult = infos[2];

                ValidateNames(tallyResult, firstTeamName, secondTeamName);

                var firstTeam = tallyResult[firstTeamName];
                var secondTeam = tallyResult[secondTeamName];

                ComputeMatchResult(matchResult, firstTeam, secondTeam);
            }

            return tallyResult;
        }

        private static void ComputeMatchResult(string matchResult, Team firstTeam, Team secondTeam)
        {
            switch (matchResult)
            {
                case "win":
                    {
                        firstTeam.Wins++;
                        secondTeam.Losses++;
                        break;
                    }

                case "loss":
                    {
                        firstTeam.Losses++;
                        secondTeam.Wins++;
                        break;
                    }

                case "draw":
                    {
                        firstTeam.Draws++;
                        secondTeam.Draws++;
                        break;
                    }
            }
        }

        private static void ValidateNames(Dictionary<string, Team> tallyResult, string firstTeamName, string secondTeamName)
        {
            if (!tallyResult.ContainsKey(firstTeamName))
            {
                tallyResult[firstTeamName] = new Team(firstTeamName);
            }

            if (!tallyResult.ContainsKey(secondTeamName))
            {
                tallyResult[secondTeamName] = new Team(secondTeamName);
            }
        }
    }
}