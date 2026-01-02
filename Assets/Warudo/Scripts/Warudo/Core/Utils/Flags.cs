using System;
using System.Collections.Generic;

namespace Warudo.Core.Utils {
    public class Flags : SingletonMonoBehavior<Flags> {

        public List<string> keys = new();
        public List<bool> values = new();

        public static bool Get(string key, bool defaultValue) {
            for (var i = 0; i < Math.Min(Instance.keys.Count, Instance.values.Count); i++) {
                if (Instance.keys[i] == key) {
                    return Instance.values[i];
                }
            }
            Instance.keys.Add(key);
            Instance.values.Add(defaultValue);
            return defaultValue;
        }

    }
}
