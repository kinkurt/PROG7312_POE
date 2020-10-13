using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_TASK1
{
    class SimpleDictionary<K, V>
    {
        List<K> keys = new List<K>();
        List<V> values = new List<V>();

        public void Add(K key, V value)
        {
            if(key == null)
            {
                throw new ArgumentException("Key cannot be null.");
            }

            if(!keys.Contains(key))
            {
                keys.Add(key);
                values.Add(value);
            }
            else
            {
                throw new ArgumentException("An item with the same ket has already been added.");
            }
        }

        public bool Remove(K key)
        {
            if (keys.Contains(key))
            {
                values.RemoveAt(keys.IndexOf(key));
                keys.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Clear()
        {
            keys.Clear();
            values.Clear();
        }

        public int Size()
        {
            return keys.Count();
        }

        public V this[K key]
        {
            get
            {
                if (keys.Contains(key))
                    return values[keys.IndexOf(key)];
                else
                    throw new KeyNotFoundException("Key does not exist");
            }
            set
            {
                if (keys.Contains(key))
                    values[keys.IndexOf(key)] = value;
                else
                    throw new KeyNotFoundException("Key does not exist");
            }
        }

        public void Sort()
        {
            var keyArray = keys.ToArray();
            var valueArray = values.ToArray();

            Array.Sort(keyArray, valueArray);

            keys = new List<K>(keyArray);
            values = new List<V>(valueArray);
        }
    }
}
