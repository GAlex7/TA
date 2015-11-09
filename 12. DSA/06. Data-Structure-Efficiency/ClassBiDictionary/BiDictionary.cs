namespace ClassBiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class BiDictionary<K1, K2, T>
    {
        private MultiDictionary<K1, Guid> firstKeys = new MultiDictionary<K1, Guid>(true);
        private MultiDictionary<K2, Guid> secondKeys = new MultiDictionary<K2, Guid>(true);
        private MultiDictionary<Guid, T> values = new MultiDictionary<Guid, T>(true);

        public BiDictionary()
        {
            this.firstKeys = new MultiDictionary<K1, Guid>(true);
            this.secondKeys = new MultiDictionary<K2, Guid>(true);
            this.values = new MultiDictionary<Guid, T>(true);
        }

        public void Add(K1 key1, K2 key2, T value)
        {
            var id = this.GenerateId();
            var check = false;

            if (this.firstKeys.ContainsKey(key1) && this.secondKeys.ContainsKey(key2))
            {
                var firstIds = this.firstKeys[key1];
                var secondIds = this.secondKeys[key2];
                foreach (var id1 in firstIds)
                {
                    foreach (var id2 in secondIds)
                    {
                        if (id1 == id2)
                        {
                            check = true;
                            this.values.Add(id1, value);
                        }
                    }
                }
            }

            if (!check)
            {
                this.firstKeys.Add(key1, id);
                this.secondKeys.Add(key2, id);
                this.values.Add(id, value);
            }
        }

        public ICollection<T> Find(K1 key)
        {
            var result = new List<T>();
            if (this.firstKeys.ContainsKey(key))
            {
                var ids = this.firstKeys[key];
                foreach (var id in ids)
                {
                    foreach (var item in this.values[id])
                    {
                        result.Add(item);
                    }
                }

                return result;
            }

            return null;
        }

        public ICollection<T> Find(K2 key)
        {
            if (this.secondKeys.ContainsKey(key))
            {
                var ids = this.secondKeys[key];
                var result = new List<T>();
                foreach (var id in ids)
                {
                    foreach (var item in this.values[id])
                    {
                        result.Add(item);
                    }
                }

                return result;
            }

            return null;
        }

        public ICollection<T> Find(K1 key1, K2 key2)
        {
            var result = new List<T>();
            if (this.firstKeys.ContainsKey(key1) && this.secondKeys.ContainsKey(key2))
            {
                var firstIds = this.firstKeys[key1];
                var secondIds = this.secondKeys[key2];
                foreach (var id1 in firstIds)
                {
                    foreach (var id2 in secondIds)
                    {
                        if (id1 == id2)
                        {
                            foreach (var item in this.values[id1])
                            {
                                result.Add(item);
                            }
                        }
                    }
                }

                return result;
            }

            return null;
        }

        private Guid GenerateId()
        {
            var guid = Guid.NewGuid();
            while (this.values.ContainsKey(guid))
            {
                guid = Guid.NewGuid();
            }

            return guid;
        }
    }
}
