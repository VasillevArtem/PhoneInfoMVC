using PhoneInfoMVC.Models.MyHashTable;

namespace PhoneInfoMVC.Models
{
    public interface ITellInfoRepository
    {
        IQueryable<HashTable.TInfo> TellInfo { get; }
    }
}
