using System.Text;

namespace Exercism.CSharp.Solutions.TournamentExercise
{
    internal static class TallyStringBuilder
    {
        private readonly static StringBuilder _builder = new StringBuilder(60);

        internal static string BuildHeader()
        {
            _builder.Clear();

            _builder
                .Append("Team".PadRight(31))
                .Append("| MP ")
                .Append("|  W ")
                .Append("|  D ")
                .Append("|  L ")
                .Append("|  P");

            return _builder.ToString();
        }

        internal static string BuildTeam(Team team)
        {
            _builder.Clear();

            _builder
                .Append(team.Name.PadRight(31))
                .Append("|  ").Append(team.MatchesPlayed).Append(' ')
                .Append("|  ").Append(team.Wins).Append(' ')
                .Append("|  ").Append(team.Draws).Append(' ')
                .Append("|  ").Append(team.Losses).Append(' ')
                .Append("|  ").Append(team.Points);

            return _builder.ToString();
        }
    }
}