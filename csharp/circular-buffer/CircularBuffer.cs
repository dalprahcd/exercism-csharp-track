using System;

namespace Exercism.CSharp.Solutions.CircularBufferExercise
{
    public class CircularBuffer<T>
    {
        private readonly T[] buffer;
        private int read;
        private int write;
        private int items;

        public CircularBuffer(int capacity)
        {
            if (capacity < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }

            buffer = new T[capacity];
            read = write = items = 0;
        }

        public T Read()
        {
            if (items == 0)
            {
                throw new InvalidOperationException("Buffer empty!");
            }

            T value = buffer[read];
            read = (read + 1) % buffer.Length;
            items--;

            return value;
        }

        public void Write(T value)
        {
            if (items == buffer.Length)
            {
                throw new InvalidOperationException("Buffer full!");
            }

            buffer[write] = value;
            write = (write + 1) % buffer.Length;
            items++;
        }

        public void Overwrite(T value)
        {
            if (items < buffer.Length)
            {
                Write(value);
            }
            else
            {
                buffer[write] = value;
                write = (write + 1) % buffer.Length;
                read = (read + 1) % buffer.Length;
            }
        }

        public void Clear()
        {
            items = 0;
            read = write;
        }
    }
}