namespace CalculatorProblems;

public class HashNode<K, V>
{
    public K Key { get; set; }
    public V Value { get; set; }

    public HashNode(K key, V value)
    {
        Key = key;
        Value = value;
    }
}

public class CustomHashMap<K, V> where K : notnull
{
    private LinkedList<HashNode<K, V>>[] buckets;
    private int capacity;
    private int size;

    public CustomHashMap(int initialCapacity = 16)
    {
        capacity = initialCapacity;
        buckets = new LinkedList<HashNode<K, V>>[capacity];
        size = 0;
    }

    private int GetBucketIndex(K key)
    {
        int hashCode = key.GetHashCode();
        return Math.Abs(hashCode) % capacity;
    }

    public void Put(K key, V value)
    {
        int index = GetBucketIndex(key);
        if (buckets[index] == null)
        {
            buckets[index] = new LinkedList<HashNode<K, V>>();
        }

        foreach (var node in buckets[index])
        {
            if (node.Key.Equals(key))
            {
                node.Value = value;
                return;
            }
        }

        buckets[index].AddLast(new HashNode<K, V>(key, value));
        size++;
    }

    public bool Get(K key, out V? value)
    {
        int index = GetBucketIndex(key);
        if (buckets[index] != null)
        {
            foreach (var node in buckets[index])
            {
                if (node.Key.Equals(key))
                {
                    value = node.Value;
                    return true;
                }
            }
        }
        value = default;
        return false;
    }

    public bool Remove(K key)
    {
        int index = GetBucketIndex(key);
        if (buckets[index] != null)
        {
            var curr = buckets[index].First;
            while (curr != null)
            {
                if (curr.Value.Key.Equals(key))
                {
                    buckets[index].Remove(curr);
                    size--;
                    return true;
                }
                curr = curr.Next;
            }
        }
        return false;
    }

    public bool ContainsKey(K key)
    {
        return Get(key, out _);
    }

    public int Size
    {
        get { return size; }
    }
}

public class CustomHashMapImplementation
{
    public static void Run()
    {
        Console.WriteLine("--- Implement a Custom Hash Map ---");

        CustomHashMap<string, int> map = new CustomHashMap<string, int>(8);
        map.Put("Apple", 100);
        map.Put("Banana", 200);
        map.Put("Cherry", 300);

        if (map.Get("Banana", out int bananaQty))
        {
            Console.WriteLine($"Banana Quantity: {bananaQty}");
        }

        map.Put("Apple", 150);
        if (map.Get("Apple", out int appleQty))
        {
            Console.WriteLine($"Updated Apple Quantity: {appleQty}");
        }

        map.Remove("Cherry");
        Console.WriteLine($"Contains Cherry: {map.ContainsKey("Cherry")}");
        Console.WriteLine($"Total Entries in HashMap: {map.Size}");
    }
}
