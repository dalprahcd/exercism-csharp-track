// This file was auto-generated based on version 4.0.0 of the canonical data.

using System.Collections.Generic;
using Xunit;

namespace Exercism.CSharp.Solutions.HighScoresExercise.Tests
{
    public class HighScoresTests
    {
        [Fact]
        public void List_of_scores()
        {
            var sut = new HighScores(new List<int> { 30, 50, 20, 70 });
            Assert.Equal(new List<int> { 30, 50, 20, 70 }, sut.Scores());
        }

        [Fact]
        public void Latest_score()
        {
            var sut = new HighScores(new List<int> { 100, 0, 90, 30 });
            Assert.Equal(30, sut.Latest());
        }

        [Fact]
        public void Personal_best()
        {
            var sut = new HighScores(new List<int> { 40, 100, 70 });
            Assert.Equal(100, sut.PersonalBest());
        }

        [Fact]
        public void Personal_top_three_from_a_list_of_scores()
        {
            var sut = new HighScores(new List<int> { 10, 30, 90, 30, 100, 20, 10, 0, 30, 40, 40, 70, 70 });
            Assert.Equal(new List<int> { 100, 90, 70 }, sut.PersonalTopThree());
        }

        [Fact]
        public void Personal_top_highest_to_lowest()
        {
            var sut = new HighScores(new List<int> { 20, 10, 30 });
            Assert.Equal(new List<int> { 30, 20, 10 }, sut.PersonalTopThree());
        }

        [Fact]
        public void Personal_top_when_there_is_a_tie()
        {
            var sut = new HighScores(new List<int> { 40, 20, 40, 30 });
            Assert.Equal(new List<int> { 40, 40, 30 }, sut.PersonalTopThree());
        }

        [Fact]
        public void Personal_top_when_there_are_less_than_3()
        {
            var sut = new HighScores(new List<int> { 30, 70 });
            Assert.Equal(new List<int> { 70, 30 }, sut.PersonalTopThree());
        }

        [Fact]
        public void Personal_top_when_there_is_only_one()
        {
            var sut = new HighScores(new List<int> { 40 });
            Assert.Equal(new List<int> { 40 }, sut.PersonalTopThree());
        }
    }
}