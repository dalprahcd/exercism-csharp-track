// This file was auto-generated based on version 1.7.0 of the canonical data.

using System;
using Xunit;

namespace Exercism.CSharp.Solutions.PhoneNumberExercise.Tests
{
    public class PhoneNumberTests
    {
        [Fact]
        public void Cleans_the_number()
        {
            const string phrase = "(223) 456-7890";
            Assert.Equal("2234567890", PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Cleans_numbers_with_dots()
        {
            const string phrase = "223.456.7890";
            Assert.Equal("2234567890", PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Cleans_numbers_with_multiple_spaces()
        {
            const string phrase = "223 456   7890   ";
            Assert.Equal("2234567890", PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Invalid_when_9_digits()
        {
            const string phrase = "123456789";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Invalid_when_11_digits_does_not_start_with_a_1()
        {
            const string phrase = "22234567890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Valid_when_11_digits_and_starting_with_1()
        {
            const string phrase = "12234567890";
            Assert.Equal("2234567890", PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Valid_when_11_digits_and_starting_with_1_even_with_punctuation()
        {
            const string phrase = "+1 (223) 456-7890";
            Assert.Equal("2234567890", PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Invalid_when_more_than_11_digits()
        {
            const string phrase = "321234567890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Invalid_with_letters()
        {
            const string phrase = "123-abc-7890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Invalid_with_punctuations()
        {
            const string phrase = "123-@:!-7890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Invalid_if_area_code_starts_with_0()
        {
            const string phrase = "(023) 456-7890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Invalid_if_area_code_starts_with_1()
        {
            const string phrase = "(123) 456-7890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Invalid_if_exchange_code_starts_with_0()
        {
            const string phrase = "(223) 056-7890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Invalid_if_exchange_code_starts_with_1()
        {
            const string phrase = "(223) 156-7890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Invalid_if_area_code_starts_with_0_on_valid_11_digit_number()
        {
            const string phrase = "1 (023) 456-7890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Invalid_if_area_code_starts_with_1_on_valid_11_digit_number()
        {
            const string phrase = "1 (123) 456-7890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Invalid_if_exchange_code_starts_with_0_on_valid_11_digit_number()
        {
            const string phrase = "1 (223) 056-7890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Fact]
        public void Invalid_if_exchange_code_starts_with_1_on_valid_11_digit_number()
        {
            const string phrase = "1 (223) 156-7890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }
    }
}