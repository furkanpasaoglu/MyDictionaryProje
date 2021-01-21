
namespace MyDictionaryProje
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] keys;
        private TValue[] values;
        public TValue _exVal;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKey = keys;
            TValue[] tempValue = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }
            for (int j = 0; j < tempValue.Length; j++)
            {
                values[j] = tempValue[j];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public TValue Yazdir(TKey key)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                {
                    return values[i];
                }
            }
            return _exVal;
        }
    }

}