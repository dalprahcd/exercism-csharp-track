using System;

namespace Exercism.CSharp.Solutions.CircularBufferExercise
{
    public class CircularBuffer<T>
    {
        private readonly T[] _buffer;
        private int _read;
        private int _write;
        private int _items;

        public CircularBuffer(int capacity)
        {
            if (capacity < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }

            _buffer = new T[capacity];
            _read = _write = _items = 0;
        }

        public T Read()
        {
            if (_items == 0)
            {
                throw new InvalidOperationException("Buffer empty!");
            }

            T value = _buffer[_read];
            _read = (_read + 1) % _buffer.Length;
            _items--;

            return value;
        }

        public void Write(T value)
        {
            if (_items == _buffer.Length)
            {
                throw new InvalidOperationException("Buffer full!");
            }

            _buffer[_write] = value;
            _write = (_write + 1) % _buffer.Length;
            _items++;
        }

        public void Overwrite(T value)
        {
            if (_items < _buffer.Length)
            {
                Write(value);
            }
            else
            {
                _buffer[_write] = value;
                _write = (_write + 1) % _buffer.Length;
                _read = (_read + 1) % _buffer.Length;
            }
        }

        public void Clear()
        {
            _items = 0;
            _read = _write;
        }
    }
}