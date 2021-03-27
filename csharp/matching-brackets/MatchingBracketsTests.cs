// This file was auto-generated based on version 2.0.0 of the canonical data.

using Xunit;

namespace Exercism.CSharp.Solutions.MatchingBracketsExercise.Tests
{
    public class MatchingBracketsTests
    {
        [Fact]
        public void Paired_square_brackets()
        {
            const string value = "[]";
            Assert.True(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Empty_string()
        {
            const string value = "";
            Assert.True(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Unpaired_brackets()
        {
            const string value = "[[";
            Assert.False(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Wrong_ordered_brackets()
        {
            const string value = "}{";
            Assert.False(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Wrong_closing_bracket()
        {
            const string value = "{]";
            Assert.False(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Paired_with_whitespace()
        {
            const string value = "{ }";
            Assert.True(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Partially_paired_brackets()
        {
            const string value = "{[])";
            Assert.False(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Simple_nested_brackets()
        {
            const string value = "{[]}";
            Assert.True(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Several_paired_brackets()
        {
            const string value = "{}[]";
            Assert.True(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Paired_and_nested_brackets()
        {
            const string value = "([{}({}[])])";
            Assert.True(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Unopened_closing_brackets()
        {
            const string value = "{[)][]}";
            Assert.False(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Unpaired_and_nested_brackets()
        {
            const string value = "([{])";
            Assert.False(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Paired_and_wrong_nested_brackets()
        {
            const string value = "[({]})";
            Assert.False(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Paired_and_incomplete_brackets()
        {
            const string value = "{}[";
            Assert.False(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Too_many_closing_brackets()
        {
            const string value = "[]]";
            Assert.False(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Math_expression()
        {
            const string value = "(((185 + 223.85) * 15) - 543)/2";
            Assert.True(MatchingBrackets.IsPaired(value));
        }

        [Fact]
        public void Complex_latex_expression()
        {
            const string value = "\\left(\\begin{array}{cc} \\frac{1}{3} & x\\\\ \\mathrm{e}^{x} &... x^2 \\end{array}\\right)";
            Assert.True(MatchingBrackets.IsPaired(value));
        }
    }
}