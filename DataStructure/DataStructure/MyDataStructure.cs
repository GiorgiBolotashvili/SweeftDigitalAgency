using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure
{
    class MyDataStructure<T> : IList<T>
    {
        private T[] _items;
        private int _count;
        public T this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                _items[index] = value;
            }
        }
        public int Count { get { return _count; } }

        public bool IsReadOnly => throw new NotImplementedException();

        public MyDataStructure()
        {
            _items = new T[0];
            _count = 0;
        }

        public void Add(T item)
        {
            _count++;
            Resize(ref _items, _count);
            _items[_count - 1] = item;
        }

        public void Clear()
        {
            _items = new T[0];
            _count = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            return IndexOf(item, 0);
        }
        public int IndexOf(T item, int startIndex)
        {
            for (int i = startIndex; i < _count; i++)
            {
                if (_items[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index >= _count)
                return;
            _count++;
            Resize(ref _items, _count);

            for (int i = _count - 2; i >= index; i--)
            {
                _items[i + 1] = _items[i];
            }
            _items[index] = item;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index != -1)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < _count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            _count--;
            Resize(ref _items, _count);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private static void Resize(ref T[] array, int newSize)
        {
            if (array.Length == newSize)
                return;

            int size;

            if (array.Length < newSize)
                size = array.Length;
            else
                size = newSize;

            T[] newArray = new T[newSize];

            for (int i = 0; i < size; i++)
                newArray[i] = array[i];

            array = newArray;
        }
    }
}
