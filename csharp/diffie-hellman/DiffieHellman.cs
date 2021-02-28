using System;
using System.Numerics;

namespace Exercism.CSharp.Solutions.DiffieHellmanExercise
{
    public static class DiffieHellman
    {
        public static BigInteger PrivateKey(BigInteger primeP) =>
            RandomIntegerBelow(primeP);

        public static BigInteger PublicKey(BigInteger primeP, BigInteger primeG, BigInteger privateKey) =>
            BigInteger.ModPow(primeG, privateKey, primeP);

        public static BigInteger Secret(BigInteger primeP, BigInteger publicKey, BigInteger privateKey) =>
            BigInteger.ModPow(publicKey, privateKey, primeP);

        /*
        *  from: https://stackoverflow.com/questions/17357760/how-can-i-generate-a-random-biginteger-within-a-certain-range/48855115
        */
        private static BigInteger RandomIntegerBelow(BigInteger N)
        {
            var random = new Random();
            var bytes = N.ToByteArray();

            BigInteger R;

            do
            {
                random.NextBytes(bytes);
                bytes[^1] &= 0x7F;

                R = new BigInteger(bytes);
            }
            while (R >= N);

            return R;
        }
    }
}