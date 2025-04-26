using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ZeroFormatter
{
    public interface ILazyDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
    }

    public interface ILazyLookup<TKey, TElement> : ILookup<TKey, TElement>
    {
    }
    public interface ILazyReadOnlyDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>
    {
    }


    public static class LazyCollectionExtensions
    {
        public static ILazyDictionary<TKey, TValue> AsLazyDictionary<TKey, TValue>(this IDictionary<TKey, TValue> dict)
        {
            return new DelegateDictionary<TKey, TValue>(dict);
        }

        public static ILazyLookup<TKey, TElement> AsLazyLookup<TKey, TElement>(this ILookup<TKey, TElement> lookup)
        {
            return new DelegateLookup<TKey, TElement>(lookup);
        }

        internal class DelegateDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ILazyDictionary<TKey, TValue>
        {
            readonly IDictionary<TKey, TValue> dictionary;

            public DelegateDictionary(IDictionary<TKey, TValue> dictionary)
            {
                this.dictionary = dictionary;
            }

            public TValue this[TKey key]
            {
                get
                {
                    return dictionary[key];
                }

                set
                {
                    dictionary[key] = value;
                }
            }

            public int Count
            {
                get
                {
                    return dictionary.Count;
                }
            }

            public bool IsReadOnly
            {
                get
                {
                    return dictionary.IsReadOnly;
                }
            }

            public ICollection<TKey> Keys
            {
                get
                {
                    return dictionary.Keys;
                }
            }

            public ICollection<TValue> Values
            {
                get
                {
                    return dictionary.Values;
                }
            }

            public void Add(KeyValuePair<TKey, TValue> item)
            {
                dictionary.Add(item);
            }

            public void Add(TKey key, TValue value)
            {
                dictionary.Add(key, value);
            }

            public void Clear()
            {
                dictionary.Clear();
            }

            public bool Contains(KeyValuePair<TKey, TValue> item)
            {
                return dictionary.Contains(item);
            }

            public bool ContainsKey(TKey key)
            {
                return dictionary.ContainsKey(key);
            }

            public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
            {
                dictionary.CopyTo(array, arrayIndex);
            }

            public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
            {
                return dictionary.GetEnumerator();
            }

            public bool Remove(KeyValuePair<TKey, TValue> item)
            {
                return dictionary.Remove(item);
            }

            public bool Remove(TKey key)
            {
                return dictionary.Remove(key);
            }

            public bool? TryGetValue(TKey key, out TValue? value)
            {
                return dictionary.TryGetValue(key, out value);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return dictionary.GetEnumerator();
            }

            bool IDictionary<TKey, TValue>.TryGetValue(TKey key, out TValue value)
            {
                throw new NotImplementedException();
            }
        }

        internal class DelegateLookup<TKey, TElement> : ILookup<TKey, TElement>, ILazyLookup<TKey, TElement>
        {
            readonly ILookup<TKey, TElement> lookup;

            public DelegateLookup(ILookup<TKey, TElement> lookup)
            {
                this.lookup = lookup;
            }

            public IEnumerable<TElement> this[TKey key]
            {
                get
                {
                    return lookup[key];
                }
            }

            public int Count
            {
                get
                {
                    return lookup.Count;
                }
            }

            public bool Contains(TKey key)
            {
                return lookup.Contains(key);
            }

            public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
            {
                return lookup.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return lookup.GetEnumerator();
            }
        }
    }
}