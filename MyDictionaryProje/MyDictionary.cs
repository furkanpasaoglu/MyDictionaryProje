
using System;

namespace MyDictionaryProje
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] _keys;
        private TValue[] _values;
        private TKey[] _tempKey;
        private TValue[] _tempValues;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            _tempKey = _keys;
            _tempValues = _values;
            _keys = new TKey[_keys.Length + 1];
            _values = new TValue[_values.Length + 1];
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _keys[i] = _tempKey[i];
            }
            _keys[_keys.Length - 1] = key;
            for (int j = 0; j < _tempValues.Length; j++)
            {
                _values[j] = _tempValues[j];
            }
            _values[_values.Length - 1] = value;
        }

        public int Count
        {
            get { return _keys.Length; }
        }
        
    }

}