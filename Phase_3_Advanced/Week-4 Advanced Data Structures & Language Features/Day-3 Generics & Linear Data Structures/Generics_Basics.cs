using System;
using System.Collections.Generic;

namespace Phase_3_Advanced.Week_4_Advanced_Data_Structures_Language_Features
{
    public class Generics_Basics
    {
        public static void Run()
        {
            var cache = new CacheManager();

            // Cache different types using the exact same generic methods
            cache.Save<string>("SessionToken", "987abc");
            cache.Save<int>("LoginAttempts", 3);

            // Strong-typed retrieval without type casting or boxing
            string token = cache.Fetch<string>("SessionToken");
            int attempts = cache.Fetch<int>("LoginAttempts");

            Console.WriteLine($"Token: {token}, Attempts: {attempts}");
        }
    }

    public class CacheManager
    {
        private readonly Dictionary<string, object> _storage = new();
        public void Save<T>(string key, T value) where T : notnull => _storage[key] = value;
        public T Fetch<T>(string key) => _storage.TryGetValue(key, out var val) ? (T)val : default!;
    }
}