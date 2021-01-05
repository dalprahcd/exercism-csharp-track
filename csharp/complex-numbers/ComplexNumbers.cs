using System;

namespace Exercism.CSharp.Solutions.ComplexNumberExercise
{
    public struct ComplexNumber
    {
        private readonly double _real;

        private readonly double _img;

        public ComplexNumber(double real, double imaginary)
        {
            _real = real;
            _img = imaginary;
        }

        public double Real() => _real;

        public double Imaginary() => _img;

        public ComplexNumber Mul(ComplexNumber other)
        {
            var real = (_real * other._real) - (_img * other._img);
            var img = (_img * other._real) + (_real * other._img);

            return new ComplexNumber(real, img);
        }

        public ComplexNumber Add(ComplexNumber other) =>
            new ComplexNumber(_real + other._real, _img + other._img);

        public ComplexNumber Sub(ComplexNumber other) =>
            new ComplexNumber(_real - other._real, _img - other._img);

        public ComplexNumber Div(ComplexNumber other)
        {
            var div = (other._real * other._real) + (other._img * other._img);
            var real = (_real * other._real) + (_img * other._img);
            var img = (_img * other._real) - (_real * other._img);

            return new ComplexNumber(real / div, img / div);
        }

        public double Abs() => Math.Sqrt((_real * _real) + (_img * _img));

        public ComplexNumber Conjugate() =>
            new ComplexNumber(_real, -_img);

        public ComplexNumber Exp()
        {
            var factor = Math.Exp(_real);
            var real = factor * Math.Cos(_img);
            var img = factor * Math.Sin(_img);

            return new ComplexNumber(real, img);
        }
    }
}