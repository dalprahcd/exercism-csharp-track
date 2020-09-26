namespace Exercism.CSharp.Solutions.TournamentExercise
{
    internal class Team
    {
        internal Team(string name) => Name = name;
        internal string Name { get; }
        internal int Wins { get; set; }
        internal int Draws { get; set; }
        internal int Losses { get; set; }
        internal int MatchesPlayed => Wins + Draws + Losses;
        internal int Points => (3 * Wins) + Draws;
    }
}