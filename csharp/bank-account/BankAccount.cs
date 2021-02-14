using System;

namespace Exercism.CSharp.Solutions.BankAccountExercise
{
    public class BankAccount
    {
        private readonly object syncLock = new object();
        private bool isClosed;
        private decimal balance;

        public void Open()
        {
            lock (syncLock)
            {
                isClosed = false;
            }
        }

        public void Close()
        {
            lock (syncLock)
            {
                isClosed = true;
            }
        }

        public decimal Balance
        {
            get
            {
                lock (syncLock)
                {
                    return isClosed
                        ? throw new InvalidOperationException()
                        : balance;
                }
            }
        }

        public void UpdateBalance(decimal change)
        {
            lock (syncLock)
            {
                if (isClosed)
                {
                    throw new InvalidOperationException();
                }
                balance += change;
            }
        }
    }
}