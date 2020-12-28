// This file was auto-generated based on version  of the canonical data.
using System;
using Xunit;

namespace Exercism.CSharp.Solutions.ResistorColorDuoExercise.Tests
{
    public class ResistorColorDuoTests
    {
        [Fact]
        public void Should_ThrowException_OnNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            ResistorColorDuo.Value(null));
        }

        [Fact]
        public void Should_ThrowException_NotEnoughColors()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            ResistorColorDuo.Value(new[] { "black" }));
        }

        [Fact]
        public void Should_ThrowException_InvalidColor()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            ResistorColorDuo.Value(new[] { "cyan" }));
        }

        [Fact]
        public void Brown_and_black()
        {
            Assert.Equal(10, ResistorColorDuo.Value(new[] { "brown", "black" }));
        }

        [Fact]
        public void Blue_and_grey()
        {
            Assert.Equal(68, ResistorColorDuo.Value(new[] { "blue", "grey" }));
        }

        [Fact]
        public void Yellow_and_violet()
        {
            Assert.Equal(47, ResistorColorDuo.Value(new[] { "yellow", "violet" }));
        }

        [Fact]
        public void Orange_and_orange()
        {
            Assert.Equal(33, ResistorColorDuo.Value(new[] { "orange", "orange" }));
        }

        [Fact]
        public void Ignore_additional_colors()
        {
            Assert.Equal(51, ResistorColorDuo.Value(new[] { "green", "brown", "orange" }));
        }
    }
}