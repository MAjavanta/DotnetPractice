Console.WriteLine("Hello, World!");

public class Cache<Tkey, TValue> where Tkey : notnull
{
    private Dictionary<Tkey, TValue> _cache = [];

    public bool Contains(Tkey key) => _cache.ContainsKey(key);

    public void Store(Tkey key, TValue value) => _cache[key] = value;

    public TValue GetByKey(Tkey key) => _cache[key];

}