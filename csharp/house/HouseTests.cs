// This file was auto-generated based on version 2.2.0 of the canonical data.

using System;
using Xunit;

namespace Exercism.CSharp.Solutions.HouseExercise.Tests
{
    public class HouseTests
    {
        [Fact]
        public void Throw_exception_on_negative_verse_number() =>
            Assert.Throws<ArgumentException>(() => House.Recite(-1));

        [Fact]
        public void Throw_exception_on_zero_verse_number() =>
            Assert.Throws<ArgumentException>(() => House.Recite(0));

        [Fact]
        public void Verse_one_the_house_that_jack_built()
        {
            const string expected = "This is the house that Jack built.";
            Assert.Equal(expected, House.Recite(1));
        }

        [Fact]
        public void Verse_two_the_malt_that_lay()
        {
            const string expected = "This is the malt that lay in the house that Jack built.";
            Assert.Equal(expected, House.Recite(2));
        }

        [Fact]
        public void Verse_three_the_rat_that_ate()
        {
            const string expected = "This is the rat that ate the malt that lay in the house that Jack built.";
            Assert.Equal(expected, House.Recite(3));
        }

        [Fact]
        public void Verse_four_the_cat_that_killed()
        {
            const string expected = "This is the cat that killed the rat that ate the malt that lay in the house that Jack built.";
            Assert.Equal(expected, House.Recite(4));
        }

        [Fact]
        public void Verse_five_the_dog_that_worried()
        {
            const string expected = "This is the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.";
            Assert.Equal(expected, House.Recite(5));
        }

        [Fact]
        public void Verse_six_the_cow_with_the_crumpled_horn()
        {
            const string expected = "This is the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.";
            Assert.Equal(expected, House.Recite(6));
        }

        [Fact]
        public void Verse_seven_the_maiden_all_forlorn()
        {
            const string expected = "This is the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.";
            Assert.Equal(expected, House.Recite(7));
        }

        [Fact]
        public void Verse_eight_the_man_all_tattered_and_torn()
        {
            const string expected = "This is the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.";
            Assert.Equal(expected, House.Recite(8));
        }

        [Fact]
        public void Verse_nine_the_priest_all_shaven_and_shorn()
        {
            const string expected = "This is the priest all shaven and shorn that married the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.";
            Assert.Equal(expected, House.Recite(9));
        }

        [Fact]
        public void Verse_ten_the_rooster_that_crowed_in_the_morn()
        {
            const string expected = "This is the rooster that crowed in the morn that woke the priest all shaven and shorn that married the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.";
            Assert.Equal(expected, House.Recite(10));
        }

        [Fact]
        public void Verse_eleven_the_farmer_sowing_his_corn()
        {
            const string expected = "This is the farmer sowing his corn that kept the rooster that crowed in the morn that woke the priest all shaven and shorn that married the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.";
            Assert.Equal(expected, House.Recite(11));
        }

        [Fact]
        public void Verse_twelve_the_horse_and_the_hound_and_the_horn()
        {
            const string expected = "This is the horse and the hound and the horn that belonged to the farmer sowing his corn that kept the rooster that crowed in the morn that woke the priest all shaven and shorn that married the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.";
            Assert.Equal(expected, House.Recite(12));
        }

        [Fact]
        public void Throw_exception_on_endVerse_greater_than_startVerse() =>
            Assert.Throws<ArgumentException>(() => House.Recite(2, 1));

        [Fact]
        public void Multiple_verses()
        {
            const string expected =
                "This is the cat that killed the rat that ate the malt that lay in the house that Jack built.\n" +
                "This is the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.\n" +
                "This is the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.\n" +
                "This is the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.\n" +
                "This is the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.";
            Assert.Equal(expected, House.Recite(4, 8));
        }

        [Fact]
        public void Full_rhyme()
        {
            const string expected =
                "This is the house that Jack built.\n" +
                "This is the malt that lay in the house that Jack built.\n" +
                "This is the rat that ate the malt that lay in the house that Jack built.\n" +
                "This is the cat that killed the rat that ate the malt that lay in the house that Jack built.\n" +
                "This is the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.\n" +
                "This is the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.\n" +
                "This is the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.\n" +
                "This is the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.\n" +
                "This is the priest all shaven and shorn that married the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.\n" +
                "This is the rooster that crowed in the morn that woke the priest all shaven and shorn that married the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.\n" +
                "This is the farmer sowing his corn that kept the rooster that crowed in the morn that woke the priest all shaven and shorn that married the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.\n" +
                "This is the horse and the hound and the horn that belonged to the farmer sowing his corn that kept the rooster that crowed in the morn that woke the priest all shaven and shorn that married the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.";
            Assert.Equal(expected, House.Recite(1, 12));
        }
    }
}