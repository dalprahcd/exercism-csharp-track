using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.SimpleLinkedListExercise
{
    public class SimpleLinkedList<T> : IEnumerable<T>
    {
        public SimpleLinkedList(T value) => Value = value;

        public SimpleLinkedList(IEnumerable<T> values) : this(values.First())
        {
            foreach (var value in values.Skip(1))
            {
                Add(value);
            }
        }

        public T Value { get; }

        public SimpleLinkedList<T> Next { get; private set; }

        public SimpleLinkedList<T> Add(T value)
        {
            var previous = this;
            var last = Next;

            while (last != null)
            {
                previous = last;
                last = previous.Next;
            }

            last = new SimpleLinkedList<T>(value);
            previous.Next = last;

            return this;
        }

        public IEnumerator<T> GetEnumerator() => new SimpleLinkedListEnumerator<T>(this);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private class SimpleLinkedListEnumerator<T2> : IEnumerator<T2>
        {
            private readonly SimpleLinkedList<T2> _head;
            private SimpleLinkedList<T2> _current;

            public SimpleLinkedListEnumerator(SimpleLinkedList<T2> head)
            {
                _head = head;
                _current = head;
            }

            object IEnumerator.Current => Current;
            public T2 Current
            {
                get
                {
                    if (_current == null)
                    {
                        throw new InvalidOperationException();
                    }

                    var value = _current.Value;
                    _current = _current.Next;

                    return value;
                }
            }

            public bool MoveNext() => _current != null;

            public void Reset() => _current = _head;

            void IDisposable.Dispose() { }
        }
    }
}