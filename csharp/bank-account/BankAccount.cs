using System;

namespace Exercism.CSharp.Solutions.BankAccountExercise
{
    public class BankAccount
    {
        private readonly object _syncLock = new object();
        private bool _isClosed;
        private decimal _balance;

        public void Open()
        {
            lock (_syncLock)
            {
                _isClosed = false;
            }
        }

        public void Close()
        {
            lock (_syncLock)
            {
                _isClosed = true;
            }
        }

        public decimal Balance
        {
            get
            {
                lock (_syncLock)
                {
                    return _isClosed
                        ? throw new InvalidOperationException()
                        : _balance;
                }
            }
        }

        public void UpdateBalance(decimal change)
        {
            lock (_syncLock)
            {
                if (_isClosed)
                {
                    throw new InvalidOperationException();
                }
                _balance += change;
            }
        }
    }
}