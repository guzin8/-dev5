using System;
using System.Collections.Generic;
using System.Text;

namespace ödev5
{
    class MyDictionary<Key, Value>
    {
        Key[] keys;
        Value[] values;
        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }
        public void Add(Key k, Value v)
        {
            Key[] tempKeys = keys;
            Value[] tempValues = values;
            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];

            for(int i =0; i< tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            keys[keys.Length - 1] = k;

            for(int i = 0;i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }
            values[values.Length - 1] = v;
        }

        public int Count()
        {
            return keys.Length;
        }
    }
}
