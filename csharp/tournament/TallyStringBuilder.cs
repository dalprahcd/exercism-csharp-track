using System.Text;

namespace Exercism.CSharp.Solutions.TournamentExercise
{
    internal static class TallyStringBuilder
    {
        private readonly static StringBuilder tallyStringBuilder = new StringBuilder(60);

        internal static string BuildHeader()
        {
            tallyStringBuilder.Clear();

            tallyStringBuilder
                .Append("Team".PadRight(31))
                .Append("| MP ")
                .Append("|  W ")
                .Append("|  D ")
                .Append("|  L ")
                .Append("|  P");

            return tallyStringBuilder.ToString();
        }

        internal static string BuildTeam(Team team)
        {
            tallyStringBuilder.Clear();

            tallyStringBuilder
                .Append(team.Name.PadRight(31))
                .Append("|  ").Append(team.MatchesPlayed).Append(' ')
                .Append("|  ").Append(team.Wins).Append(' ')
                .Append("|  ").Append(team.Draws).Append(' ')
                .Append("|  ").Append(team.Losses).Append(' ')
                .Append("|  ").Append(team.Points);

            return tallyStringBuilder.ToString();
        }
    }
}