using System;

namespace Algorithms
{
    public class HashtableEntry
    {
        public HashtableEntry(object key, object value)
        {
            Key = key;
            Value = value;
        }

        public object Key { get; set; }
        public object? Value { get; set; }
    }
    
    public class Hashtable
    {
        private readonly int _maxCount = 0;
        private HashtableEntry[] _hashtableEntries;
            
        public Hashtable(int maxCount = 1000)
        {
            _maxCount = maxCount;
            _hashtableEntries = new HashtableEntry[maxCount];
        }

        public object? Get(object key)
        {
            var hashCodeIndex = Math.Abs(key.GetHashCode() % _maxCount);
            return _hashtableEntries[hashCodeIndex]?.Value;
        }

        public void Put(object key, object? value)
        {
            var hashCodeIndex = Math.Abs(key.GetHashCode() % _maxCount);
            var hashTableEntry = _hashtableEntries[hashCodeIndex];
            if (hashTableEntry == null)
            {
                _hashtableEntries[hashCodeIndex] = new HashtableEntry(key, value);
                return;
            }

            if (hashTableEntry.Key == key)
            {
                hashTableEntry.Value = value;
            }
        }
    }
}