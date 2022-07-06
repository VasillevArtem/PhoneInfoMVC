namespace PhoneInfoMVC.Models.MyHashTable
{
    public partial class HashTable
    {
        struct THashItem
        {
            public TInfo info;
            public bool empty;
            public bool visit;
        }
    }
}
