namespace DataStructures;

public class HashTableNodePair<Tkey,Tvalue>
{
    public Tkey Key { get; private set; }
    public Tvalue Value { get; set; }
    public HashTableNodePair(Tkey key, Tvalue value)
    {
        Key = key;
        Value = value;
    }
}
