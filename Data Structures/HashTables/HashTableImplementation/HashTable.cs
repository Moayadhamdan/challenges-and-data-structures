using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableImplementation
{
    public class HashTable<TKey, TValue>
    {
        private readonly LinkedList<KeyValuePair<TKey, TValue>>[] _buckets;
        private int _count;

        public HashTable(int size)
        {
            _buckets = new LinkedList<KeyValuePair<TKey, TValue>>[size];
        }

        // Hash function to convert key into a bucket index
        private int GetBucketIndex(TKey key)
        {
            return Math.Abs(key.GetHashCode()) % _buckets.Length;
        }

        public void Insert(TKey key, TValue value)
        {
            int index = GetBucketIndex(key);
            if (_buckets[index] == null)
            {
                _buckets[index] = new LinkedList<KeyValuePair<TKey, TValue>>();
            }

            foreach (var pair in _buckets[index])
            {
                if (EqualityComparer<TKey>.Default.Equals(pair.Key, key))
                {
                    throw new InvalidOperationException("Key already exists.");
                }
            }

            _buckets[index].AddLast(new KeyValuePair<TKey, TValue>(key, value));
            _count++;
        }

        public TValue Search(TKey key)
        {
            int index = GetBucketIndex(key);
            if (_buckets[index] != null)
            {
                foreach (var pair in _buckets[index])
                {
                    if (EqualityComparer<TKey>.Default.Equals(pair.Key, key))
                    {
                        return pair.Value;
                    }
                }
            }
            throw new KeyNotFoundException("Key not found.");
        }

        public void Remove(TKey key)
        {
            int index = GetBucketIndex(key);
            if (_buckets[index] != null)
            {
                var node = _buckets[index].First;
                while (node != null)
                {
                    if (EqualityComparer<TKey>.Default.Equals(node.Value.Key, key))
                    {
                        _buckets[index].Remove(node);
                        _count--;
                        return;
                    }
                    node = node.Next;
                }
            }
            throw new KeyNotFoundException("Key not found.");
        }

        public bool Contains(TKey key)
        {
            int index = GetBucketIndex(key);
            if (_buckets[index] != null)
            {
                foreach (var pair in _buckets[index])
                {
                    if (EqualityComparer<TKey>.Default.Equals(pair.Key, key))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Display()
        {
            for (int i = 0; i < _buckets.Length; i++)
            {
                Console.Write($"Bucket {i}: ");
                if (_buckets[i] != null)
                {
                    foreach (var pair in _buckets[i])
                    {
                        Console.Write($"[{pair.Key}: {pair.Value}] -> ");
                    }
                }
                Console.WriteLine("null");
            }
        }

        public int Count()
        {
            return _count;
        }
    }
}
