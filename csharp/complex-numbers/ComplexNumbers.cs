using System;

namespace Exercism.CSharp.Solutions.ComplexNumberExercise
{
    public struct ComplexNumber
    {
        private readonly double real;

        private readonly double img;

        public ComplexNumber(double real, double img)
        {
            this.real = real;
            this.img = img;
        }

        public double Real() => real;

        public double Imaginary() => img;

        public ComplexNumber Mul(ComplexNumber other)
        {
            var real = (this.real * other.real) - (this.img * other.img);
            var img = (this.img * other.real) + (this.real * other.img);

            return new ComplexNumber(real, img);
        }

        public ComplexNumber Add(ComplexNumber other) =>
            new ComplexNumber(real + other.real, img + other.img);

        public ComplexNumber Sub(ComplexNumber other) =>
            new ComplexNumber(real - other.real, img - other.img);

        public ComplexNumber Div(ComplexNumber other)
        {
            var div = (other.real * other.real) + (other.img * other.img);
            var real = (this.real * other.real) + (this.img * other.img);
            var img = (this.img * other.real) - (this.real * other.img);

            return new ComplexNumber(real / div, img / div);
        }

        public double Abs() => Math.Sqrt((real * real) + (img * img));

        public ComplexNumber Conjugate() =>
            new ComplexNumber(real, -img);

        public ComplexNumber Exp()
        {
            var factor = Math.Exp(this.real);
            var real = factor * Math.Cos(this.img);
            var img = factor * Math.Sin(this.img);

            return new ComplexNumber(real, img);
        }
    }
}